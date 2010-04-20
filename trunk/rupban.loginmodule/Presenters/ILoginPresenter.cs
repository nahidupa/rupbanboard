using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface ILoginPresenter
    {
        ILoginView View { get; set; }
    }
}