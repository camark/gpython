using System;

namespace Product.hbm
{
	/// <summary>
	/// OutLib ��ժҪ˵����
	/// </summary>
	public class OutLib
	{
		public OutLib()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
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
		private string FUser;
		public string User
		{
			get 
			{
				return FUser;
			}
			set 
			{
				FUser=value;
			}
		}
		private DateTime FOutTime;
		public DateTime OutTime
		{
			get 
			{
				return FOutTime;
			}
			set 
			{
				FOutTime=value;
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
		private string FDrawType;
		public string DrawType
		{
			get 
			{
				return FDrawType;
			}
			set 
			{
				FDrawType=value;
			}
		}

		private string FPumpType;
		public string PumpType
		{
			get 
			{
				return FPumpType;
			}
			set 
			{
				FPumpType=value;
			}
		}

	}
}
