using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Product.DataAccess;

namespace Product
{
	/// <summary>
	/// DrawTypeManager 的摘要说明。
	/// </summary>
	public class DrawTypeManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DrawTypeManager()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(13, 22);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(348, 215);
            this.dataGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(61, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "增加";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(261, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrawTypeManager
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(408, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "DrawTypeManager";
            this.Text = "图纸类别管理";
            this.Load += new System.EventHandler(this.DrawTypeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void DrawTypeManager_Load(object sender, System.EventArgs e)
		{
			LoadData();	
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			CommonAdd ca=new CommonAdd();
			if(ca.ShowDialog()==DialogResult.OK)
			{
				DrawTypeData.InsertFileType(ca.InputType);
				LoadData();
			}
		}

		private void LoadData()
		{
			IList list=DrawTypeData.LoadFileType();
			dataGrid1.DataSource=list;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			int column=dataGrid1.CurrentCell.ColumnNumber;
			int row=dataGrid1.CurrentCell.RowNumber;

			string strText=dataGrid1[row,column].ToString();
			FileType ft;
			if(column==0)
				ft=DrawTypeData.FindFileTypeById(Convert.ToInt32(strText));
			else
				ft=DrawTypeData.FindFileTypeByName(strText);

			DrawTypeData.DeleteFileType(ft);
			LoadData();
		}
	}
}
