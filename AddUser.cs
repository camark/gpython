using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Product
{
	/// <summary>
	/// AddUser 的摘要说明。
	/// </summary>
	public class AddUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox cmbSex;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddUser()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cmbSex = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbSex);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 320);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "输入信息";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "登陆名";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(112, 32);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(192, 21);
			this.txtID.TabIndex = 1;
			this.txtID.Text = "";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(80, 360);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(264, 360);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "姓名";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(112, 64);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(192, 21);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			// 
			// cmbSex
			// 
			this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSex.Items.AddRange(new object[] {
														"男",
														"女"});
			this.cmbSex.Location = new System.Drawing.Point(112, 104);
			this.cmbSex.Name = "cmbSex";
			this.cmbSex.Size = new System.Drawing.Size(192, 20);
			this.cmbSex.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "性别";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(112, 152);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(192, 21);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "密码";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// AddUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(408, 406);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "增加用户";
			this.Load += new System.EventHandler(this.AddUser_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void AddUser_Load(object sender, System.EventArgs e)
		{
			cmbSex.SelectedIndex=0;
		}

		private string FUserID;
		public string UserID
		{
			get 
			{
				return txtID.Text;
			}
			set 
			{
				txtID.Text=value;
			}
		}
		private string FUserName;
		public string UserName
		{
			get 
			{
				return txtName.Text;
			}
			set 
			{
				txtName.Text=value;
			}
		}
		private string FUserSex;
		public string UserSex
		{
			get 
			{
				if(cmbSex.SelectedIndex==0)
					return "M";
				else
					return "F";
			}
			set 
			{
				if(value=="M")
					cmbSex.SelectedIndex=0;
				else
					cmbSex.SelectedIndex=1;
			}
		}
		private string FUserPass;
		public string UserPass
		{
			get 
			{
				return txtPassword.Text;
			}
			set 
			{
				txtPassword.Text=value;
			}
		}

	}
}
