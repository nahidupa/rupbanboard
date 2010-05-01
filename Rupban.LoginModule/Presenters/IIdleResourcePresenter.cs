using Rupban.Core;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IIdleResourcePresenter
    {
       
        IIdleResourceView View { get; set; }
    }
}