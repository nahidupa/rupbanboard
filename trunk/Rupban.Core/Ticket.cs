using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Rupban.Core
{
    [DataContract]
    public class Ticket : TemplateCell
    {
        private string _title="";
        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Number{ get; set; }
        [DataMember]
        public TicketPriority Priority { get; set; }
        [DataMember]
        public TicketStatus Status { get; set; }

    }
}
