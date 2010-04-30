using Microsoft.Practices.Composite.Regions;

namespace Rupban.LoginModule.Presenters
{
    public interface IInDevColumnPresenter :IColumnPresenter
    {
        void LoadPeerView(IRegionManager regionManager);
    }
}