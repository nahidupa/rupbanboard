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

        public List<TemplateCollum> GetTemplateCollumList()
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
    }
}
