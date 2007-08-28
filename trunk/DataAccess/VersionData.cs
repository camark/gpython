using System;
using NHibernate;
using Product.hbm;
using System.Collections;
using Product.Util;

namespace Product.DataAccess
{
	/// <summary>
	/// VersionData ��ժҪ˵����
	/// </summary>
	public class VersionData
	{
		public VersionData()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
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
