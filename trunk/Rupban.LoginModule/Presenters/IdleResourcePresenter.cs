using System;
using System.Collections.Generic;
using System.Windows.Input;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class IdleResourcePresenter : IIdleResourcePresenter
    {
        private readonly IIdleResourceService _idleResourceService;


        public IdleResourcePresenter(IIdleResourceView view,IIdleResourceService idleResourceService)
        {
            _idleResourceService = idleResourceService;
            View = view;
            View.SetModel(this);
            Resources = _idleResourceService.GetIdleReourses();
           
        }

        public List<Resource> Resources
        {
            get; set;
        }

        public IIdleResourceView View
        {
            get ;
            set ; 
        }
    }
}