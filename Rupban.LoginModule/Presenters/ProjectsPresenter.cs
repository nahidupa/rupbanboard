using System.Collections.Generic;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class ProjectsPresenter : IProjectsPresenter
    {
        private IProjectsController _projectsController;
        private readonly IProjectService _projectService;

        public List<Project> ProjectList { set; get; }

        public ProjectsPresenter(IProjectsView view,IProjectsController projectsController,IProjectService projectService)
        {
            _projectsController = projectsController;
            _projectService = projectService;
            View = view;
            View.SetModel(this);

            ProjectList = _projectService.GetCurrentProjectList();
        }

        public IProjectsView View
        {
            get ;
            set ; 
        }
    }
}