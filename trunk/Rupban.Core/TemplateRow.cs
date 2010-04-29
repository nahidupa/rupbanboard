﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;

namespace Rupban.Core
{
    [DataContract]
    public class TemplateRow
    {
        [DataMember]
        public string Id { set; get; }
        [DataMember]
        private List<TemplateCell> _templateCells;

        public TemplateRow()
        {
            _templateCells=new List<TemplateCell>();
            Id = Guid.NewGuid().ToString();
        }

        public List<Ticket> GetAllTickets()
        {
            return _templateCells.Where(t => t is Ticket).Cast<Ticket>().ToList();
        }

        public List<Peerbox> GetAllPeerBox()
        {
            return _templateCells.Where(t => t is Peerbox).Cast<Peerbox>().ToList();
        }

        public void AddItem(TemplateCell cell)
        {
            _templateCells.Add(cell);
        }

        public void RemoveItem(Ticket ticket)
        {
            _templateCells.Remove(ticket);
        }
    }
}
