using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Rupban.Core.Test
{
    [TestFixture]
    public class BoardTest
    {
        Board board = new Board();
        [SetUp]
        protected void SetUp()
        {
            InitBoard();
        }

        [Test]
        public void Initboard()
        {
            string filename="";
            var mockTemplateTable = new Mock<TemplateTable>();
            //mockTemplateTable.Setup(u=>u.)
            board.LoadTemplateTable(filename);
            var ticket=board.GetTicketByNumber(1);
            board.MoveTicket(ticket,2, 1);
            var templateTable = board.GetTemplateTable();
            var templateCollum = templateTable.GetCollumByName("HotBox");
            
        }

        private void InitBoard()
        {
            
            var tickets = new List<Ticket>()
                              {
                                  new Ticket()
                                      {
                                          Number = 1,
                                          Title = "Ticket 1",
                                          Priority=TicketPriority.Low


                                      },
                                  new Ticket()
                                      {
                                          Number = 2,
                                          Title = "Ticket 2",
                                           Priority=TicketPriority.Hight
                                        
                                      }
                              };
            board.Setbacklogs(tickets);
        }
    }
}
