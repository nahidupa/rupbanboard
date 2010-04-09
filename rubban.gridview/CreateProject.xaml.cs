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
using rupban.agent;

namespace rubban.gridview
{
    /// <summary>
    /// Interaction logic for CreateProject.xaml
    /// </summary>
    public partial class CreateProject : Page
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TrackAgent trackAgent = new TrackAgent();
            trackAgent.ImportTicket();

            NavigationService.Navigate(new Uri("BackLogs.xaml", UriKind.Relative));
        }
    }
}
