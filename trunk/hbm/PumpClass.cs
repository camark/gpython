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
		public virtual int ID
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
		public virtual string PumpName
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
		public virtual string PumpGClass
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
