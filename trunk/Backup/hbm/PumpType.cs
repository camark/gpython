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

		public int ID
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

		public string TypeName
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
