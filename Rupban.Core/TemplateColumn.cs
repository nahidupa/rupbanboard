using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Rupban.Core
{
    [DataContract]
    [KnownType(typeof(TemplateRow))]
    [KnownType(typeof(TemplateCell))]
    [KnownType(typeof(Ticket))]
    public class TemplateColumn
    {
        [DataMember]
        public int ID { set; get; }
        [DataMember]
        public string Title { set; get; }
        [DataMember]
        private List<TemplateRow> _templateRows;


        public TemplateColumn()
        {
            _templateRows = new List<TemplateRow>();


        }
        public List<TemplateRow> SetRows(List<TemplateRow> templateRows)
        {
            _templateRows = templateRows;
            return _templateRows;
        }

        public void AddRow()
        {
            _templateRows.Add(new TemplateRow());
        }
        public List<TemplateRow> GetRows()
        {
           return _templateRows;
        }
        public TemplateRow GetRowByIndex(int index)
        {
            return _templateRows[index];
        }
    }
}
