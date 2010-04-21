using System;
using System.Collections.Generic;
using Rupban.Core;
using Rupban.Server;

namespace Rupban.LoginModule.Services
{
    public class RupbanBoardService : IRupbanBoardService
    {
        public List<TemplateCollum> GetTemplateCollumList()
        {
            var projectKeeper = new ProjectKeeper();
            return projectKeeper.GetTemplateCollumList();
        }
    }
}