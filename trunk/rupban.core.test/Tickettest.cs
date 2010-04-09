using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace rupban.core.test
{
    [TestFixture]
    public class Tickettest
    {
        [Test]
        public void BasicStateTest()
        {
            var ticket=new Ticket();
            Assert.AreEqual(TicketStatus.InBackBlog, ticket.Status);
            Assert.AreEqual(TicketPriority.Low, ticket.Priority);
            Assert.AreEqual("", ticket.Title);
            
        }
    }
}
