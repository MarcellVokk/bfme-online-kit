using System.Diagnostics;
using System.Windows.Forms.Integration;

namespace launcherBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await onlineMenu.Load();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await onlineMenu.Unload();
        }
    }
}