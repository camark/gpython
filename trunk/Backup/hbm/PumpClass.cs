using System;

namespace Product
{
	/// <summary>
	/// PumpClass 的摘要说明。
	/// </summary>
	public class PumpClass
	{
		public PumpClass()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		private int FID;
		public int ID
		{
			get 
			{
				return FID;
			}
			set 
			{
				FID=value;
			}
		}

		private string FPumpName;
		public string PumpName
		{
			get 
			{
				return FPumpName;
			}
			set 
			{
				FPumpName=value;
			}
		}
		private string FPumpGClass;
		public string PumpGClass
		{
			get 
			{
				return FPumpGClass;
			}
			set 
			{
				FPumpGClass=value;
			}
		}
	}
}
