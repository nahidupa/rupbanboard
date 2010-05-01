using System;
using System.Collections.Generic;
using System.Text;
using Rupban.Core;

namespace Rupban.Server
{
    public class ProjectKeeper
    {
        private static List<Project> _projects = new List<Project>();

        public ProjectKeeper()
        {
            var resources=new List<Resource>();
            resources.Add(new Resource()
                              {
                                  Name = "Bob"
                              });
            resources.Add(new Resource()
            {
                Name = "Jhon"
            });
            resources.Add(new Resource()
            {
                Name = "Popy"
            });
            resources.Add(new Resource()
            {
                Name = "Sabana"
            });
            _projects.AddRange(new List<Project>()
                                   {
                                       new Project()
                                           {
                                               Name = "demoProject",
                                               Board = new Board()
                                                           {

                                                           },
                                               Resources = resources
                                         
                                                      
                                                      
                                      }
                              });


            _projects[0].Board.LoadTestTemplateTable();

        }
        public List<Project> GetCurrentProjectList()
        {
            return _projects;
        }

        public List<TemplateColumn> GetTemplateCollumList()
        {
            return _projects[0].Board.GetTemplateTable().GetColumnList();
        }

        public void MoveTicket(Ticket ticket, string sourceId, string targetId)
        {
            var templateTable = _projects[0].Board.GetTemplateTable();
            var currentColumn = templateTable.GetColumById(sourceId);
            if (currentColumn == null)
            {
                var peerBox = templateTable.GetPeerBoxById(sourceId);
                var ticketToMove = peerBox.GetTicketById(ticket.Id);
                if (ticketToMove != null)
                {
                    var destinationColumn = templateTable.GetColumById(targetId);
                    if (destinationColumn == null)
                    {
                        templateTable.GetPeerBoxById(targetId).AddItem(ticketToMove);
                        peerBox.RemoveTicket(ticketToMove.Id);
                    }
                    else
                    {
                        destinationColumn.GetRowByIndex(0).AddItem(ticketToMove);
                        peerBox.RemoveTicket(ticketToMove.Id);
                    }
                }
            }
            else
            {
                var ticketToMove = currentColumn.GetTicketById(ticket.Id);
                if (ticketToMove != null)
                {
                    var destinationColumn = templateTable.GetColumById(targetId);
                    if (destinationColumn == null)
                    {
                        templateTable.GetPeerBoxById(targetId).AddItem(ticketToMove);
                        currentColumn.GetRowByIndex(0).RemoveItem(ticketToMove);
                    }
                }
            }

        }

        public void ViewTicketHistory()
        {
            throw new NotImplementedException();
        }

        public List<Resource> GetIdleReourses()
        {
            return _projects[0].Resources;
        }
    }
}
