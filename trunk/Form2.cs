using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Product.Util;
using Product.DataAccess;

namespace Product
{
	/// <summary>
	/// Form2 的摘要说明。
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox cmbPump;
		private System.Windows.Forms.ComboBox cmbFile;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox textBox3;
		private const string strLib=@"\\server\产品图档库\";
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox pictureBox1;

		private bool bFindType=false;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.cmbFile = new System.Windows.Forms.ComboBox();
			this.cmbPump = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "AutoCAD Drawing(*.dwg)|*.dwg";
			this.openFileDialog1.Multiselect = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(16, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(472, 360);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkBox1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(464, 335);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "第一步";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(24, 296);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(200, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "自动检测并存储类型";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(288, 296);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "Open";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(24, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(344, 268);
			this.listBox1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.cmbFile);
			this.tabPage2.Controls.Add(this.cmbPump);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(464, 335);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "第二步";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(424, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(80, 240);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 4;
			this.textBox3.Text = "";
			// 
			// cmbFile
			// 
			this.cmbFile.Location = new System.Drawing.Point(80, 192);
			this.cmbFile.MaxDropDownItems = 19;
			this.cmbFile.Name = "cmbFile";
			this.cmbFile.Size = new System.Drawing.Size(328, 20);
			this.cmbFile.TabIndex = 3;
			this.cmbFile.Text = "comboBox2";
			// 
			// cmbPump
			// 
			this.cmbPump.Location = new System.Drawing.Point(80, 136);
			this.cmbPump.MaxDropDownItems = 20;
			this.cmbPump.Name = "cmbPump";
			this.cmbPump.Size = new System.Drawing.Size(328, 20);
			this.cmbPump.TabIndex = 2;
			this.cmbPump.Text = "comboBox1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(80, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(328, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Controls.Add(this.progressBar1);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(464, 335);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "第三步";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "进行:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(24, 80);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(384, 24);
			this.progressBar1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 400);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "Next";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(504, 446);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "产品入库";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				foreach(string s in openFileDialog1.FileNames)
				{
					listBox1.Items.Add(s);
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(tabControl1.SelectedTab==tabPage3)
				return;
			#region Tab1
			if(tabControl1.SelectedTab==tabPage1)
			{
				string s=listBox1.Items[0].ToString();
				s=Path.GetFileName(s);
				string[] HorzArrays=s.Split(new char[]{'-'});
				if(HorzArrays.Length>=3)
				{
					textBox1.Text=HorzArrays[0]+"-"+HorzArrays[1];
				}
				else 
				{
				
					if(HorzArrays.Length==1)
					{
						textBox1.Text=HorzArrays[0];
					}
					else
					{
						if(HorzArrays.Length==2)
							textBox1.Text=HorzArrays[0]+"-"+HorzArrays[1].Substring(0,3);
					}
				}
				
				ExtractType et=ImpExtractType.getInstance();
				string type=et.ExtractTypeFromName(textBox1.Text);
				textBox2.Text=type;

				string typeX=Util.Comm.GetPumpClass(textBox2.Text);

				if(typeX.Length>1)
				{
					cmbPump.Text=typeX;
					pictureBox1.Visible=true;
					bFindType=true;
				}

				textBox3.Text=FindUser();
				tabControl1.SelectedTab=tabPage2;

				return;
			}
			#endregion

			#region Tab2			
			if(tabControl1.SelectedTab==tabPage2)
			{
				tabControl1.SelectedTab=tabPage3;
				if(checkBox1.Checked && !bFindType)
				{
					Util.Comm.SavePumpClass(textBox2.Text,cmbPump.Text);	
				}
				string str_Path=CombinePath();
				string strFile;

				if(!Directory.Exists(str_Path))
				{
					Directory.CreateDirectory(str_Path);
				}

				Cursor curCursor=this.Cursor;
				try
				{
					
					this.Cursor=Cursors.WaitCursor;
					int iCount=listBox1.Items.Count;
					progressBar1.Minimum=0;
					progressBar1.Maximum=iCount;
					label1.Text="正在入库....";
					foreach(object s in listBox1.Items)
					{						
						progressBar1.Value++;
						strFile=Path.GetFileName(s.ToString());
						File.Copy(s.ToString(),str_Path+@"\"+strFile,true);
						
						Util.Comm.SaveInLibRecord(textBox3.Text,
							cmbPump.Text,
							textBox1.Text,
							strFile,
							cmbFile.Text,
                            "Hello");
						
					}

				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					this.Cursor=curCursor;
					label1.Text="进行";
					progressBar1.Value=0;
				}


				if(cmbFile.Text== @"产品\模型图")
				{
					string fileName;
					string Moxing=@"\\server\模型图\";
					foreach(object s in listBox1.Items)
					{
						fileName=s.ToString();
						File.Copy(fileName,Moxing+Path.GetFileName(fileName),true);
					}
				}

				MessageBox.Show(this,"入库成功！","注意",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			#endregion
		}

		private void LoadPumpType()
		{
			cmbPump.Items.Clear();
			IList list=PumpTypeData.LoadPumpType();

			foreach(Object o in list)
			{
				PumpType pt=(PumpType)o;
				cmbPump.Items.Add(pt.TypeName);
			}

			cmbPump.SelectedIndex=0;
		}

		private void LoadFileType()
		{
			cmbFile.Items.Clear();
			
			IList list=DrawTypeData.LoadFileType();

			foreach(Object o in list)
			{
				FileType ft=(FileType)o;
				cmbFile.Items.Add(ft.Type);
			}

			cmbFile.SelectedIndex=0;
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
			LoadPumpType();
			LoadFileType();
		}

		private string FindUser()
		{
			string s=listBox1.Items[0].ToString();
			
			string s1=@"\";
			string[] strs=s.Split(s1.ToCharArray());
			return strs[1];
		}

		private string AddSingleDot(string s)
		{
			return "'"+s+"'";
		}
		private string CombinePath()
		{
			return strLib+@"\"+cmbPump.Text+@"\"+textBox1.Text+@"\"+cmbFile.Text;
		}
	}
}
