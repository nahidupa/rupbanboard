using Rupban.Core;

namespace Rupban.UI.Infrastructure.Event
{
    public class TickedMoveEventArgs
    {
        
        public Ticket Ticket { set; get; }
        public string SourceColumnId
        {
            set;
            get;
        }
        public string TargetColumnId
        {
            set;
            get;
        }
    }
}