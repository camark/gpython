using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Product.Util;

namespace Product.test
{
    
    [TestFixture]
    public class testMailDrawing
    {
        private MailDrawing m_MailDraw;

        [SetUp]
        public void Init()
        {
            m_MailDraw = new MailDrawing(MailDrawing.AddEmailAtta("gongming"));
        }

        [Test]
        public void testSendMail()
        {
            m_MailDraw.Drawing.Add(@"c:\a1.txt");

            m_MailDraw.SendMail();
        }
    }


   
}
