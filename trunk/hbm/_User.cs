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

		private string FUserID;
		public virtual string UserID
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
		public virtual string Name
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
		public virtual string Sex
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
		public virtual string Password
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
		public virtual int DepID
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
		public virtual byte IsOnline
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
		public virtual Department Department
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
