using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Linq;
namespace Rupban.Core
{
    [DataContract]
    [KnownType(typeof(TemplateRow))]
    [KnownType(typeof(TemplateCell))]
    [KnownType(typeof(Ticket))]
    public class TemplateColumn
    {
        [DataMember]
        public string Id { set; get; }
        [DataMember]
        public string ColumnHeader { set; get; }
        [DataMember]
        private List<TemplateRow> _templateRows;


        public TemplateColumn()
        {
            _templateRows = new List<TemplateRow>();
            Id = Guid.NewGuid().ToString();


        }
        public List<TemplateRow> SetRows(List<TemplateRow> templateRows)
        {
            _templateRows = templateRows;
            return _templateRows;
        }

        public TemplateRow AddRow()
        {
            var templateRow = new TemplateRow();
            _templateRows.Add(templateRow);
            return templateRow;
        }

        public List<TemplateRow> GetRows()
        {
           return _templateRows;
        }
        public TemplateRow GetRowByIndex(int index)
        {
            return _templateRows[index];
        }

        public Ticket GetTicketById(string ticketId)
        {
            foreach (var templateRow in _templateRows)
            {
                return templateRow.GetAllTickets().SingleOrDefault(t => t.Id.Equals(ticketId));
            }
            return null;
        }

        public bool HasTicket(string ticketId)
        {
            foreach (var templateRow in _templateRows)
            {
                var ticket=templateRow.GetAllTickets().SingleOrDefault(t => t.Id.Equals(ticketId));
                if (ticket != null) return true;
            }
            return false;
        }

        public void RemoveRow(string ticketId)
        {

            //error
           //var objectToRemove= _templateRows.SingleOrDefault(u => u.Id.Equals(ticketId));
           // _templateRows.Remove(objectToRemove);
            throw new NotImplementedException();
        }
    }
}
