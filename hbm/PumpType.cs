using System;

namespace Product
{
	/// <summary>
	/// PumpType 的摘要说明。
	/// </summary>
	public class PumpType
	{
		public PumpType()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		private int id;
		private string typeName;

		public virtual int ID
		{
			get
			{
				return id;
			}
			set
			{
				id=value;
			}
		}

		public virtual string TypeName
		{
			get
			{
				return typeName;
			}
			set
			{
				typeName=value;
			}
		}
	}
}
