using System.Diagnostics;
using System.Windows.Forms.Integration;

namespace BfmeOnlineKitFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadClicked(object sender, EventArgs e)
        {
            await onlineMenu.Load(game: BFMECompetetiveArena_OnlineKit.Data.BfmeGame.BFME1);
        }

        private async void UnloadClicked(object sender, EventArgs e)
        {
            await onlineMenu.Unload();
        }
    }
}