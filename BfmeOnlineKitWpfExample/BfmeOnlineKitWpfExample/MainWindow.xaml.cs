using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            online_menu.Load(game: BFMECompetetiveArena_OnlineKit.Data.BfmeGame.BFME1);
        }

        private void UnloadClicked(object sender, RoutedEventArgs e)
        {
            online_menu.Unload();
        }
    }
}
