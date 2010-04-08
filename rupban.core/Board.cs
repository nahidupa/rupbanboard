using System;
using System.Collections.Generic;
using System.Text;

namespace rupban.core
{
    public class Board
    {
        private List<Ticket> _backlogs;
        
        public TemplateTable TemplateTable
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Setbacklogs(List<Ticket> tickets)
        {
            _backlogs = tickets;
        }
    }
}
