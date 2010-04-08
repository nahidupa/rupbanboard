using System.Collections.Generic;
using NUnit.Framework;

namespace rupban.core.test
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
            board.LoadTemplateTable(filename);
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
