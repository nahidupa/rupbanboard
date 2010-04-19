using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public interface ILoginPresenter
    {
        ILoginView View { get; set; }
    }
}