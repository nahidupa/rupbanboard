using System.Collections.Generic;
using Microsoft.Practices.Composite.Regions;
using Rupban.Core;

namespace Rupban.LoginModule.Controller
{
    public interface IInDevColumnController
    {
        void LoadBoardPeerBoxView(TemplateRow row, IRegionManager localRegionManager);
        Dictionary<string, IRegionManager> GetPeerboxRegionManagers();
    }
}