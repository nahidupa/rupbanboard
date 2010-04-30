using System.Windows;
using Rupban.Core;
using Rupban.LoginModule.Presenters;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public class PeerBoxPresenter : DependencyObject, IPeerBoxPresenter
    {
        public static readonly DependencyProperty PeerboxProperty = DependencyProperty.Register(
            "Peerbox",
            typeof(PeerBox),
            typeof(PeerBoxPresenter), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public PeerBoxPresenter(IPeerBoxView view)
        {
            View = view;
            View.SetModel(this);


           
        }



        

        public PeerBox PeerBox
        {
            get { return (PeerBox)GetValue(PeerboxProperty); }
            set { SetValue(PeerboxProperty, value); }
        }

        public IPeerBoxView View
        {
            get;
            set;
        }
    }
}