using System;
using System.Windows.Forms;

namespace GITC
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            Interactive.ToggleDesktopIcons(true);
        }

        private void Disable_Click(object sender, EventArgs e)
        {
            Interactive.ToggleDesktopIcons(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interactive.InstallDX();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
