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
        public void GetCollumByName()
        {
            var templateTable = new TemplateTable();
            var collum = templateTable.GetCollumByName("");
            Assert.IsNull(collum);
        }
    }
}
