using System;

namespace Product.Util
{
	/// <summary>
	/// ExtractName 的摘要说明。
	/// </summary>
	public interface ExtractType
	{
		string ExtractTypeFromName(string s);
	}

	public class ImpExtractType:ExtractType
	{
		public string ExtractTypeFromName(string s)
		{
			int iLen=s.Length;

			string s1=s.ToUpper();
			int i=0;

			while(s1[i]<'A'|| s1[i]>'Z')
			{
				i++;
			}

			int j=i;
			while(s1[i]>'A' && s1[i]<'Z')
			{
				i++;
			}

            
			int num=0;
			if(i>j)
				num=i-j;
			else
				num=j-i;

            if (num == 0)
                return "";
     
			return s1.Substring(j,num-1);
		}

		public static ExtractType getInstance()
		{
			ImpExtractType iet=new ImpExtractType();
			return iet as ExtractType;
		}

        private ImpExtractType()
        {
        }
	}
}
