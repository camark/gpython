using System;
using NHibernate;
using Product.hbm;
using System.Collections;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// VersionData 的摘要说明。
	/// </summary>
	public class VersionData
	{
		public VersionData()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static string GetVersion()
		{
			ISession session=ThreadLocalSession.CurrentSession();
			ICriteria cri_Ver=session.CreateCriteria(typeof(GVersion));
			IList versions=cri_Ver.List();

            GVersion gv;
			if(versions.Count>=1)
                gv=(GVersion)versions[0];
            else
                return "1.0";

			ThreadLocalSession.CloseCurrentSession();

			return gv.Version;
		}
	}
}
