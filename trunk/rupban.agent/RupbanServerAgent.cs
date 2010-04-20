using System.Collections.Generic;
using Rupban.Core;
using Rupban.Server;


namespace Rupban.Agent
{
    public class RupbanServerAgent
    {
        public List<Project> GetCurrentProjectList()
        {
            var projectKeeper=new ProjectKeeper();
            return projectKeeper.GetCurrentProjectList();
        }
    }
}
