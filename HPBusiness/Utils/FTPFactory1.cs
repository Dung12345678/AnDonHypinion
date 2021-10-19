using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows.Forms;

namespace HP
{
    public class FTPFactory1
    {
        #region Public Variables
		/// <summary>
		/// IP address or hostname to connect to
		/// </summary>
		public string server;
		/// <summary>
		/// Username to login as
		/// </summary>
		public string user;
		/// <summary>
		/// Password for account
		/// </summary>
		public string pass;
		/// <summary>
		/// Port number the FTP server is listening on
		/// </summary>
		public int port;
        /// <summary>
        /// Data downloaded
        /// </summary>
        private byte[] downloadedData;
		#endregion
		#region Constructors
		/// <summary>
		/// Constructor
		/// </summary>
		public FTPFactory1()
		{
			server = null;
			user = null;
			pass = null;
			port = 21;
            getFtp();
        }
        public FTPFactory1(string _server, string _user, string _pass)
        {
            server = _server;
            user = _user;
            pass = _pass;
            port = 21;
        }

        #endregion
        /// <summary>
        /// Hàm lấy ftp từ file defaul.ini
        /// </summary>
        /// <returns> host , user , pass</returns>
        public void getFtp()
        {
            try
            {
                string[] Infor = new string[12];
               // string strPath = Application.StartupPath.ToString() + @"\default.ini";
                string strPath = Application.StartupPath.ToString() + @"\"+Global.DefaultFileName;
                FileStream file = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                int i = 0;
                while (i < 12)
                {
                    Infor[i] = sr.ReadLine();
                    i = i + 1;
                }
                sr.Close();
                file.Close();
                server = Infor[8].ToString();
                user = Infor[9].ToString();
                pass = Infor[10].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "get FTP Error");
            }
        }

        
        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="FTPAddress"></param>
        /// <param name="filePath"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public bool uploadFile(string filename,string filePath)
        {
            try
            {
                //Create FTP request
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + server + "/" + filename + Path.GetFileName(filePath));

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                //Load the file
                FileStream stream = File.OpenRead(filePath);
                byte[] buffer = new byte[stream.Length];

                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                //Upload file
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();

                ///MessageBox.Show("Uploaded Successfully");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool uploadFile(string filename, object filePath)
        {
            try
            {
                //Create FTP request
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create( server + "/" + filename);

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                //Load the file
                FileStream stream = File.OpenRead(filePath.ToString());
                byte[] buffer = new byte[stream.Length];

                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                //Upload file
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();

                ///MessageBox.Show("Uploaded Successfully");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Download file
        /// </summary>
        /// <param name="FTPAddress"></param>
        /// <param name="filename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public bool downloadFile(string filename)
        {
            downloadedData = new byte[0];

            try
            {
                //Optional
                Application.DoEvents();

                //Create FTP request
                //Note: format is ftp://server.com/file.ext
                FtpWebRequest request = FtpWebRequest.Create("ftp://"+server + "/" + filename) as FtpWebRequest;

                //Optional
                Application.DoEvents();

                //Get the file size first (for progress bar)
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(user , pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true; //don't close the connection

                int dataLength = (int)request.GetResponse().ContentLength;

                //Optional
                Application.DoEvents();

                //Now get the actual data
                request = FtpWebRequest.Create("ftp://"+server + "/" + filename) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(user, pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false; //close the connection when done

                //Set up progress bar
                //progressBar1.Value = 0;
                //progressBar1.Maximum = dataLength;
                //lbProgress.Text = "0/" + dataLength.ToString();

                //Streams
                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                byte[] buffer = new byte[1024]; //downloads in chuncks

                while (true)
                {
                    Application.DoEvents(); //prevent application from crashing

                    //Try to read the data
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        //Nothing was read, finished downloading
                        //progressBar1.Value = progressBar1.Maximum;
                        //lbProgress.Text = dataLength.ToString() + "/" + dataLength.ToString();

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);

                        ////Update the progress bar
                        //if (progressBar1.Value + bytesRead <= progressBar1.Maximum)
                        //{
                        //    progressBar1.Value += bytesRead;
                        //    lbProgress.Text = progressBar1.Value.ToString() + "/" + dataLength.ToString();

                        //    progressBar1.Refresh();
                        //    Application.DoEvents();
                        //}
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                reader.Close();
                memStream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error connecting to the FTP Server.");
                return false;
            }

            //txtData.Text = downloadedData.Length.ToString();
            //this.Text = "Download Data through FTP";

            user = string.Empty;
            pass = string.Empty;
        }
        public void saveFileDialog(string fileName){
            Application.DoEvents();

            FileStream newFile = new FileStream(fileName, FileMode.Create);
            newFile.Write(downloadedData, 0, downloadedData.Length);
            newFile.Close();
        }
    }
}
