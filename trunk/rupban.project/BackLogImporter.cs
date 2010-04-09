using System;
using System.Collections.Generic;
using rupban.core;

namespace rupban.project
{
    public class BackLogImporter
    {
        public List<Ticket> ImportTicket()
        {
            return new List<Ticket>()
                       {
                           new Ticket()
                               {
                                   Number = 1,
                                   Title = "Ticket 1",
                                   Priority = TicketPriority.Low


                               },
                           new Ticket()
                               {
                                   Number = 2,
                                   Title = "Ticket 2",
                                   Priority = TicketPriority.Hight

                               }
                       };
        }
    }
}
    
