using System.Collections.Generic;
using Rupban.Core;
using Rupban.LoginModule.Presenters;

namespace Rupban.LoginModule.Controller
{
    public interface IRupbanBoardController
    {
        void LoadBoardColumnView(List<TemplateColumn> templateCollums);
        
        void LoadRowView(TemplateColumn templateColumn);
        string GetSourceTemplateTicketId(string ticketId);
        void AddTemplateCelHolderPresenter(string id, IPeerBoxPresenter templateCelHolderPresenter);
    }
}