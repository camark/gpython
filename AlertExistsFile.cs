using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Product
{
    public partial class AlertExistsFileForm: Form
    {
        public AlertExistsFileForm()
        {
            InitializeComponent();
        }

        public string AlertMsg
        {
            set
            {
                label1.Text = value;
            }
        }

        public bool isOverwrite
        {
            get
            {
                return radioButton1.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}