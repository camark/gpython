using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Product
{
    public partial class SelectMail : Form
    {
        public SelectMail()
        {
            InitializeComponent();
        }

        //private string ReciverName;

        public string Reciver
        {
            get { return textBox1.Text ; }
            set { textBox1.Text  = value; }
        }
	
        private void SelectMail_Load(object sender, EventArgs e)
        {

        }
    }
}