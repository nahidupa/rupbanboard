using System;
using System.Collections.Generic;
using System.Text;

namespace rupban.core
{
    public class TemplateTable
    {
        private Dictionary<string,TemplateCollum> _templateCollums;

        public TemplateTable(Dictionary<string, TemplateCollum> templateCollums)
        {
            _templateCollums = templateCollums;
        }
        public TemplateTable()
        {
            _templateCollums = new Dictionary<string, TemplateCollum>();
        }

        public TemplateCollum GetCollumByName(string collumName)
        {
            if (_templateCollums.ContainsKey(collumName))
           return _templateCollums[collumName];
            return null;
        }

        public int GetCollumCount()
        {
            return _templateCollums.Count;
        }
    }
}
