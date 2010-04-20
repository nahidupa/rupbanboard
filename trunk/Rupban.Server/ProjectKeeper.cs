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
            return _projects = new List<Project>()
                       {
                           new Project()
                               {
                                   Name = "demoProject"
                               }
                       };
        }
    }
}
