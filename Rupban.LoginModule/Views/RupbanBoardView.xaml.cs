using System;
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

namespace Rupban.LoginModule.Views
{
    /// <summary>
    /// Interaction logic for RupbanBoardView.xaml
    /// </summary>
    public partial class RupbanBoardView : UserControl, IRupbanBoardView
    {
        public RupbanBoardView()
        {
            InitializeComponent();
        }

        public void SetModel(RupbanBoardPresenter model)
        {
            DataContext = model;
        }
    }
}
