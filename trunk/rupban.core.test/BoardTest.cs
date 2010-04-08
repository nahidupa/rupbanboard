using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace rupban.core.test
{
    [TestFixture]
    public class BoardTest
    {
        [SetUp]
        protected void SetUp()
        {
            InitBoard();
        }

        [Test]
        public void Initboard()
        {
           
        }

        private void InitBoard()
        {
            var board = new Board();
            var tickets = new List<Ticket>()
                              {
                                  new Ticket()
                                      {
                                          Number = 1,
                                          Title = "Ticket 1"

                                      },
                                  new Ticket()
                                      {
                                          Number = 2,
                                          Title = "Ticket 2"
                                        
                                      }
                              };
            board.Setbacklogs(tickets);
        }
    }
}
