using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Product
{
	/// <summary>
	/// CommonAdd ��ժҪ˵����
	/// </summary>
	public class CommonAdd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CommonAdd()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(32, 88);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(144, 88);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			// 
			// CommonAdd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 134);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CommonAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "������";
			this.ResumeLayout(false);

		}
		#endregion

		public string InputType
		{
			get
			{
				return textBox1.Text;
			}
			set
			{
				textBox1.Text=value;
			}
		}
	}
}
