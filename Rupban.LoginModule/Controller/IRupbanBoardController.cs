using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.LoginModule.Controller
{
    public interface IRupbanBoardController
    {
        void LoadBoardColumnView(List<TemplateColumn> templateCollums);
        
        void LoadRowView(TemplateColumn templateColumn);
    }
}