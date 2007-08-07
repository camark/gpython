using System;
using System.Collections;
using NHibernate;
using NHibernate.Expression;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// PumpClassData 的摘要说明。
	/// </summary>
	public class PumpTypeData
	{
		public PumpTypeData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static IList getPumpTypeName()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			IQuery qi_Pt=session.CreateQuery("select pt.TypeName from PumpType as pt");
			IList list=qi_Pt.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList LoadPumpType()
		{
			ISession session=ThreadLocalSession.CurrentSession();

			ICriteria cri_Pt=session.CreateCriteria(typeof(PumpType));
			IList list=cri_Pt.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static void InsertPumpType(PumpType pt)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Save(pt);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static void DeletePumpType(PumpType pt)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Delete(pt);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static PumpType FindPumpTypeById(int id)
		{	
			ISession session=ThreadLocalSession.CurrentSession();
			PumpType pt=(PumpType)session.Load(typeof(PumpType),id);
			ThreadLocalSession.CloseCurrentSession();
			return pt;
		}

		public static PumpType FindPumpTypeByName(string pumpType)
		{
			ISession session=ThreadLocalSession.CurrentSession();

			ICriteria cri_Pt=session.CreateCriteria(typeof(PumpType));
			cri_Pt.Add(Expression.Eq("TypeName",pumpType));
			IList list=cri_Pt.List();
			PumpType ft=(PumpType)list[0];
			ThreadLocalSession.CloseCurrentSession();

			return ft;
		}
	}
}
