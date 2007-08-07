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
	/// UserManager 的摘要说明。
	/// </summary>
	public class UserManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;

		/// <summary>
		/// Var for DragDrop
		/// </summary>		
		private Rectangle dragBoxFromMouseDown;
		private Point screenOffset;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnuDelete;
		private System.Windows.Forms.MenuItem mnuAddUser;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserManager()
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuAddUser = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(120, 446);
            this.treeView1.TabIndex = 0;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(120, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 446);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(122, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 446);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.listView1_QueryContinueDrag);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "登陆名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "密码";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddUser,
            this.mnuDelete});
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.Index = 0;
            this.mnuAddUser.Text = "增加..";
            this.mnuAddUser.Click += new System.EventHandler(this.mnuAddUser_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 1;
            this.mnuDelete.Text = "删除";
            this.mnuDelete.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // UserManager
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 446);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Name = "UserManager";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserManager_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void UserManager_Load(object sender, System.EventArgs e)
		{
			TreeNode node=new TreeNode();
			node.Text="技术中心";

			IList deps=DepartmentData.LoadDepartments();
			foreach(object o in deps)
			{
				hbm.Department dep=(hbm.Department)o;
				TreeNode node1=new TreeNode();
				node1.Text=dep.DepartmentName;
				node.Nodes.Add(node1);
			}

			treeView1.Nodes.Add(node);
			treeView1.ExpandAll();
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			TreeNode node=e.Node;
			string s=node.Text;

			hbm.Department dep=DepartmentData.GetDepartmentFromName(s);
			IList list;
			if(dep==null)
			{
				list=UserData.GetUsers();
			}
			else
			{
				list=dep.Users;
			}

			listView1.Items.Clear();
			foreach(Object o in list)
			{
				hbm._User user=(hbm._User)o;
				ListViewItem item=new ListViewItem();
				item.Text=user.UserID;
				item.SubItems.Add(user.Name);
				item.SubItems.Add(Convert.ToString(user.Sex));
				item.SubItems.Add(Convert.ToString(user.Password));
				item.SubItems.Add(Convert.ToString(user.IsOnline));
				listView1.Items.Add(item);
			}
		}

		private void treeView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(e.Data.GetDataPresent(typeof(ListViewItem)))
			{				
				ListViewItem item=(ListViewItem)e.Data.GetData(typeof(ListViewItem));
				Point pt=new Point(e.X,e.Y);
				pt=this.PointToClient(pt);
//				treeView1.Select();
				TreeNode node=treeView1.GetNodeAt(pt);
				if(node==null)	
				{
					MessageBox.Show(this,"Not Found!");
					return;
				}
				hbm.Department dep=DepartmentData.GetDepartmentFromName(node.Text);
				hbm._User user=UserData.GetUserFromUserID(item.Text);
				UserData.MoveToDep(user,dep);
				listView1.Items.Remove(item);
				MessageBox.Show(this,item.Text+dep.DepartmentName);
			}
		}

		private void listView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(listView1.SelectedItems.Count==1)
			{
				Size dragSize=SystemInformation.DragSize;
				dragBoxFromMouseDown=new Rectangle(new Point(e.X-(dragSize.Width/2),e.Y-(dragSize.Height/2)),dragSize);
			}
			else
				dragBoxFromMouseDown=Rectangle.Empty;
		}

		private void listView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if((e.Button & MouseButtons.Left)==MouseButtons.Left)
			{
				if(dragBoxFromMouseDown!=Rectangle.Empty &&
					!dragBoxFromMouseDown.Contains(e.X,e.Y))
				{
					screenOffset=SystemInformation.WorkingArea.Location;
					DragDropEffects dropEffect=listView1.DoDragDrop(listView1.SelectedItems[0],DragDropEffects.Move);
				}
			}
		}

		private void listView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dragBoxFromMouseDown=Rectangle.Empty;
		}

		private void treeView1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{									
			if(!e.Data.GetDataPresent(typeof(ListViewItem)))
			{
				e.Effect=DragDropEffects.None;
				return;
			}
			else
			{
				e.Effect=DragDropEffects.Move;
				treeView1.SelectedNode=treeView1.GetNodeAt(e.X,e.Y);
			}
		}

		private void listView1_QueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
		{
			ListView lv=sender as ListView;
			if(lv!=null)
			{
				Form f=lv.FindForm();

				if(((Control.MousePosition.X-screenOffset.X)<f.DesktopBounds.Left) ||
					((Control.MousePosition.X-screenOffset.X)>f.DesktopBounds.Right) ||
					((Control.MousePosition.Y-screenOffset.Y)<f.DesktopBounds.Top) ||
					((Control.MousePosition.Y-screenOffset.Y)>f.DesktopBounds.Bottom))
				{
					e.Action=DragAction.Cancel;
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedItems.Count>0)
			{
				if(MessageBox.Show(this,"你确实要删除这些人员吗?","Warning",MessageBoxButtons.OKCancel)==DialogResult.OK)
				{
					UserData.DeleteUser(listView1.SelectedItems[0].Text);
					listView1.Items.Remove(listView1.SelectedItems[0]);
				}
			}
		}

		private void mnuAddUser_Click(object sender, System.EventArgs e)
		{
			TreeNode node=treeView1.SelectedNode;
			Department dep=DepartmentData.GetDepartmentFromName(node.Text);
			AddUser au=new AddUser();
			if(au.ShowDialog()==DialogResult.OK)
			{
				string User_ID=au.UserID;
				string UserName=au.UserName;
				string UserPass=au.UserPass;
				string UserSex=au.UserSex;

				UserData.SaveUser(User_ID,UserName,UserSex,UserPass,dep);
				ListViewItem item=new ListViewItem();
				item.Text=User_ID;
				item.SubItems.Add(UserName);
				item.SubItems.Add(UserSex);
				item.SubItems.Add(UserPass);
				listView1.Items.Add(item);
			}
		}
	}
}
