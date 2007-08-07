using System;

namespace Product.hbm
{
	/// <summary>
	/// GVersion 的摘要说明。
	/// </summary>
	public class GVersion
	{
		public GVersion()
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
