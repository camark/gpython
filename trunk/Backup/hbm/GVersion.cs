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
		
		private string FVersion;
		public string Version
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
