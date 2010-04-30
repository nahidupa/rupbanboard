using Rupban.Core;

namespace Rupban.UI.Infrastructure.Event
{
    public class TickedMoveEventArgs
    {

        public Ticket Ticket { set; get; }

        public string SourceId
        {
            set;
            get;
        }
        public string TargetId
        {
            set;
            get;
        }
    }
}