﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Rupban.Core.Test
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
            var collum = templateTable.GetColumById("");
            Assert.IsNull(collum);
        }

       [Test]
        public void  AddTicketTest()
       {
           var templateTable = new TemplateTable();
           templateTable.AddCollum(ColumnType.TicketHolderColumn,"test");
           var templateCollum = templateTable.GetColumnById(0);
           //templateCollum.AddRow();
           templateTable.AddTicket(new Ticket(), 0, 0);
           var templateRow = templateCollum.GetRowByIndex(0);
           Assert.AreEqual(1,templateRow.GetAllTickets().Count);
           Assert.AreEqual(0, templateRow.GetAllPeerBox().Count);
           
       }
    }
}
