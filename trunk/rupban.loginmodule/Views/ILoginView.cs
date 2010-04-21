using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.LoginModule.Presenters;

namespace Rupban.LoginModule.Views
{
    public interface ILoginView
    {
        void SetModel(LoginPresenter model);
    }
}
