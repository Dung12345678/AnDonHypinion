using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BMS.Utils;
using System.Diagnostics;
using System.Net;
using System.Data;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using BMS.Model;
using BMS.Business;
using Microsoft.Win32;
using DevExpress.Utils;
using System.Drawing;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.Repository;
using KarlsTools;

//using Excel = Microsoft.Office.Interop.Excel;


namespace BMS
{
	public partial class frmMain : _Forms
	{
		private const string CURRENT_VERSION = "01.04.2019";
		//bool _loginOK = false;
		bool _isUpdated = false;
		bool _logOut = false;

		private string _pathFileConfigUpdate = Path.Combine(Application.StartupPath, "ConfigUpdate.txt");
		private string _pathFolderUpdate;
		private string _pathUpdateServer;
		private string _pathFileVersion;
		string _pathError = Path.Combine(Application.StartupPath, "Errors");
		public frmMain()
		{
			Global.ComputerName = TextUtils.GetHostName();
			DocUtils.InitFTPQLSX();
			//Check update version
			//updateVersion();
			//if (!_isUpdated)// && ConnectdToBD)
			//{
			//	//frmLogin frm = new frmLogin();
			//	//frm.ShowDialog();
			//	//_loginOK = frm.loginSuccess;
			//	if (frm.loginSuccess == false)
			//	{
			//		Application.Exit(); return;
			//	}
			//	else
			//	{
			InitializeComponent();
			//	}
			//}
		}
		#region Các sụ kiện liên quan đến phím tắt.
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool handled = false;
			//if (keyData.ToString().Equals("Escape"))
			//    return true;
			if (keyData.ToString().Equals("Alt + F4"))
				Application.Exit();
			ShortcutKey.LoadFormShortcutKey(this, keyData.ToString(), ref handled);
			//return base.ProcessCmdKey(ref msg, keyData);
			return (handled || base.ProcessCmdKey(ref msg, keyData));
		}
		#endregion

		void loadCurrentVersion()
		{
			string sql = "select top 1 * from BackupVersion where IsUse = 1";
			DataTable dt = TextUtils.Select(sql);
			if (dt.Rows.Count == 0)
			{
				this.Text += $" - Dữ liệu đang xem trống. Bạn hãy chọn dữ liệu muốn xem.";
				return;
			}
			this.Text += $" - Dữ liệu đang xem từ {TextUtils.ToDate3(dt.Rows[0]["StartDate"]).ToString("dd/MM/yyyy")} " +
				$"đến {TextUtils.ToDate3(dt.Rows[0]["EndDate"]).ToString("dd/MM/yyyy")}";
		}
		private void Main_Load(object sender, EventArgs e)
		{
			string Version = File.ReadAllText(Application.StartupPath + "/Version.txt");
			this.Text += "   -   Version: " + Version;
			//MainMenu.Visible = false;
			//PopupInformationSys();
			lblUser.Text = $"Login by: {Global.AppUserName}";
			SetMainView();
			try
			{
				RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
				if (!rkey.GetValue("sShortDate", "MM/dd/yy").ToString().Contains("M/yyyy"))
				{
					//if (MessageBox.Show("Định dạng ngày tháng trên máy của bạn không phải là định dạng của Việt Nam (ngày/tháng/năm - dd/MM/yyyy)\n Bạn có muốn đổi lại định dạng ngày tháng không ?", TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					//{
					rkey.SetValue("sShortDate", "dd/MM/yyyy");
					//}
				}
				rkey.Close();
			}
			catch
			{
			}
			DefValues.Sql_MinDate = new DateTime(1900, 01, 01);
			//if (!Global.IsReal)
			//{
			//	this.BackColor = Color.Pink;
			//	this.ribbonControl1.BackColor = Color.Pink;
			//	loadCurrentVersion();

			//	frmChooseBackupVersion frm = new frmChooseBackupVersion();
			//	if (frm.ShowDialog() == DialogResult.OK)
			//	{
			//		loadCurrentVersion();
			//	}
			//}
			//else
			//{
			//	//	ribbonPageShowDataOld.Visible = false;
			//}


		}
		void updateVersion()
		{
			if (!File.Exists(_pathFileConfigUpdate)) return;
			try
			{
				string[] lines = File.ReadAllLines(_pathFileConfigUpdate);
				if (lines == null) return;
				if (lines.Length < 2) return;

				string[] stringSeparators = new string[] { "||" };
				string[] arr = lines[1].Split(stringSeparators, 4, StringSplitOptions.RemoveEmptyEntries);

				if (arr == null) return;
				if (arr.Length < 4) return;

				_pathFolderUpdate = Path.Combine(Application.StartupPath, arr[1].Trim());
				_pathUpdateServer = arr[2].Trim();
				_pathFileVersion = Path.Combine(Application.StartupPath, arr[3].Trim());
				if (!Directory.Exists(_pathError))
				{
					Directory.CreateDirectory(_pathError);
				}
				if (!Directory.Exists(_pathFolderUpdate))
				{
					Directory.CreateDirectory(_pathFolderUpdate);
				}
				if (!File.Exists(_pathFileVersion))
				{
					File.Create(_pathFileVersion);
					File.WriteAllText(_pathFileVersion, "1");
				}

				int currentVerion = TextUtils.ToInt(File.ReadAllText(_pathFileVersion).Trim());
				string[] listFileSv = DocUtils.GetFilesList(_pathUpdateServer);
				if (listFileSv == null) return;
				if (listFileSv.Length == 0) return;

				List<string> lst = listFileSv.ToList();
				lst = lst.Where(o => o.Contains(".zip")).ToList();
				int newVersion = lst.Max(o => TextUtils.ToInt(Path.GetFileNameWithoutExtension(o)));

				if (newVersion != currentVerion)
				{
					Process.Start(Path.Combine(Application.StartupPath, "UpdateVersion.exe"));
				}
			}
			catch { }
		}
		private void CheckAutoUpdate()
		{
			try
			{
				if (!_isUpdated)
					return;
				try
				{
					this.Hide();
					MessageBox.Show("Đã có phiên bản mới của phần mềm để cập nhật.\nBạn hãy chắc chắn rằng mình đang đăng nhập vào Windows với quyền Admin để update phần mềm", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					using (Process compiler = new Process())
					{
						compiler.StartInfo.FileName = Application.StartupPath + @"\AutoUpdater.exe";
						compiler.StartInfo.UseShellExecute = false;
						compiler.StartInfo.RedirectStandardOutput = false;
						compiler.Start();
					}
					Application.Exit();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
			}
			catch (System.Data.SqlClient.SqlException)
			{
				MessageBox.Show("Kết nối tới máy chủ thất bại!\nHãy liên hệ với quản trị hệ thống để được trợ giúp", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetMainView()
		{
			//switch (TextUtils.ToInt(Global.MainViewID))
			//{
			//case 2:
			//    ribbonControl1.SelectedPage = ribbonAccounting;
			//    break;
			//case 3:
			//    ribbonControl1.SelectedPage = ribbonBuildingManage;
			//    break;
			//default: //case 4:
			//ribbonControl1.SelectedPage = ribbonWareHouse;
			//break;
			//case 5:
			//ribbonControl1.SelectedPage = ribbonPageHyp;
			//    break;
			//case 6:
			//    ribbonControl1.SelectedPage = ribbonHKP;
			//    break;
			//default:
			//     ribbonControl1.SelectedPage = ribbonDefault;
			//     break;
			//}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Close();
		}

		private void btnExit_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
				this.Close();
			else
				return;
		}

		private void btnStaffManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmStaffManager frm = new frmStaffManager();
			TextUtils.OpenForm(frm); //TextUtils.TextUtils.OpenForm();
		}

		private void btnDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmDepartment frm = new frmDepartment();
			TextUtils.OpenForm(frm);
		}

		private void btnPermission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmPermissionManager frm = new frmPermissionManager();
			TextUtils.OpenForm(frm);
		}

		private void btnMakeRole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmRole frm = new frmRole();
			TextUtils.OpenForm(frm);
		}

		bool _update = false;
		private void cậpNhậtPhầnMềmAutoUpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có thực sự muốn update phần mềm không?", TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				_update = true;
				this.Close();
			}
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			frmChangePassword frm = new frmChangePassword();
			frm.ShowDialog();
		}

		private void btnPermission_Click(object sender, EventArgs e)
		{
			frmPermissionManager frm = new frmPermissionManager();
			TextUtils.OpenForm(frm);
		}

		private void btnMakeRole_Click(object sender, EventArgs e)
		{
			frmRole frm = new frmRole();
			TextUtils.OpenForm(frm);
		}

		private void btnModuleManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//frmModuleManager frm = new frmModuleManager();
			//TextUtils.OpenForm(frm);
		}

		private void ConfigSystemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmConfigSystem frm = new frmConfigSystem();
			TextUtils.OpenForm(frm);
		}

		private void btnSuppliers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//frmCustomer frm = new frmCustomer();
			//TextUtils.OpenForm(frm);
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_logOut = true;
			this.Close();
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_logOut)
			{
				string path = Application.StartupPath + "\\RTC.exe";
				Process.Start(path);
			}
		}

		private void pHÂNQUYỀNTHEONHÓMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPermissionGroup frm = new frmPermissionGroup();
			TextUtils.OpenForm(frm);
		}

		private void btnArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmProduct frm = new frmProduct();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmStaffManager(), this);
		}

		private void btnDepartment_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmStaffGroup(), this);
		}

		private void btnParkingLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			TextUtils.OpenChildForm(new frmProductType(), this);
		}

		private void btnBlock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void btnBuidlingM_Vehicle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//TextUtils.OpenForm(new frmParking());
		}

		private void btnMonthlyCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//TextUtils.OpenForm(new frmMonthlyCard());
		}

		private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenForm(new frmCustomer());
		}

		private void btnCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmWorking(), this);
		}

		private void btnDepartment1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmDepartment(), this);
		}

		private void btnHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmHistoryCheck(), this);
		}

		private void btnCheckWithProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
		}

		private void runCriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TextUtils.OpenForm(new frmScript());
		}

		private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TextUtils.OpenForm(new frmImportProductExcel());
		}

		private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmChangePassword frm = new frmChangePassword();
			frm.ShowDialog();
		}

		private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_logOut = true;
			this.Close();
		}

		private void btnPermission1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmPermissionManager frm = new frmPermissionManager();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnMakeRoleGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmUserGroup frm = new frmUserGroup();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmGear frm = new frmGear();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnGear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmGearInfo frm = new frmGearInfo();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmPlan frm = new frmPlan();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnFindDataCD1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmFindDataCD1(), this);
		}

		private void btnThongKePhanTichData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmThongKePhanTichData(), this);
		}

		private void btnDanhMucSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmGearWorking frm = new frmGearWorking();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnNhapTestler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmImportGearExcel frm = new frmImportGearExcel();
			TextUtils.OpenChildForm(frm, this);
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmExportAndon frm = new frmExportAndon();
			frm.Show();
		}

		private void btnCheckingHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmListOrder frm = new frmListOrder();
			TextUtils.OpenChildForm(frm, this);
		}

		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmReportTester frm = new frmReportTester();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnProductHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmProductH frm = new frmProductH();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnWorkingHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmWorkingH(), this);
		}

		private void btnHistoryHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmHistoryCheckH(), this);
		}

		private void btnFindDataCD1Hyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmFindDataCD1H(), this);
		}

		private void btnThongKePhanTichDataHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmThongKePhanTichDataH(), this);
		}
		private void btnReportAndonHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmExportAndonHyp(), this);
		}
		private void btnReportAndonAltax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmExportAndon(), this);
		}

		private void btn_productionplan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmProceductionPlan frm = new frmProceductionPlan();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnChangeHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductWorkingAudit(), this);
		}

		private void btnShowDataOld_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//TextUtils.OpenChildForm(new frmChooseBackupVersion(), this);
			frmChooseBackupVersion frm = new frmChooseBackupVersion();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				loadCurrentVersion();
			}
		}

		private void btnConfigFormulaCD5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmConfigFormulaCD5H frm = new frmConfigFormulaCD5H();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnConfigShipTo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmConfigShipToH frm = new frmConfigShipToH();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnConfigFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmConfigFormulaAllH frm = new frmConfigFormulaAllH();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnProductPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductPlan(), this);
		}

		private void btnNumberProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductCheckHistoryDetailPCA(), this);
		}

		private void btnNumberProductAltaxx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductCheckHistoryDetailPCAAltax(), this);
		}

		private void btnConfigShipToAltax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmConfigShipTo frm = new frmConfigShipTo();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnDSLinhKien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductListSON(), this);
		}

		private void btnDSLinhKienMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//frmMotorPartList frm = new frmMotorPartList();
			//TextUtils.OpenChildForm(frm, this);
		}

		private void btnPlanSon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmSonPlan frm = new frmSonPlan();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnHistorySon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmPartImExHistory frm = new frmPartImExHistory();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnHistoryMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//frmMotorHistoryImEx frm = new frmMotorHistoryImEx();
			//TextUtils.OpenChildForm(frm, this);
		}

		private void btnPlanMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void btnSetJig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmweightJig frm = new frmweightJig();
			TextUtils.OpenChildForm(frm, this);
		}
		private void btnStockCD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmStockCD frm = new frmStockCD();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnAssemblyOrder_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmAssemblyOrder frm = new frmAssemblyOrder();
			TextUtils.OpenChildForm(frm, this);
		}
		private void btnHistoryPartOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHistoryPartOut frm = new frmHistoryPartOut();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnDanhSachKhoDao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmKnifeSharpenNew frm = new frmKnifeSharpenNew();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnBieuDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmKnifeProcessedChart frm = new frmKnifeProcessedChart();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnWorkingDaoJig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmWorkingDaoJig frm = new frmWorkingDaoJig();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnDanhSachKhoJig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmJigList frm = new frmJigList();
			TextUtils.OpenChildForm(frm, this);

		}

		private void btnCheckMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmCheckMotor frm = new frmCheckMotor();
			TextUtils.OpenChildForm(frm, this);
		}

		private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmShapeList frm = new frmShapeList();
			TextUtils.OpenChildForm(frm, this);
		}
		private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHypMold frm = new frmHypMold();
			//TextUtils.OpenChildForm(frm, this);
			frm.Show();
		}

		private void btnCheckHistoryDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHistoryCheckHP frm = new frmHistoryCheckHP();
			TextUtils.OpenChildForm(frm, this);
		}

		private void barButtonItem16_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHypMoldLine frm = new frmHypMoldLine();
			frm.Show();
		}

		private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmKnifeCount frm = new frmKnifeCount();
			frm.Show();
		}

		private void btnGoods_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmGoods frm = new frmGoods();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnGoodsAndDaoJig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmRegister frm = new frmRegister();
			TextUtils.OpenChildForm(frm, this);
		}

		private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHypMeasuringTools frm = new frmHypMeasuringTools();
			//TextUtils.OpenChildForm(frm, this);
			frm.Show();

		}

		private void btnJig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmDaoJigLine frm = new frmDaoJigLine();
			frm.Show();
		}

		private void btnImportMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmImportMotor frm = new frmImportMotor();
			TextUtils.OpenChildForm(frm, this);
		}

		private void btnKhoMotor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmImportMotor frm = new frmImportMotor();
			frm.Show();
		}

		private void btnGiaCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmKnifeProcessedList frm = new frmKnifeProcessedList();
			frm.Show();
		}

		private void btnDungCu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmMeasuringToolLine frm = new frmMeasuringToolLine();
			frm.Show();
		}

		private void btnKhuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmHypMoldDaoJigLine frm = new frmHypMoldDaoJigLine();
			frm.Show();
		}

        private void View_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			frmProductKnife frm = new frmProductKnife();
			frm.Show();
		}

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			frmStageMachine frm = new frmStageMachine();
			frm.Show();
		}
    }
}