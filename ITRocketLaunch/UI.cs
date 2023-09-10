using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRocketLaunch
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
            // The Registry key paths for the icons
            string computerIconPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
            string computerIconPath2 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu";
            string networkIconPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu";
            string networkIconPath2 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel";
            // Set the value data to 0 to enable or 1 to disable
            int valueData = enableIcons ? 0 : 1;

            // Modify the Registry for Computer icon
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(computerIconPath, true))
            {
                if (key != null)
                {
                    key.SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}", valueData, RegistryValueKind.DWord);
                }
            }

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(computerIconPath2, true))
            {
                if (key != null)
                {
                    key.SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}", valueData, RegistryValueKind.DWord);
                }
            }

            // Modify the Registry for Network icon
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(networkIconPath, true))
            {
                if (key != null)
                {
                    key.SetValue("{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}", valueData, RegistryValueKind.DWord);
                }
            }

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(networkIconPath2, true))
            {
                if (key != null)
                {
                    key.SetValue("{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}", valueData, RegistryValueKind.DWord);
                }
            }

            // Inform the user about the changes
            if (enableIcons)
            {
                MessageBox.Show("Computer and Network icons enabled.", "Icons Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Computer and Network icons disabled.", "Icons Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RestartWindowsExplorer();
        }

        static void RestartWindowsExplorer()
        {
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");

            foreach (Process process in explorerProcesses)
            {
                process.Kill();
            }
        }
    }
}
