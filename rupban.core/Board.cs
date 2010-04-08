using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace rupban.core
{
    public class Board
    {
        private List<Ticket> _backlogs;

        private TemplateTable _templateTable;
        

        public void Setbacklogs(List<Ticket> tickets)
        {
            _backlogs = tickets;
        }

        public void LoadTemplateTable(string filename)
        {
            _templateTable = new TemplateTable();
            //_templateTable.LoadTemplateTable();
            
            
        }

        public Ticket GetTicketById(int id)
        {
           return _backlogs.SingleOrDefault(t=>t.Number.Equals(id));
        }

        public void MoveTicket(Ticket ticket, int collumId, int rowId)
        {
            
        }
    }
}
