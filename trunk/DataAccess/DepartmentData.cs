using System;
using NHibernate;
using NHibernate.Expression;
using System.Collections;
using Product.hbm;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// DepartmentData 的摘要说明。
	/// </summary>
	public class DepartmentData
	{
		public DepartmentData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static Department GetDepartmentFromName(string DepName)
		{
			Department result=null;
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(Department));
			cri_PClass.Add(Expression.Eq("DepartmentName",DepName));
			IList list=cri_PClass.List();

			if(list.Count>0)
			{
				Department dep=(Department)list[0];
				result=dep;
			}
			ThreadLocalSession.CloseCurrentSession();

			return result;
		}

		public static int GetDepartIdFromName(string DepName)
		{
			int result=-1;
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(Department));
			cri_PClass.Add(Expression.Eq("DepartmentName",DepName));
			IList list=cri_PClass.List();

			if(list.Count>0)
			{
				Department dep=(Department)list[0];
				result=dep.ID;
			}
			ThreadLocalSession.CloseCurrentSession();

			return result;
		}

		public static IList LoadDepartments()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(Department));
			IList list=cri_PClass.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}
	}
}
