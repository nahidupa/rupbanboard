using System;
using System.Collections.Generic;
using System.Text;

namespace Rupban.Core
{
    public class TemplateColumn
    {
        public int ID { set; get; }
        public string Title { set; get; }
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
