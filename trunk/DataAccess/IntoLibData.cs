using System;
using NHibernate;
using NHibernate.Expression;
using System.Collections;
using Product.hbm;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// IntoLibData 的摘要说明。
	/// </summary>
	public class IntoLibData
	{
		public IntoLibData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static IList GetAllIntoLibRecs()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(IntoLib));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList GetIntoLibByFileName(string FileName)
		{
			
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(IntoLib));
			cri_Into.Add(Expression.Like("FileName","%"+FileName+"%"));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList GetIntoLibByUser(string User)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(IntoLib));
			cri_Into.Add(Expression.Eq("User",User));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList GetIntoLibByPumpType(string PumpType)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(IntoLib));
			cri_Into.Add(Expression.Eq("PumpType",PumpType));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

        public static IList GetIntoLibByProductNo(string ProductNo)
        {
            ISession session = ThreadLocalSession.CurrentSession();
            ICriteria cri_Into = session.CreateCriteria(typeof(IntoLib));
            cri_Into.Add(Expression.Eq("ProductNo", ProductNo));
            IList list = cri_Into.List();
            ThreadLocalSession.CloseCurrentSession();

            return list;
        }
		public static IList GetIntoLibByPumpName(string PumpName)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(IntoLib));
			cri_Into.Add(Expression.Like("PumpName",@"%"+PumpName+@"%"));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static IList GetIntoLibPumpNames()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			IQuery qi=session.CreateQuery("select distinct il.PumpName from Product.IntoLib as il ");
			IList list=qi.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}
	}
}
