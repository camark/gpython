using System;

namespace Product.hbm
{
	/// <summary>
	/// GVersion ��ժҪ˵����
	/// </summary>
	public class GVersion
	{
		public GVersion()
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
		
		private string FVersion;
		public virtual string Version
		{
			get 
			{
				return FVersion;
			}
			set 
			{
				FVersion=value;
			}
		}

	}
}
