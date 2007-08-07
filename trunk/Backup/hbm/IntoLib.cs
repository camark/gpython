using System;

namespace Product
{
	/// <summary>
	/// IntoLib 的摘要说明。
	/// </summary>
	public class IntoLib
	{
		public IntoLib()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 数据库自动编号
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
		/// 入库人员的姓名
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
		/// 入库时间
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
		/// 泵的类型
		/// 如：单机双吸泵等
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
		/// 泵的名称
		/// 如:DC100-80
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
		/// 图纸类型
		/// 如：产品图纸、产品模型、冷工艺、冷工装等
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
		/// 入库的文件名称
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
