using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

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

        public void LoadTemplateTable(string filename)
        {
            if (File.Exists(filename))
            {
                XDocument document = XDocument.Load(filename);
                var collumList = document.Descendants("Collums").Select(collum => new TemplateCollum
                                                                                      {
                                                                                          ID =
                                                                                              int.Parse(
                                                                                              collum.Element("ID").Value),
                                                                                          Title =
                                                                                              collum.Element("Title").
                                                                                              Value,
                                                                                          TemplateRows = (collum.
                                                                                              Descendants("Rows").
                                                                                              Select(
                                                                                              row => new TemplateRow()
                                                                                                         {
                                                                                                             ID =
                                                                                                                 int.
                                                                                                                 Parse
                                                                                                                 (row.
                                                                                                                      Element
                                                                                                                      ("ID")
                                                                                                                      .
                                                                                                                      Value)
                                                                                                         }).ToList())


                                                                                      });

            }
            throw new FileNotFoundException("File not found");
        }

        public void AddTicket(Ticket ticket, int collumId, int rowId)
        {
            
        }

        public TemplateCollum GetCollumById(int collumId)
        {
            return _templateCollums.SingleOrDefault(c => c.Value.ID.Equals(collumId)).Value;
        }
    }
}
