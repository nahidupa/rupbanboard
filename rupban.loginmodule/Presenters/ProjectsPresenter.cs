using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class ProjectsPresenter : IProjectsPresenter
    {
        private IProjectsController _projectsController;

        public ProjectsPresenter(IProjectsView view,IProjectsController projectsController)
        {
            _projectsController = projectsController;
            View = view;
            View.SetModel(this);
        }

        public IProjectsView View
        {
            get ;
            set ; 
        }
    }
}