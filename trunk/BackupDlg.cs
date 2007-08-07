using System;
using System.Collections.Generic;
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

            SqlConnection conn = session.Connection as SqlConnection;
            //IQuery query=session.CreateQuery(textBox1.Text);
            //IList list=query.List();

            string strTemp = "";
            if (rbToday.Checked)
                strTemp = "dd";
            if (rbWeek.Checked)
                strTemp = "ww";
            if (rbMonth.Checked)
                strTemp = "mm";

            string strSql = "select * from intolib where datediff(" + strTemp + ",inputtime,getdate())<1";

            if (rbLastMonth.Checked)
                strSql = "select * from intolib where datediff(mm,inputtime,getdate())<2";

            if (rbAll.Checked)
                strSql = "select * from intolib";
            SqlDataAdapter adapter = new SqlDataAdapter(strSql, conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ThreadLocalSession.CloseCurrentSession();

            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dt.Rows[i]["id"].ToString();
                item.SubItems.Add(dt.Rows[i]["InputTime"].ToString());
                item.SubItems.Add(dt.Rows[i]["UserName"].ToString());
                item.SubItems.Add(dt.Rows[i]["PumpType"].ToString());
                item.SubItems.Add(dt.Rows[i]["PumpName"].ToString());
                item.SubItems.Add(dt.Rows[i]["DrawType"].ToString());
                item.SubItems.Add(dt.Rows[i]["FileName"].ToString());
                item.SubItems.Add(dt.Rows[i]["Version"].ToString());

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