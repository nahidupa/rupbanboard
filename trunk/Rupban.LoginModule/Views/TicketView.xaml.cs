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
using Rupban.Core;
using rupban.loginmodule.Presenters;

namespace rupban.loginmodule.Views
{
    /// <summary>
    /// Interaction logic for TicketView.xaml
    /// </summary>
    public partial class TicketView : UserControl, ITicketView
    {
        private ITicketPresenter _model;

        public TicketView()
        {
            InitializeComponent();
            ticketGrid.PreviewMouseLeftButtonDown+=new MouseButtonEventHandler(TicketGridPreviewMouseLeftButtonDown);
        }

        void TicketGridPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            const DragDropEffects allowedEffects = DragDropEffects.Move;
            if (DragDrop.DoDragDrop(this,this, allowedEffects) != DragDropEffects.None)
            {
                // The item was dropped into a new location,
                // so make it the new selected item.
                //this.ListView1.SelectedItem = selectedItem;
            }
        }

        public void SetModel(ITicketPresenter model)
        {
            _model = model;
            DataContext = model;
        }

        public Ticket GetTicket()
        {
            return _model.Ticket;
        }
    }
}
