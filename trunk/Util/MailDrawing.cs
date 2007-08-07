using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections;
using System.Net.Mail;

namespace Product.Util
{
    class MailDrawing
    {
        public MailDrawing(string From, string To, string Subject, string Body, IList attaches)
        {
            m_Form = From;
            m_To = To;
            m_Subject = Subject;
            m_Body = Body;
            attaches = new ArrayList();
        }

        public MailDrawing(string To)
        {
            m_Form = AddEmailAtta("gongming");
            m_To = To;
            m_Subject = "图纸借阅-" + DateTime.Now.ToString();
            m_Body = "有事情联系(3919671)";
            m_attaches = new ArrayList();
        }

        public MailDrawing()
        {
            m_Form = AddEmailAtta("gongming");
            m_To = AddEmailAtta("wangyuhui");
            m_Subject = "图纸借阅-" + DateTime.Now.ToString();
            m_Body = "有事情联系(3919671)";
            m_attaches = new ArrayList();
        }

        public static string AddEmailAtta(string user){
            StringBuilder sb = new StringBuilder();
            sb.Append(user);
            sb.Append("@ebara-boshanpump.com");


            return sb.ToString();
        }

        private string m_Form, m_To, m_Subject, m_Body;
        private IList m_attaches;

        public IList Drawing
        {
            get
            {
                return m_attaches;
            }
            set
            {
                m_attaches = value;
            }
        }

        public void SendMail()
        {
            MailAddress from = new MailAddress(m_Form);
            MailAddress to = new MailAddress(m_To);

            MailMessage msg= new MailMessage(from, to);
            msg.Subject = m_Subject;
            msg.Body = m_Body;

            if (m_attaches.Count > 0)
            {
                foreach(string s in m_attaches){
                    Attachment atta = new Attachment(s);
                    msg.Attachments.Add(atta);
                }
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.ebara-boshanpump.com";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("gongming@ebara-boshanpump.com", "pleasure");
            smtp.Send(msg);
        }
    }
}
