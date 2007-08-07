using System;
using NHibernate;
using NHibernate.Expression;
using System.Collections;
using Product.hbm;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// UserData 的摘要说明。
	/// </summary>
	public class UserData
	{
		public UserData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static void DeleteUser(string UserID)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_User=session.CreateCriteria(typeof(hbm._User));
			cri_User.Add(Expression.Eq("UserID",UserID));

			IList list=cri_User.List();
			_User user=(_User)list[0];

			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Delete(user);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static void SaveUser(string ID,string Name,string Sex,string Pass,Department dep)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			_User user=new _User();
			user.UserID=ID;
			user.Name=Name;
			user.Sex=Sex;
			user.Password=Pass;
			user.Department=dep;

			ITransaction tx=session.BeginTransaction();
			try
			{
				session.Save(user);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static IList GetUsers()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(Department));
			cri_PClass.Add(Expression.Eq("ID",7));

			Department dep=(Department)cri_PClass.List()[0];
			ThreadLocalSession.CloseCurrentSession();

			return dep.Users;
		}

		public static _User GetUserFromUserID(string UserID)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(_User));
			cri_PClass.Add(Expression.Eq("UserID",UserID));
			IList list=cri_PClass.List();
			ThreadLocalSession.CloseCurrentSession();

			_User user=(_User)list[0];
			return user;
		}

		public static void MoveToDep(_User user,Department dep)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ITransaction tx=session.BeginTransaction();
			try
			{
				user.Department=dep;
				session.Update(user);
				tx.Commit();
			}
			catch(HibernateException ex)
			{
				tx.Rollback();
			}
			ThreadLocalSession.CloseCurrentSession();
		}

		public static IList GetUsersFromDepID(int id)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(Department));
			cri_PClass.Add(Expression.Eq("ID",id));

			Department dep=(Department)cri_PClass.List()[0];
			ThreadLocalSession.CloseCurrentSession();

			return dep.Users;
		}

		public static IList GetAllUsers()
		{
			
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Into=session.CreateCriteria(typeof(_User));
			IList list=cri_Into.List();
			ThreadLocalSession.CloseCurrentSession();

			return list;
		}
	}
}
