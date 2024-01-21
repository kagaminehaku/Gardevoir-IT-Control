using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
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
            Interactive.InstallVS();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
