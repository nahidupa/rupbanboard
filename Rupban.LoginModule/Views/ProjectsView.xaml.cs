﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Views;

namespace rupban.loginmodule.Views
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : UserControl, IProjectsView
    {
        public ProjectsView()
        {
            InitializeComponent();
        }

        public void SetModel(ProjectsPresenter model)
        {
            DataContext = model;
        }
    }
}
