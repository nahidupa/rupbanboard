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
using rupban.loginmodule.Views;

namespace Rupban.LoginModule.Views
{
    /// <summary>
    /// Interaction logic for PeerBoxView.xaml
    /// </summary>
    public partial class PeerBoxView : UserControl, IPeerBoxView
    {
        public PeerBoxView()
        {
            InitializeComponent();
        }

        public void SetModel(IPeerBoxPresenter model)
        {
            this.DataContext = model;
        }
    }
}
