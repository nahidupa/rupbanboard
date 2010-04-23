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
    /// Interaction logic for PanelColumnView.xaml
    /// </summary>
    public partial class PanelColumnView : UserControl, IPanelColumnView
    {
        private PanelColumnPresenter _model;

        public PanelColumnView()
        {
            InitializeComponent();
        }

        public void SetModel(PanelColumnPresenter model)
        {
            _model = model;
            this.DataContext = model;
        }
    }
}
