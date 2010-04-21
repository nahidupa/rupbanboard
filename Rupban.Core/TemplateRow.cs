using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rupban.Core
{
    public class TemplateRow
    {
        public int Id { set; get; }
        private List<TemplateCell> _templateCells;

        public TemplateRow()
        {
            _templateCells=new List<TemplateCell>();
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
    }
}
