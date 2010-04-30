﻿using System;
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

            CreateColumn(string.Format("In devolop", 1),ColumnType.PeerBoxHolderColumn);

        }

        private void CreateColumn(string collumName, ColumnType columnType)
        {
            _templateTable.AddCollum(collumName,columnType);
            AddRow(collumName);
        }

        private void AddRow(string collumName)
        {
            _templateTable.GetCollumByName(collumName).AddRow();
            var title = "tiket1";
            if (collumName.Equals("Todo"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddTicket(collumName, string.Format("title{0}", i),i);
                }
            }

            if (collumName.Equals("In devolop"))
            {
                for (int i = 0; i < 4; i++)
                {
                    AddPeerBox(collumName);
                }
            }

        }

        private void AddPeerBox(string collumName)
        {
            _templateTable.GetCollumByName(collumName).GetRowByIndex(0).AddItem(new PeerBox() {  });
   
        }

        private void AddTicket(string collumName, string title,int number)
        {
            _templateTable.GetCollumByName(collumName).GetRowByIndex(0).AddItem(new Ticket() { Title = title, Number = number});
        }
    }
}
