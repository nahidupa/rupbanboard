using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.ServiceAgent
{
    public interface IServiceCallerAgent
    {
        void MoveTicket();
        void ViewTicketHistory();
        List<Project> GetCurrentProjectList();
        List<TemplateColumn> GetTemplateCollumList();
    }
}