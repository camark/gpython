using System;
using NHibernate;
using NHibernate.Expression;
using Product.hbm;
using System.Collections;

namespace Product.Util
{
	/// <summary>
	/// Comm 的摘要说明。
	/// </summary>
	public class Comm
	{
		public Comm()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		

		public static string GetPumpClass(string pumpName)
		{
			string result="";
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_PClass=session.CreateCriteria(typeof(PumpClass));
			cri_PClass.Add(Expression.Eq("PumpName",pumpName));

			IList list=cri_PClass.List();
			if(list.Count>0)
			{
				PumpClass pc=(PumpClass)list[0];
				result=pc.PumpGClass;
			}

			ThreadLocalSession.CloseCurrentSession();
			return result;
		}

		public static void SavePumpClass(string pName,string pClassName)
		{
			ISession session=ThreadLocalSession.CurrentSession();
			
			PumpClass pc=new PumpClass();
			pc.PumpName=pName;
			pc.PumpGClass=pClassName;

			ITransaction ts=session.BeginTransaction();
			try
			{
				session.Save(pc);
				ts.Commit();
			}
			catch(HibernateException he)
			{
				ts.Rollback();
			}
			
			ThreadLocalSession.CloseCurrentSession();
		}

		

		

		public static  void SaveInLibRecord(string user,string PumpType,string PumpName,string fileName,string DrawType)
		{
			ISession session=ThreadLocalSession.CurrentSession();
	
			IntoLib il=new IntoLib();
			il.User=user;
			il.InputTime=DateTime.Now;
			il.PumpType=PumpType;
			il.PumpName=PumpName;
			il.FileName=fileName;
			il.DrawType=DrawType;

			ITransaction trans=session.BeginTransaction();

			try
			{
				session.Save(il);
				trans.Commit();
			}
			catch(HibernateException ex)
			{
				trans.Rollback();
			}

			ThreadLocalSession.CloseCurrentSession();
		}


		public static string GetPumpClassFromPumpName(string s)
		{
			string result="";
			ExtractType et=ImpExtractType.getInstance();
			string type=et.ExtractTypeFromName(s);

			result=Util.Comm.GetPumpClass(type);

			return result;
		}
	}
}
