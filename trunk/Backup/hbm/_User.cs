using System;

namespace Product.hbm
{
	/// <summary>
	/// _User ��ժҪ˵����
	/// </summary>
	public class _User
	{
		public _User()
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

		private string FUserID;
		public string UserID
		{
			get 
			{
				return FUserID;
			}
			set 
			{
				FUserID=value;
			}
		}
		private string FName;
		public string Name
		{
			get 
			{
				return FName;
			}
			set 
			{
				FName=value;
			}
		}
		private string FSex;
		public string Sex
		{
			get 
			{
				return FSex;
			}
			set 
			{
				FSex=value;
			}
		}

		private string FPassword;
		public string Password
		{
			get 
			{
				return FPassword;
			}
			set 
			{
				FPassword=value;
			}
		}
		private int FDepID;
		public int DepID
		{
			get 
			{
				return FDepID;
			}
			set 
			{
				FDepID=value;
			}
		}

		private byte FIsOnline;
		public byte IsOnline
		{
			get 
			{
				return FIsOnline;
			}
			set 
			{
				FIsOnline=value;
			}
		}

		private Department FDepartment;
		public Department Department
		{
			get 
			{
				return FDepartment;
			}
			set 
			{
				FDepartment=value;
			}
		}

	}
}
