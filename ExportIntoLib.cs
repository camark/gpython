using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Product.DataAccess;
using Product.hbm;
using System.Collections;

namespace Product
{
    public partial class ExportIntoLib : Form
    {
        public ExportIntoLib()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sbResult = "";
            if (radioButton1.Checked)
                sbResult = GetIntoLibSQL();
            else
                sbResult = GetUserSQL();

            textBox1.Text = sbResult;
        }

        private static String GetIntoLibSQL()
        {
            IList intolibs = IntoLibData.GetAllIntoLibRecs();

            StringBuilder sbResult = new StringBuilder();
            foreach (object o in intolibs)
            {
                IntoLib il = o as IntoLib;

                StringBuilder sb = new StringBuilder();
                sb.Append("insert into intolib (User,InputTime,PumpName,PumpType,DrawType,FileName,Version,ProductNo) values ");
                sb.Append("('" + il.User + "'");
                sb.Append(",'" + il.InputTime.ToString() + "'");
                sb.Append(",'" + il.PumpName + "'");
                sb.Append(",'" + il.PumpType + "'");
                sb.Append(",'" + il.DrawType + "'");
                sb.Append(",'" + il.FileName + "'");
                sb.Append("," + il.Version);
                sb.Append(",'" + il.ProductNo + "'");
                sb.Append(");");

                string queryText = sb.ToString();

                sbResult.Append(Environment.NewLine);
                sbResult.Append(queryText);
                sbResult.Append(Environment.NewLine);
            }

            return sbResult.ToString(); ;
        }

        private static string GetUserSQL()
        {
            IList users = UserData.GetAllUsers();

            StringBuilder sbResult = new StringBuilder();

            foreach (object o in users)
            {
                _User user = (_User)o;
                StringBuilder sb = new StringBuilder();

                sb.Append("insert into _users (userid,name,sex,password) values ");
                sb.Append("('" + user.UserID + "'");
                sb.Append(",'" + user.Name + "'");
                sb.Append(",'" + user.Sex + "'");
                sb.Append(",'" + user.Password + "'");
                sb.Append(");");

                string queryText = sb.ToString();

                sbResult.Append(Environment.NewLine);
                sbResult.Append(queryText);
                sbResult.Append(Environment.NewLine);
   
            }

            return sbResult.ToString();
        }
    }
}