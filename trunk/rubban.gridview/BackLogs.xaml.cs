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

namespace rubban.gridview
{
    /// <summary>
    /// Interaction logic for BackLogs.xaml
    /// </summary>
    public partial class BackLogs : Page
    {
        public BackLogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RupbanBoard.xaml", UriKind.Relative));
        }
    }
}
