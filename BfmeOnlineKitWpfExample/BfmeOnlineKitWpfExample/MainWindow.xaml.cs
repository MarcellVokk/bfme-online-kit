using System.Windows;

namespace BfmeOnlineKitWpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadClicked(object sender, RoutedEventArgs e)
        {
            online_menu.Load(game: BfmeFoundationProject.OnlineKit.Data.BfmeGame.BFME1);
        }

        private void UnloadClicked(object sender, RoutedEventArgs e)
        {
            online_menu.Unload();
        }
    }
}
