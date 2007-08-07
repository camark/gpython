using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Product.Util;
using Crownwood.DotNetMagic.Docking;
using Crownwood.DotNetMagic.Common;
using log4net;

namespace Product
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.ComponentModel.IContainer components;
		private DockingManager _dockingManager=null;
        private MenuItem menuItem21;
        private MenuItem menuItem22;
		private System.Windows.Forms.ListView listView1=null;

		public MainForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//

			_dockingManager=new DockingManager(this,VisualStyle.Plain);
			_dockingManager.OuterControl=statusBar1;
			listView1=new ListView();
			listView1.Columns.Add("代号",100,HorizontalAlignment.Left);
			listView1.Columns.Add("原因",300,HorizontalAlignment.Left);
			listView1.View=View.Details;

			Content infoCont=_dockingManager.Contents.Add(listView1,"信息",imageList1,1);
			_dockingManager.AddContentWithState(infoCont,State.DockBottom);

			_dockingManager.HideAllContents();
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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton7,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton8,
            this.toolBarButton5,
            this.toolBarButton9,
            this.toolBarButton10,
            this.toolBarButton6});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(520, 42);
            this.toolBar1.TabIndex = 0;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "入库";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Text = "借出";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "产品";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Text = "图纸";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Text = "查入";
            // 
            // toolBarButton9
            // 
            this.toolBarButton9.ImageIndex = 6;
            this.toolBarButton9.Name = "toolBarButton9";
            this.toolBarButton9.Text = "查出";
            // 
            // toolBarButton10
            // 
            this.toolBarButton10.Name = "toolBarButton10";
            this.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Text = "用户";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem21,
            this.menuItem11,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "(&F)文件";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "退出";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem8,
            this.menuItem9,
            this.menuItem16,
            this.menuItem17,
            this.menuItem10,
            this.menuItem18});
            this.menuItem5.Text = "(&P)产品";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "产品类别管理";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "图纸类别管理";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "查看入库记录";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 4;
            this.menuItem16.Text = "察看借出记录";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 5;
            this.menuItem17.Text = "-";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 6;
            this.menuItem10.Text = "用户管理";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 7;
            this.menuItem18.Text = "HSQL查询";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.MdiList = true;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem15,
            this.menuItem19,
            this.menuItem20});
            this.menuItem11.Text = "(&W)窗口";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "层叠";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "水平平铺";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "竖直平铺";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 3;
            this.menuItem15.Text = "排列图标";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 4;
            this.menuItem19.Text = "-";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 5;
            this.menuItem20.Text = "显示日志窗口";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem3.Text = "(&H)帮助";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "关于";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 417);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(520, 21);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Ready";
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "就绪";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "statusBarPanel2";
            this.statusBarPanel2.Width = 150;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 200;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 414);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(520, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 2;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem22});
            this.menuItem21.Text = "(&T)工具";
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 0;
            this.menuItem22.Text = "备份资料";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 438);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "产品库管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashForm splash = new SplashForm();
            splash.ShowDialog();

            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.cfg.xml"));

            MainForm mainForm = new MainForm();
			Application.Run(mainForm);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button==toolBarButton1)
			{
				AnotherIntoLib frmIn=new AnotherIntoLib();
				frmIn.MdiParent=this;
				frmIn.Show();
			}

			if(e.Button==toolBarButton2)
			{
				OutLibForm ol=new OutLibForm();
				ol.MdiParent=this;
				ol.Show();
			}

			if(e.Button==toolBarButton3)
			{
				menuItem6_Click(sender,e);
			}

			if(e.Button==toolBarButton4)
			{
				menuItem7_Click(sender,e);
			}

			if(e.Button==toolBarButton5)
			{
				menuItem9_Click(sender,e);
			}

			if(e.Button==toolBarButton6)
			{
				menuItem10_Click(sender,e);
			}

			if(e.Button==toolBarButton9)
			{
				menuItem16_Click(sender,e);
			}

		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			AboutForm about=new AboutForm();
			about.ShowDialog();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			UserManager um=new UserManager();
			um.MdiParent=this;
			um.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			IntoLibRec il=new IntoLibRec();
			il.MdiParent=this;
			il.Show();
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			ClassManager cm=new ClassManager();
			cm.MdiParent=this;
			cm.Show();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			DrawTypeManager dt=new DrawTypeManager();
			dt.MdiParent=this;
			dt.Show();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			statusBarPanel2.Text="登陆时间:"+DateTime.Now.ToString();
			
            //if(XConfig.IsConfig())
            //    Close();

			int i=0;
			LogMessage(i.ToString(),"系统开始成功运行");
//			SplashForm splash=new SplashForm();
//			splash.Show();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			OubLibFrm of=new OubLibFrm();
			of.MdiParent=this;
			of.Show();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			DwgViewer dv=new DwgViewer();
			dv.MdiParent=this;
			dv.Show();
		}


		public string ShowFindResult
		{
			set
			{
				statusBarPanel3.Text=value;	
			}
		}

		public void LogMessage(string id,string Desp)
		{
				ListViewItem item=new ListViewItem();
				item.Text=id;
				item.SubItems.Add(Desp);

				listView1.Items.Insert(0,item);
		}


		public void LogSucMessage(string desp)
		{
			int i=0;
			LogMessage(i.ToString(),desp);
		}


		public void LogFailMessage(string desp)
		{
			int i=1;
			LogMessage(i.ToString(),desp);
		}
		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			menuItem20.Checked=!menuItem20.Checked;
			Content infoContent=_dockingManager.Contents["信息"];
			if(menuItem20.Checked)
				_dockingManager.ShowContent(infoContent);
			else
				_dockingManager.HideContent(infoContent);
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            BackupDlg bd = new BackupDlg();
            bd.MdiParent = this;
            bd.Show();
        }
	}
}
