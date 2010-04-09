using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace rupban.core.test
{
    [TestFixture]
    public class TemplateTableTest
    {
        [Test]
        public void BasicStateTest()
        {
            var templateTable=new TemplateTable();
            Assert.AreEqual(0, templateTable.GetCollumCount());
            
        }
        [Test]
        public void GetCollumByNameTest()
        {
            var templateTable = new TemplateTable();
            var collum = templateTable.GetCollumByName("");
            Assert.IsNull(collum);
        }

       [Test]
        public void  AddTicketTest()
       {
           var templateTable = new TemplateTable();
           templateTable.AddTicket(new Ticket(), 0,0);
           var templateCollum = templateTable.GetCollumById(0);
           //templateCollum.TemplateRows[0].TemplateCells[0];
       }
    }
}
