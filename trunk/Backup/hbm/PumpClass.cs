using System;

namespace Product
{
	/// <summary>
	/// PumpClass ��ժҪ˵����
	/// </summary>
	public class PumpClass
	{
		public PumpClass()
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
