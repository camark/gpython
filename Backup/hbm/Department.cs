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

		private string FDepartmentName;
		public string DepartmentName
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
		public IList Users
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
