using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Product.DataAccess;
using Product.hbm;
using System.IO;

namespace Product
{
	/// <summary>
	/// OutLib 的摘要说明。
	/// </summary>
	public class OutLibForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label5;

		private const string strLib=@"\\server\产品图档库\";
		private const string strPrint=@"\\server\打印目录\";
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OutLibForm()
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(72, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(248, 20);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "comboBox1";
			// 
			// comboBox2
			// 
			this.comboBox2.Location = new System.Drawing.Point(72, 296);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(248, 20);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "comboBox2";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(240, 344);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "借出";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "借阅人:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 264);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "图纸类别";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 176);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "产品型号";
			// 
			// comboBox3
			// 
			this.comboBox3.Location = new System.Drawing.Point(72, 216);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(248, 20);
			this.comboBox3.TabIndex = 6;
			this.comboBox3.Text = "comboBox3";
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "泵类型";
			// 
			// comboBox4
			// 
			this.comboBox4.Location = new System.Drawing.Point(72, 136);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(248, 20);
			this.comboBox4.TabIndex = 8;
			this.comboBox4.Text = "comboBox4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 136);
			this.label5.Name = "label5";
			this.label5.TabIndex = 9;
			this.label5.Text = "没找到";
			// 
			// OutLibForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 382);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "OutLibForm";
			this.Text = "借阅图纸";
			this.Load += new System.EventHandler(this.OutLib_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void OutLib_Load(object sender, System.EventArgs e)
		{
			IList userList=UserData.GetAllUsers();
			foreach(object o in userList)
			{
				_User u=(_User)o;
				comboBox1.Items.Add(u.Name);
			}

			comboBox1.SelectedIndex=0;

			IList DrawTypes =DrawTypeData.LoadFileType();
			foreach(object a in DrawTypes)
			{
				FileType ft=(FileType)a;
				comboBox2.Items.Add(ft.Type);
			}

			comboBox2.SelectedIndex=0;

			IList PumpNames=IntoLibData.GetIntoLibPumpNames();
			foreach(object pn in PumpNames)
			{
				comboBox3.Items.Add(pn.ToString());
			}

			comboBox3.SelectedIndex=0;

			IList TypeNames=PumpTypeData.getPumpTypeName();
			foreach(object tn in TypeNames)
			{
				comboBox4.Items.Add(tn.ToString());
			}

			comboBox4.SelectedIndex=0;
		}

		private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string s=comboBox3.Text;
			string type=Util.Comm.GetPumpClassFromPumpName(s);

			if(type.Length!=0)
			{
				label5.Text="找到了";
				comboBox4.Text=type;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string dirDest=strPrint+comboBox1.Text;
			string srcDest=strLib+comboBox4.Text+@"\"+comboBox3.Text+@"\"+comboBox2.Text+@"\";
			
			if(!Directory.Exists(srcDest))
			{
				MessageBox.Show(this,srcDest+"不存在！");
				return;
			}

			string[] files=Directory.GetFiles(srcDest);
	
			foreach(string strFile in files)
			{
				string sFile=dirDest+@"\"+comboBox2.Text+@"\"+Path.GetFileName(strFile);
				string sDir=Path.GetDirectoryName(sFile);
				if(!Directory.Exists(sDir))
					Directory.CreateDirectory(sDir);

				File.Copy(strFile,sFile,true);
			}

			OutLibData.InsertOutLib(comboBox1.Text,comboBox3.Text,comboBox2.Text,comboBox4.Text);
			MessageBox.Show(this,"借出成功！");
		}
	}
}
