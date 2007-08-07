using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Product.Util
{
	/// <summary>
	/// XConfig 的摘要说明。
	/// </summary>
	public class XConfig
	{
		private const string Regkey=@"software\pleasure\Product";
		public XConfig()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		private bool RegLocked()
		{
			bool result=true;
			RegistryKey regKey=Registry.CurrentUser;

			RegistryKey productKey=regKey.OpenSubKey(Regkey,true);

			if(productKey==null)
			{
				productKey=regKey.CreateSubKey(Regkey);
			}

			object value=productKey.GetValue("Lockit","1");
			if(value==null)
				return true;
			else
			{
				if(value=="1")
					return false;
				else
					return true;
			}

			return result;
		}
		public static bool IsConfig()
		{
			if(SystemInformation.ComputerName.ToUpper()=="KFCH-02" || SystemInformation.ComputerName.ToUpper()=="KF-01" || SystemInformation.ComputerName.ToUpper()=="KFCH-01")
				return false;

			DateTime dnow=DateTime.Now;
			if(dnow.Year>2007)
				return false;
			return true;
		}
	}
}
