using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Product.hbm;
using System.Diagnostics;
using Product;
using Product.DataAccess;
using Product.Util;

namespace Product
{
	/// <summary>
	/// IntoLibRec 的摘要说明。
	/// </summary>
	public class IntoLibRec : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
        private Button button4;
        private ColumnHeader columnHeader8;
        private TabPage tabPage5;
        private Label label5;
        private TextBox tbProductNo;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntoLibRec()
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "所有记录";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(20, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 90);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(425, 64);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图纸名称";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入图纸名称:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(425, 64);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(107, 22);
            this.comboBox1.MaxDropDownItems = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "comboBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入用户名:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(425, 64);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "类别查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(93, 22);
            this.comboBox3.MaxDropDownItems = 28;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(234, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "comboBox3";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "输入类别";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(425, 64);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "泵型号";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(73, 22);
            this.comboBox2.MaxDropDownItems = 20;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "comboBox2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "泵型号:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8});
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(20, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 317);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "编号";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "入库日期";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "人员";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "泵类型";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "泵名称";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "图纸类型";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "文件名";
            this.columnHeader5.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "版本号";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "选择相同用户";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "选择相同的图纸类型";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "选择相同的泵名称";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "反向选择";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "全选";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.Text = "全不选";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 21);
            this.button3.TabIndex = 7;
            this.button3.Text = "拷贝选择文件";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "发送邮件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.tbProductNo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(425, 64);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "制造编号";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(77, 21);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(316, 20);
            this.tbProductNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "制造编号";
            // 
            // IntoLibRec
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(480, 486);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "IntoLibRec";
            this.Text = "IntoLibRec";
            this.Load += new System.EventHandler(this.IntoLibRec_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			IList list=IntoLibData.GetAllIntoLibRecs();
			FillList(list);
			LogFindResult();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(tabControl1.SelectedTab==tabPage1)
			{
				if(textBox1.Text=="")
				{
					MessageBox.Show(this,"信息输入不完整!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				IList list1=IntoLibData.GetIntoLibByFileName(textBox1.Text);
				FillList(list1);
			}

			if(tabControl1.SelectedTab==tabPage2)
			{				

				IList list1=IntoLibData.GetIntoLibByUser(comboBox1.Text);
				FillList(list1);
			}

			if(tabControl1.SelectedTab==tabPage3)
			{				
				IList list1=IntoLibData.GetIntoLibByPumpType(comboBox3.Text);
				FillList(list1);
			}

			if(tabControl1.SelectedTab==tabPage4)
			{				
				IList list1=IntoLibData.GetIntoLibByPumpName(comboBox2.Text);
				FillList(list1);
			}

            if (tabControl1.SelectedTab == tabPage5)
            {
                if (tbProductNo.Text == "")
                {
                    
                        MessageBox.Show(this, "信息输入不完整!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                   
                }
                IList list1 = IntoLibData.GetIntoLibByProductNo(tbProductNo.Text);
                FillList(list1);
            }


			LogFindResult();
		}

		private void IntoLibRec_Load(object sender, System.EventArgs e)
		{
			IList listUser=UserData.GetAllUsers();
			foreach(object o in listUser)
			{
				_User u=(_User)o;
				comboBox1.Items.Add(u.Name);
			}

			comboBox1.SelectedIndex=0;

			IList PumpNames=IntoLibData.GetIntoLibPumpNames();
			foreach(object o1 in PumpNames)
			{
				comboBox2.Items.Add(o1.ToString());
			}
			comboBox2.SelectedIndex=0;


			IList PumpClass=PumpTypeData.getPumpTypeName();
			foreach(object o2 in PumpClass)
			{
				comboBox3.Items.Add(o2.ToString());
			}
			comboBox3.SelectedIndex=0;
		}

		

		private void GoPath(string Path)
		{
			ProcessStartInfo startInfo=new ProcessStartInfo(@"IExplore.exe",@"file://"+Path);

			startInfo.WindowStyle=ProcessWindowStyle.Maximized;
			Process.Start(startInfo);
		}


		private void FillList(IList PumpList)
		{
			listView1.Items.Clear();

			foreach(object o in PumpList)
			{
				IntoLib il=o as IntoLib;

				ListViewItem item=new ListViewItem();
				item.Text=il.id.ToString();
				item.SubItems.Add(il.InputTime.ToString());
				item.SubItems.Add(il.User);
				item.SubItems.Add(il.PumpType);
				item.SubItems.Add(il.PumpName);
				item.SubItems.Add(il.DrawType);
				item.SubItems.Add(il.FileName);
                item.SubItems.Add(il.Version.ToString());

				listView1.Items.Add(item);
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			SelSomeItem(2);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			SelSomeItem(4);
		}

		/// <summary>
		/// 反向选择
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem item1 in listView1.Items)
			{				
					item1.Checked=!item1.Checked;
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			SelSomeItem(6);
		}

		/// <summary>
		/// 选择类型
		/// </summary>
		/// <param name="type">
		/// 2、选择相同用户
		/// 4、选择相同的泵
		/// 6、选择系统的图纸类型
		/// </param>
		private void SelSomeItem(int type)
		{
			ListViewItem item;
			if(listView1.Items.Count>0)
			{
				item=listView1.SelectedItems[0];
			
				string user=item.SubItems[type].ToString();
				foreach(ListViewItem item1 in listView1.Items)
				{
					if(item1.SubItems[type].ToString()==user)
						item1.Checked=true;
				}
			}
			
		}

		/// <summary>
		/// 全部选择
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem item1 in listView1.Items)
			{				
				item1.Checked=true;
			}
		}

		/// <summary>
		/// 全部不选择
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem item1 in listView1.Items)
			{				
				item1.Checked=false;
			}
		}

		private string GetSavedPath(ListViewItem item)
		{
            //string result=@"\\server\产品图档库";
            string result = DataStore.getInstance().GetStorePath();
			int i=3;
			for(;i<7;i++)
			{
				result=result+@"\"+item.SubItems[i].Text;
			}

			return result;
		}

		/// <summary>
		/// 拷贝选定文件到指定文件夹
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, System.EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
			{
				MainForm mf=this.ParentForm as MainForm;
				foreach(ListViewItem item in listView1.CheckedItems)
				{
					string FileName=GetSavedPath(item);
					string destFile=folderBrowserDialog1.SelectedPath+@"\"+item.SubItems[6].Text;
					if(File.Exists(FileName))
					{
						try
						{
							File.Copy(FileName,destFile,true);
							mf.LogSucMessage("拷贝"+FileName+"到"+destFile+"成功");
							}
						catch(Exception ex)
						{
							mf.LogFailMessage(ex.Message);
						}
					}
					else
					{
						int i=2;
						mf.LogMessage(i.ToString(),FileName+"=>不存在");
					}
				}

				MessageBox.Show(this,"成功完成拷贝!");
			}
		}

		private void LogFindResult()
		{
			int count=listView1.Items.Count;

			MainForm mf=this.ParentForm as MainForm;
			mf.LogSucMessage("已经找到"+count.ToString()+"条记录");
		}

        private void button4_Click(object sender, EventArgs e)
        {
            //ListViewItem item;
            MailDrawing m_MailDrawing = new MailDrawing();

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string fileName = GetSavedPath(item);
                m_MailDrawing.Drawing.Add(fileName);
            }

            m_MailDrawing.SendMail();
        }
	}
}
