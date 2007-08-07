using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Product.Util;
using Product.DataAccess;

namespace Product
{
	public class AnotherIntoLib : Crownwood.DotNetMagic.Forms.WizardDialog
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Crownwood.DotNetMagic.Controls.WizardPage wizardSelDraw;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.ComponentModel.IContainer components = null;
		private const string strLib=@"\\server\产品图档库\";
		private System.Windows.Forms.ComboBox cmbPump;
		private System.Windows.Forms.ComboBox cmbFile;
		private Crownwood.DotNetMagic.Controls.WizardPage wizardSelClass;
		private System.Windows.Forms.Label label6;
		private Crownwood.DotNetMagic.Controls.WizardPage wizardFinish;
		private bool bInit=false;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label7;
		private bool bFindType=false;

		public AnotherIntoLib()
		{
			// 该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();

			// TODO: 在 InitializeComponent 调用后添加任何初始化
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.wizardSelDraw = new Crownwood.DotNetMagic.Controls.WizardPage();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.wizardSelClass = new Crownwood.DotNetMagic.Controls.WizardPage();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbFile = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbPump = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.wizardFinish = new Crownwood.DotNetMagic.Controls.WizardPage();
			this.label7 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.wizardSelDraw.SuspendLayout();
			this.wizardSelClass.SuspendLayout();
			this.wizardFinish.SuspendLayout();
			// 
			// wizardControl
			// 
			// 
			// wizardControl.HeaderPanel
			// 
			this.wizardControl.HeaderPanel.BackColor = System.Drawing.SystemColors.Window;
			this.wizardControl.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.wizardControl.HeaderPanel.Location = new System.Drawing.Point(0, 0);
			this.wizardControl.HeaderPanel.Name = "_panelTop";
			this.wizardControl.HeaderPanel.Size = new System.Drawing.Size(568, 115);
			this.wizardControl.HeaderPanel.TabIndex = 1;
			this.wizardControl.Name = "wizardControl";
			this.wizardControl.SelectedIndex = 0;
			this.wizardControl.Size = new System.Drawing.Size(568, 430);
			this.wizardControl.Title = "欢迎使用产品入库程序";
			// 
			// wizardControl.TrailerPanel
			// 
			this.wizardControl.TrailerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.wizardControl.TrailerPanel.Location = new System.Drawing.Point(0, 357);
			this.wizardControl.TrailerPanel.Name = "_panelBottom";
			this.wizardControl.TrailerPanel.Size = new System.Drawing.Size(568, 73);
			this.wizardControl.TrailerPanel.TabIndex = 2;
			this.wizardControl.WizardPages.AddRange(new Crownwood.DotNetMagic.Controls.WizardPage[] {
																										this.wizardSelDraw,
																										this.wizardSelClass,
																										this.wizardFinish});
			this.wizardControl.Load += new System.EventHandler(this.wizardControl_Load);
			this.wizardControl.WizardPageEnter += new Crownwood.DotNetMagic.Controls.WizardControl.WizardPageHandler(this.wizardControl_WizardPageEnter);
			// 
			// wizardSelDraw
			// 
			this.wizardSelDraw.CaptionTitle = "(Product)";
			this.wizardSelDraw.Controls.Add(this.checkBox1);
			this.wizardSelDraw.Controls.Add(this.button1);
			this.wizardSelDraw.Controls.Add(this.listBox1);
			this.wizardSelDraw.FullPage = false;
			this.wizardSelDraw.InactiveBackColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.InactiveTextBackColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.InactiveTextColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.Location = new System.Drawing.Point(0, 0);
			this.wizardSelDraw.Name = "wizardSelDraw";
			this.wizardSelDraw.SelectBackColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.SelectTextBackColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.SelectTextColor = System.Drawing.Color.Empty;
			this.wizardSelDraw.Size = new System.Drawing.Size(568, 242);
			this.wizardSelDraw.SubTitle = "第一步：选择入库图纸";
			this.wizardSelDraw.TabIndex = 3;
			this.wizardSelDraw.ToolTip = "Page";
			this.wizardSelDraw.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(19, 198);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(173, 26);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "自动监测图纸类型";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(442, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "选择";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(19, 17);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(403, 172);
			this.listBox1.TabIndex = 0;
			// 
			// wizardSelClass
			// 
			this.wizardSelClass.CaptionTitle = "(Product)";
			this.wizardSelClass.Controls.Add(this.label6);
			this.wizardSelClass.Controls.Add(this.textBox3);
			this.wizardSelClass.Controls.Add(this.label5);
			this.wizardSelClass.Controls.Add(this.cmbFile);
			this.wizardSelClass.Controls.Add(this.label4);
			this.wizardSelClass.Controls.Add(this.cmbPump);
			this.wizardSelClass.Controls.Add(this.label3);
			this.wizardSelClass.Controls.Add(this.textBox2);
			this.wizardSelClass.Controls.Add(this.label2);
			this.wizardSelClass.Controls.Add(this.textBox1);
			this.wizardSelClass.Controls.Add(this.label1);
			this.wizardSelClass.FullPage = false;
			this.wizardSelClass.InactiveBackColor = System.Drawing.Color.Empty;
			this.wizardSelClass.InactiveTextBackColor = System.Drawing.Color.Empty;
			this.wizardSelClass.InactiveTextColor = System.Drawing.Color.Empty;
			this.wizardSelClass.Location = new System.Drawing.Point(0, 0);
			this.wizardSelClass.Name = "wizardSelClass";
			this.wizardSelClass.SelectBackColor = System.Drawing.Color.Empty;
			this.wizardSelClass.Selected = false;
			this.wizardSelClass.SelectTextBackColor = System.Drawing.Color.Empty;
			this.wizardSelClass.SelectTextColor = System.Drawing.Color.Empty;
			this.wizardSelClass.Size = new System.Drawing.Size(568, 242);
			this.wizardSelClass.SubTitle = "第二步：选择类别";
			this.wizardSelClass.TabIndex = 4;
			this.wizardSelClass.ToolTip = "Page";
			this.wizardSelClass.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(733, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 29);
			this.label6.TabIndex = 10;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(144, 170);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(173, 21);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(38, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "用户";
			// 
			// cmbFile
			// 
			this.cmbFile.Location = new System.Drawing.Point(144, 132);
			this.cmbFile.Name = "cmbFile";
			this.cmbFile.Size = new System.Drawing.Size(278, 21);
			this.cmbFile.TabIndex = 7;
			this.cmbFile.Text = "comboBox2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(38, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "图纸类别";
			// 
			// cmbPump
			// 
			this.cmbPump.Location = new System.Drawing.Point(144, 95);
			this.cmbPump.Name = "cmbPump";
			this.cmbPump.Size = new System.Drawing.Size(278, 21);
			this.cmbPump.TabIndex = 5;
			this.cmbPump.Text = "comboBox1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(38, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "泵类别";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(144, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(180, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "模糊类型";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(144, 17);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "名称";
			// 
			// wizardFinish
			// 
			this.wizardFinish.CaptionTitle = "(Product)";
			this.wizardFinish.Controls.Add(this.label7);
			this.wizardFinish.Controls.Add(this.progressBar1);
			this.wizardFinish.FullPage = false;
			this.wizardFinish.InactiveBackColor = System.Drawing.Color.Empty;
			this.wizardFinish.InactiveTextBackColor = System.Drawing.Color.Empty;
			this.wizardFinish.InactiveTextColor = System.Drawing.Color.Empty;
			this.wizardFinish.Location = new System.Drawing.Point(0, 0);
			this.wizardFinish.Name = "wizardFinish";
			this.wizardFinish.SelectBackColor = System.Drawing.Color.Empty;
			this.wizardFinish.Selected = false;
			this.wizardFinish.SelectTextBackColor = System.Drawing.Color.Empty;
			this.wizardFinish.SelectTextColor = System.Drawing.Color.Empty;
			this.wizardFinish.Size = new System.Drawing.Size(568, 242);
			this.wizardFinish.SubTitle = "完成";
			this.wizardFinish.TabIndex = 5;
			this.wizardFinish.ToolTip = "Page";
			this.wizardFinish.Visible = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(58, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 25);
			this.label7.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(48, 78);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(490, 25);
			this.progressBar1.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "AutoCAD Drawing(*.dwg)|*.dwg";
			this.openFileDialog1.Multiselect = true;
			// 
			// AnotherIntoLib
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 430);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnotherIntoLib";
			this.Text = "入库";
			this.Load += new System.EventHandler(this.AnotherIntoLib_Load);
			this.wizardSelDraw.ResumeLayout(false);
			this.wizardSelClass.ResumeLayout(false);
			this.wizardFinish.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				listBox1.Items.Clear();
				listBox1.Items.AddRange(openFileDialog1.FileNames);
				wizardControl.EnableNextButton=Crownwood.DotNetMagic.Controls.Status.Yes;
			}
		}

		private void wizardControl_WizardPageEnter(Crownwood.DotNetMagic.Controls.WizardPage wp, Crownwood.DotNetMagic.Controls.WizardControl wc)
		{
			if(wp.Name!="wizardFinish")
			{
				wc.ShowNextButton=Crownwood.DotNetMagic.Controls.Status.Default;
			}

			if(wp.Name=="wizardSelDraw")
			{
				if(listBox1.Items.Count==0)
					wc.EnableNextButton=Crownwood.DotNetMagic.Controls.Status.No;
				else
					wc.EnableNextButton=Crownwood.DotNetMagic.Controls.Status.Default;
			}

			if(wp.Name=="wizardSelClass" && bInit==false)
			{
				string s=listBox1.Items[0].ToString();
				textBox1.Text=GetPumpName(s);
				textBox2.Text=GetPumpClass(textBox1.Text);
				textBox3.Text=FindUser(s);

				string typeX=Util.Comm.GetPumpClass(textBox2.Text);
				if(typeX.Length>1)
				{
					cmbPump.Text=typeX;
					bFindType=true;
					label6.Text="Find It!";
				}

				bInit=true;
			}

			if(wp.Name=="wizardFinish")
			{
				//wc.EnableNextButton=Crownwood.DotNetMagic.Controls.Status.No;
				wc.ShowNextButton=Crownwood.DotNetMagic.Controls.Status.No;
				wc.ShowCancelButton=Crownwood.DotNetMagic.Controls.Status.No;
				wc.EnableFinishButton=Crownwood.DotNetMagic.Controls.Status.No;
				wc.ShowBackButton=Crownwood.DotNetMagic.Controls.Status.No;
				IntoLibG();
				wc.EnableFinishButton=Crownwood.DotNetMagic.Controls.Status.Default;
			}
		}

		private void AnotherIntoLib_Load(object sender, System.EventArgs e)
		{
			wizardControl.EnableNextButton=Crownwood.DotNetMagic.Controls.Status.No;

			wizardSelDraw.Visible=true;
			LoadPumpType();
			LoadFileType();
		}


		private string GetPumpName(string s)
		{
			string strResult="";
			s=Path.GetFileName(s);
			string[] HorzArrays=s.Split(new char[]{'-'});
			if(HorzArrays.Length>=3)
			{
				strResult=HorzArrays[0]+"-"+HorzArrays[1];
			}
			else 
			{
				
				if(HorzArrays.Length==1)
				{
					strResult=HorzArrays[0];
				}
				else
				{
					if(HorzArrays.Length==2)
						strResult=HorzArrays[0]+"-"+HorzArrays[1].Substring(0,3);
				}
			}

			return strResult;
		}

		private string GetPumpClass(string s)
		{
			ExtractType et=ImpExtractType.getInstance();
			string type=et.ExtractTypeFromName(s);

			return type;
		}

		private string FindUser(string s)
		{						
			string s1=@"\";
			string[] strs=s.Split(s1.ToCharArray());
			return strs[1];
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

		private string CombinePath()
		{
			return strLib+@"\"+cmbPump.Text+@"\"+textBox1.Text+@"\"+cmbFile.Text;
		}

		private void IntoLibG()
		{
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
				MainForm mf=ParentForm as MainForm;
				foreach(object s in listBox1.Items)
				{						
					progressBar1.Value++;
					strFile=Path.GetFileName(s.ToString());
					string destFile=str_Path+@"\"+strFile;
					try
					{
						File.Copy(s.ToString(),destFile,true);
						
						Util.Comm.SaveInLibRecord(textBox3.Text,
							cmbPump.Text,
							textBox1.Text,
							strFile,
							cmbFile.Text);

						mf.LogSucMessage("拷贝 "+strFile+" 到 "+destFile+"成功");
					}
					catch(Exception e)
					{
						mf.LogFailMessage(e.Message);
					}
						
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor=curCursor;
				label7.Text="完成";
				//progressBar1.Value=0;
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

		private void wizardControl_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}

