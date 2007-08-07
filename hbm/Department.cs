using System;
using System.Collections;

namespace Product.hbm
{
	/// <summary>
	/// Department 的摘要说明。
	/// </summary>
	public class Department
	{
		public Department()
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

		private string FDepartmentName;
		public virtual string DepartmentName
		{
			get 
			{
				return FDepartmentName;
			}
			set 
			{
				FDepartmentName=value;
			}
		}

		private IList FUsers;
		public virtual IList Users
		{
			get 
			{
				return FUsers;
			}
			set 
			{
				FUsers=value;
			}
		}

	}
}
