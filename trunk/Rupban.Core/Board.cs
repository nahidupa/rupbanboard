using System;
using System.Collections.Generic;
using System.Linq;

namespace Rupban.Core
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
            _templateTable.LoadTemplateTable(filename);
            
            
        }
        
        public Ticket GetTicketById(int id)
        {
           return _backlogs.SingleOrDefault(t=>t.Number.Equals(id));
        }

        public void MoveTicket(Ticket ticket, int collumId, int rowId)
        {
            _templateTable.AddTicket(ticket,collumId, rowId);
        }

        public TemplateTable GetTemplateTable()
        {
            return _templateTable;
        }

        public void LoadTestTemplateTable()
        {
            _templateTable = new TemplateTable();
            _templateTable.AddCollum("DemoCollum");
            _templateTable.AddCollum("DemoCollum1");
            
        }
    }
}
