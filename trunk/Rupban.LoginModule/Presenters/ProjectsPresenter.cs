using System;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
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

        public ICommand ViewRupbanBoardCommand { set; get; }

        public ProjectsPresenter(IProjectsView view,IProjectsController projectsController,IProjectService projectService)
        {
            _projectsController = projectsController;
            _projectService = projectService;
            View = view;
            View.SetModel(this);

            ProjectList = _projectService.GetCurrentProjectList();
            ViewRupbanBoardCommand = new DelegateCommand<object>(ViewRupbanBoard);
        }

        private void ViewRupbanBoard(object obj)
        {
            _projectsController.ViewRupbanBoard();
        }

        public IProjectsView View
        {
            get ;
            set ; 
        }
    }
}