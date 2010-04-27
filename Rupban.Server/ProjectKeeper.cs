using System;
using System.Collections.Generic;
using System.Text;
using Rupban.Core;

namespace Rupban.Server
{
    public class ProjectKeeper
    {
        private List<Project> _projects;
        public List<Project> GetCurrentProjectList()
        {
            return  new List<Project>()
                       {
                           new Project()
                               {
                                   Name = "demoProject",
                                   Board = new Board()
                                               {
                                                   
                                               }
                               }
                       };
        }

        public List<TemplateColumn> GetTemplateCollumList()
        {
           _projects= new List<Project>()
                       {
                           new Project()
                               {
                                   Name = "demoProject",
                                   Board = new Board()
                                               {
                                                   
                                               }
                               }
                       };
            
            _projects[0].Board.LoadTestTemplateTable();

           return _projects[0].Board.GetTemplateTable().GetColumnList();
        }

        public void MoveTicket(string ticketId, string currentColumnName, string destinationColumnName)
        {
            
            var currentColumn = _projects[0].Board.GetTemplateTable().GetCollumByName(currentColumnName);
            var ticketToMove = currentColumn.GetTicketById(ticketId);
            if (ticketToMove != null)
            {
                var destinationColumn = _projects[0].Board.GetTemplateTable().GetCollumByName(destinationColumnName);
                destinationColumn.GetRowByIndex(0).AddItem(ticketToMove);
                currentColumn.GetRowByIndex(0).RemoveItem(ticketToMove);
            }

        }

        public void ViewTicketHistory()
        {
            throw new NotImplementedException();
        }
    }
}
