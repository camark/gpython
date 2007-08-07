using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Product.hbm;
using Product.DataAccess;

namespace Product
{
	/// <summary>
	/// OubLibFrm 的摘要说明。
	/// </summary>
	public class OubLibFrm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OubLibFrm()
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 144);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(440, 328);
			this.dataGrid1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 112);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "所有记录";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(16, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(440, 88);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(432, 63);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "用户";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名:";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(104, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(312, 20);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "comboBox1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 112);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "查询";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(432, 63);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "图纸名称";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 16);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "图纸名称:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(144, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(256, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// OubLibFrm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(472, 486);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "OubLibFrm";
			this.Text = "OubLibFrm";
			this.Load += new System.EventHandler(this.OubLibFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			IList outs=OutLibData.GetAllOutLibs();
			dataGrid1.DataSource=outs;
		}

		private void OubLibFrm_Load(object sender, System.EventArgs e)
		{
			IList listUser=UserData.GetAllUsers();
			foreach(object o in listUser)
			{
				_User u=(_User)o;
				comboBox1.Items.Add(u.Name);
			}

			comboBox1.SelectedIndex=0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(tabControl1.SelectedTab==tabPage2)
			{
				if(textBox1.Text=="")
				{
					MessageBox.Show(this,"信息输入不完整!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				IList list1=OutLibData.GetOutLibByPumpName(textBox1.Text);
				dataGrid1.DataSource=list1;
			}

			if(tabControl1.SelectedTab==tabPage1)
			{				

				IList list1=OutLibData.GetOutLibByUserName(comboBox1.Text);
				dataGrid1.DataSource=list1;
			}

		}
	}
}
