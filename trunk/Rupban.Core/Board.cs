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

        public Ticket GetTicketById(string id)
        {
            return _backlogs.SingleOrDefault(t => t.Id.Equals(id));
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
            //for (int i = 0; i < 8;i++ )
            {
                CreateColumn(string.Format("Todo", 1), ColumnType.TicketHolderColumn);
            }

            CreateColumn(string.Format("In devolop", 1), ColumnType.PeerBoxHolderColumn);
            CreateColumn(string.Format("To verity", 1), ColumnType.TicketHolderColumn);
            CreateColumn(string.Format("In QA", 1), ColumnType.PeerBoxHolderColumn);
            CreateColumn(string.Format("Failed", 1), ColumnType.TicketHolderColumn);
            CreateColumn(string.Format("Passed", 1), ColumnType.TicketHolderColumn);


        }

        private void CreateColumn(string collumName, ColumnType columnType)
        {
           var templateColumn= _templateTable.AddCollum(columnType, collumName);
           AddRow(collumName, templateColumn.Id);
        }

        private void AddRow(string collumName, string columnId)
        {
          
            var title = "tiket1";
            if (collumName.Equals("Todo"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddTicket(columnId, string.Format("title{0}", i), i);
                }
            }

            if (collumName.Equals("In devolop"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddPeerBox(columnId);
                }
            }
            if (collumName.Equals("In QA"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddPeerBox(columnId);
                }
            }

        }

        private void AddPeerBox(string columnId)
        {
            _templateTable.GetColumById(columnId).GetRowByIndex(0).AddItem(_templateTable.CreatePeerBox());


        }

        private void AddTicket(string columnId, string title, int number)
        {
            _templateTable.GetColumById(columnId).GetRowByIndex(0).AddItem(new Ticket() { Title = title, Number = number });
        }
    }
}
