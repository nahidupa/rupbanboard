using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Events;
using Rupban.Core;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure.Event;

namespace Rupban.LoginModule.Data
{
    public static class BoardData
    {
        private static  Dictionary<string, IPanelColumnPresenter> _boardData = new Dictionary<string, IPanelColumnPresenter>();

     
        public static void AddVisulColumn(string id, IPanelColumnPresenter panelColumnPresenter)
        {
            _boardData.Add(id, panelColumnPresenter);
        }

        

        public static TemplateColumn GetTemplateColumnByTicketId(string ticketId)
        {
            foreach (var panelColumnPresenter in _boardData.Values)
            {
                if (panelColumnPresenter.TemplateColumn.HasTicket(ticketId))
                    return panelColumnPresenter.TemplateColumn;
            }
            return null;
        }

        public static TemplateColumn GetTemplateColumnById(string targetColumnId)
        {
            
           if(_boardData.ContainsKey(targetColumnId))
               return _boardData[targetColumnId].TemplateColumn;
            return null;
        }

        public static void SyncData(TickedMoveEventArgs tickedMoveEventArgs)
        {
             _boardData[tickedMoveEventArgs.SourceColumnId].TemplateColumn.RemoveRow(tickedMoveEventArgs.Ticket.Id);

            var newRow= _boardData[tickedMoveEventArgs.TargetColumnId].TemplateColumn.AddRow();
            newRow.AddItem(tickedMoveEventArgs.Ticket);


            
        }
    }
}
