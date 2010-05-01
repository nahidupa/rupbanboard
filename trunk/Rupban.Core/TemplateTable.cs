using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Rupban.Core
{
    [DataContract]
    public class TemplateTable
    {
        private Dictionary<string, TemplateColumn> _templateCollums;
        private Dictionary<string, PeerBox> _peerBoxs;




        public TemplateTable()
        {
            _templateCollums = new Dictionary<string, TemplateColumn>();
            _peerBoxs = new Dictionary<string, PeerBox>();

        }

        public TemplateColumn GetColumById(string columnId)
        {
            if (_templateCollums.ContainsKey(columnId))
                return _templateCollums[columnId];
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
                var collumList = document.Descendants("Collums").Select(collum => new TemplateColumn
                                                                                      {
                                                                                          Id =
                                                                                              (
                                                                                              collum.Element("Id").Value),
                                                                                          ColumnHeader =
                                                                                              collum.Element("ColumnHeder").
                                                                                              Value,
                                                                                          //TemplateRows = (collum.
                                                                                          //    Descendants("Rows").
                                                                                          //    Select(
                                                                                          //    row => new TemplateRow()
                                                                                          //               {
                                                                                          //                   Id =
                                                                                          //                       int.
                                                                                          //                       Parse
                                                                                          //                       (row.
                                                                                          //                            Element
                                                                                          //                            ("Id")
                                                                                          //                            .
                                                                                          //                            Value)
                                                                                          //               }).ToList())


                                                                                      }.SetRows
                                                                                      (
                                                                                      (collum.Descendants("Rows").
                                                                                              Select(
                                                                                              row => new TemplateRow()
                                                                                                         {
                                                                                                             Id = row.Element("Id").Value.ToString()
                                                                                                         }).ToList())
                                                                                      ));

            }
            throw new FileNotFoundException("File not found");
        }

        public void AddTicket(Ticket ticket, int collumId, int rowId)
        {
            GetColumnById(collumId).GetRowByIndex(rowId).AddItem(ticket);
        }

        public TemplateColumn GetColumnById(int collumId)
        {
            return _templateCollums.SingleOrDefault(c => c.Value.Id.Equals(collumId)).Value;
        }

        public TemplateColumn AddCollum(ColumnType columnType, string columnHeader)
        {
            var templateColumn = new TemplateColumn() { ColumnHeader = columnHeader, ColumnType = columnType };
            _templateCollums.Add(templateColumn.Id, templateColumn);
            return templateColumn;

        }

        public List<TemplateColumn> GetColumnList()
        {
            return _templateCollums.Select(p => p.Value).ToList();
        }


        public PeerBox GetPeerBoxById(string Id)
        {
            if (_peerBoxs.ContainsKey(Id))
            {
                return _peerBoxs[Id];
            }
            return null;
        }

        public TemplateCell CreatePeerBox()
        {
            var peerBox=new PeerBox();
            _peerBoxs.Add(peerBox.Id,peerBox);
            return peerBox;
        }
    }
}
