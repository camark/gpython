using System;
using System.Collections;
using NHibernate;
using NHibernate.Expression;
using Product.hbm;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// OutLibData 的摘要说明。
	/// </summary>
	public class OutLibData
	{
		public OutLibData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}


		public static IList GetAllOutLibs()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(OutLib));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static void InsertOutLib(string User,
			string PumpName,
			string DrawType,
			string PumpClass)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			OutLib ol=new OutLib();
			ol.User=User;
			ol.OutTime=DateTime.Now;
			ol.DrawType=DrawType;
			ol.PumpName=PumpName;
			ol.PumpType=PumpClass;

			ITransaction trans=session.BeginTransaction();
			try
			{
				session.Save(ol);
				trans.Commit();
			}
			catch(HibernateException he)
			{
				trans.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static IList GetOutLibByUserName(string User)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Out=session.CreateCriteria(typeof(OutLib));
			cri_Out.Add(Expression.Eq("User",User));
			IList list=cri_Out.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList GetOutLibByPumpName(string PumpName)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(OutLib));
			cri_Into.Add(Expression.Like("PumpName",@"%"+PumpName+@"%"));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}
	}
}
