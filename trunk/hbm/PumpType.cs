using System;

namespace Product
{
	/// <summary>
	/// PumpType ��ժҪ˵����
	/// </summary>
	public class PumpType
	{
		public PumpType()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
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
