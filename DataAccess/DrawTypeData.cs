using System;
using System.Collections;
using NHibernate;
using NHibernate.Expression;
using Product.Util;
using Product.hbm;

namespace Product.DataAccess
{
	/// <summary>
	/// DrawTypeData 的摘要说明。
	/// </summary>
	public class DrawTypeData
	{
		public DrawTypeData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static IList LoadFileType()
		{
			ISession session=ThreadLocalSession.CurrentSession();

			ICriteria cri_Pt=session.CreateCriteria(typeof(FileType));
			IList list=cri_Pt.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}

		public static void InsertFileType(string TypeName)
		{
			ISession session=ThreadLocalSession.CurrentSession();

			FileType ft=new FileType();
			ft.Type=TypeName;
			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Save(ft);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}


		public static FileType FindFileTypeById(int id)
		{	
			ISession session=ThreadLocalSession.CurrentSession();
			FileType ft=(FileType)session.Load(typeof(FileType),id);
			ThreadLocalSession.CloseCurrentSession();
			return ft;
		}

		public static void DeleteFileType(FileType ft)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Delete(ft);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static FileType FindFileTypeByName(string fileType)
		{
			ISession session=ThreadLocalSession.CurrentSession();

			ICriteria cri_Pt=session.CreateCriteria(typeof(FileType));
			cri_Pt.Add(Expression.Eq("Type",fileType));
			IList list=cri_Pt.List();
			FileType ft=(FileType)list[0];
			ThreadLocalSession.CloseCurrentSession();

			return ft;
		}
	}
}
