using Microsoft.Win32;
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
            ToggleDesktopIcons(true);
        }

        private void Disable_Click(object sender, EventArgs e)
        {
            ToggleDesktopIcons(false);
        }

        private void ToggleDesktopIcons(bool enableIcons)
        {
            string computerIconPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
            string networkIconPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
            int valueData = enableIcons ? 0 : 1;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(computerIconPath, true))
            {
                if (key != null)
                {
                    key.SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}", valueData, RegistryValueKind.DWord);
                }
            }  
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(networkIconPath, true))
            {
                if (key != null)
                {
                    key.SetValue("{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}", valueData, RegistryValueKind.DWord);
                }
            }
            if (enableIcons)
            {
                MessageBox.Show("Computer and Network icons enabled.", "Icons Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Computer and Network icons disabled.", "Icons Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Interactive.RestartWindowsExplorer();
        }

    }
}
