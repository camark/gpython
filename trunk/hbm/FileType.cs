using System;

namespace Product
{
	/// <summary>
	/// FileType ��ժҪ˵����
	/// </summary>
	public class FileType
	{
		public FileType()
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
