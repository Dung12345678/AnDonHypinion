using System;

namespace SD.Exceptions
{
	/// <summary>
	/// Summary description for ViewException.
	/// </summary>
	public class ViewException : Exception
	{
		public ViewException(String message) : base(message)
		{
		}
		public ViewException(Exception e)
		{
		}
	}
}