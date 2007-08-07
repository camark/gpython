using System; 
using NHibernate; 
using NHibernate.Cfg; 
 
namespace Product.Util 
{ 	
	public class ThreadLocalSession 
	{ 
		static ThreadLocalSession()  
		{ 
			Configuration config = new Configuration(); 
			config.AddAssembly("Product");
			ThreadLocalSession.factory = config.BuildSessionFactory(); 
		} 
 
		private ThreadLocalSession() 
		{ 
			throw new NotSupportedException("Should not be calling the ctor of ThreadLocalSession"); 
		} 
 
		internal static ISessionFactory factory; 
 
		[ThreadStatic]
		internal static ISession session; 
 		
		public static ISession CurrentSession()  
		{ 
			if(session==null)  
			{ 
				ThreadLocalSession.session = ThreadLocalSession.factory.OpenSession(); 
			} 
 
			return ThreadLocalSession.session; 
 
		} 
 		
		public static void CloseCurrentSession()  
		{ 
			if(ThreadLocalSession.session==null) return; 
 
			ThreadLocalSession.session.Close();
			ThreadLocalSession.session = null; 
		} 
 
	} 
} 

