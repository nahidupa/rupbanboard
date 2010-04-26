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
            return _backlogs.SingleOrDefault(t => t.Number.Equals(id));
        }

        public void MoveTicket(Ticket ticket, int collumId, int rowId)
        {
            _templateTable.AddTicket(ticket, collumId, rowId);
        }

        public TemplateTable GetTemplateTable()
        {
            return _templateTable;
        }

        public void LoadTestTemplateTable()
        {
            _templateTable = new TemplateTable();
            for (int i = 0; i < 8;i++ )
            {
                CreateColumn(string.Format("DemoColumn{0}",i));
            }

        }

        private void CreateColumn(string collumName)
        {
            _templateTable.AddCollum(collumName);
            AddRow(collumName);
        }

        private void AddRow(string collumName)
        {
            _templateTable.GetCollumByName(collumName).AddRow();
            var title = "tiket1";
            if (collumName.Equals("DemoColumn1"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddTicket(collumName, string.Format("title{0}", i));
                }
            }

        }

        private void AddTicket(string collumName, string title)
        {
            _templateTable.GetCollumByName(collumName).GetRowByIndex(0).AddItem(new Ticket() { Title = title });
        }
    }
}
