using System;

namespace Product
{
	/// <summary>
	/// FileType 的摘要说明。
	/// </summary>
	public class FileType
	{
		public FileType()
		{
			//
			// TODO: 在此处添加构造函数逻辑
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

		private string FType;
		public virtual string Type
		{
			get 
			{
				return FType;
			}
			set 
			{
				FType=value;
			}
		}

	}
}
