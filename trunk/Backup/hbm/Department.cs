using System;
using System.Collections;

namespace Product.hbm
{
	/// <summary>
	/// Department ��ժҪ˵����
	/// </summary>
	public class Department
	{
		public Department()
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
