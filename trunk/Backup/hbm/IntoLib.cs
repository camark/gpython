using System;

namespace Product
{
	/// <summary>
	/// IntoLib ��ժҪ˵����
	/// </summary>
	public class IntoLib
	{
		public IntoLib()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		/// <summary>
		/// ���ݿ��Զ����
		/// </summary>
		private int Fid;
		public int id
		{
			get 
			{
				return Fid;
			}
			set 
			{
				Fid=value;
			}
		}

		/// <summary>
		/// �����Ա������
		/// </summary>
		private string FUser;
		public string User
		{
			get 
			{
				return FUser;
			}
			set 
			{
				FUser=value;
			}
		}

		/// <summary>
		/// ���ʱ��
		/// </summary>
		private DateTime FInputTime;
		public DateTime InputTime
		{
			get 
			{
				return FInputTime;
			}
			set 
			{
				FInputTime=value;
			}
		}

		/// <summary>
		/// �õ�����
		/// �磺����˫���õ�
		/// </summary>
		private string FPumpType;
		public string PumpType
		{
			get 
			{
				return FPumpType;
			}
			set 
			{
				FPumpType=value;
			}
		}

		/// <summary>
		/// �õ�����
		/// ��:DC100-80
		/// </summary>
		private string FPumpName;
		public string PumpName
		{
			get 
			{
				return FPumpName;
			}
			set 
			{
				FPumpName=value;
			}
		}
		/// <summary>
		/// ͼֽ����
		/// �磺��Ʒͼֽ����Ʒģ�͡��乤�ա��乤װ��
		/// </summary>
		private string FDrawType;
		public string DrawType
		{
			get 
			{
				return FDrawType;
			}
			set 
			{
				FDrawType=value;
			}
		}

		/// <summary>
		/// �����ļ�����
		/// </summary>
		private string FFileName;
		public string FileName
		{
			get 
			{
				return FFileName;
			}
			set 
			{
				FFileName=value;
			}
		}
	}
}
