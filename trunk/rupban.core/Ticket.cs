using System;
using System.Collections.Generic;
using System.Text;

namespace rupban.core
{
    public class Ticket : TemplateCell
    {
        private string _title="";
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Number{ get; set; }

        public TicketPriority Priority { get; set; }

        public TicketStatus Status { get; set; }

    }
}
