using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using Product.Util;
using System.IO;

namespace Product
{
    public partial class BackupDlg : Form
    {
        public BackupDlg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession session = ThreadLocalSession.CurrentSession();

            IDbConnection conn = session.Connection;
            //IQuery query=session.CreateQuery(textBox1.Text);
            //IList list=query.List();

            string strTemp = "";
            if (rbToday.Checked)
                strTemp = "select * from intolib where to_days(inputtime) = to_days(now())";
            if (rbWeek.Checked)
                strTemp = "select * from intolib where week(inputtime,1) = week(now(),1) and year(inputtime) = year(now())";
            if (rbMonth.Checked)
                strTemp = "select * from intolib where month(inputtime) = month(curdate()) and year(inputtime) = year(now())";

            //string strSql = "select * from intolib where datesub(currentdate(),interval 1 " + strTemp + ")<=inputtime";
            string strSql = strTemp;

            if (rbLastMonth.Checked)
                strSql = "select * from intolib where month(inputtime)=month(curdate())-1 and year(inputtime)=year(now())";

            if (rbAll.Checked)
                strSql = "select * from intolib";
            //SqlDataAdapter adapter = new SqlDataAdapter(strSql, conn);
            ISQLQuery adapter = session.CreateSQLQuery(strSql);

            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            IList intolibs = adapter.AddEntity(typeof(IntoLib)).List();
            ThreadLocalSession.CloseCurrentSession();

            listView1.Items.Clear();
            foreach(object o in intolibs)
            {
                IntoLib il = o as IntoLib;
                ListViewItem item = new ListViewItem();
                item.Text = il.id.ToString();
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

        private string GetBackupPath()
        {
            return @"\\10.10.10.10\d$\mdt";
        }

        private string GetSavedPath(ListViewItem item)
        {
            //string result=@"\\server\产品图档库";
            string result = DataStore.getInstance().GetStorePath();
            int i = 3;
            for (; i < 7; i++)
            {
                result = result + @"\" + item.SubItems[i].Text;
            }

            return result;
        }

        private string GetVirtualPath(ListViewItem item)
        {
            string result="";
            int i = 3;
            for (; i < 6; i++)
            {
                result = result + @"\" + item.SubItems[i].Text;
            }

            return result;
        }

        private string GetBackupPath(ListViewItem item)
        {
            //string result=@"\\server\产品图档库";
            string result = DataStore.getInstance().GetBackupPath();
            int i = 3;
            for (; i < 7; i++)
            {
                result = result + @"\" + item.SubItems[i].Text;
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show(this, "当前没有可以备份的数据!");
                return;
            }

            lblProgress.Text = "开始备份...";
            int count = listView1.Items.Count;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = count+1;
            progressBar1.Step = 1;
            for (int i = 0; i < count; i++)
            {

                ListViewItem item = listView1.Items[i];

                string filetosave = GetSavedPath(item);
                lblProgress.Text = "正在备份文件:" + filetosave;
                string filetobackup = GetBackupPath(item);

                string savePath = DataStore.getInstance().GetBackupPath() + @"\" + GetVirtualPath(item);
                if (!Directory.Exists(savePath))
                    Directory.CreateDirectory(savePath);

                System.IO.File.Copy(filetosave, filetobackup,true);
                progressBar1.Value++;
            }

            lblProgress.Text = "备份完成";
        }
    }
}