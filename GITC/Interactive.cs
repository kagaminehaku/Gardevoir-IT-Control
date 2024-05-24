using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System;
using Microsoft.Win32;

namespace GITC
{
    internal class Interactive
    {
        public static void RestartWindowsExplorer()
        {
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");

            foreach (Process process in explorerProcesses)
            {
                process.Kill();
            }
        }

        public static void ToggleDesktopIcons(bool enableIcons)
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

            RestartWindowsExplorer();
        }
        public static void InstallSW()
        {
            Type programToInstallType = typeof(GITC.DX);

            PropertyInfo[] properties = programToInstallType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic);

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(byte[]))
                {
                    byte[] dxBytes = (byte[])property.GetValue(null);

                    string resourceName = property.Name;

                    string filePath = Path.Combine(Path.GetTempPath(), $"{resourceName}.exe");

                    File.WriteAllBytes(filePath, dxBytes);
                }
            }
            Process process = new Process();
            string filePathExec = Path.Combine(Path.GetTempPath(), $"dxwebsetup.exe");
            process.StartInfo.FileName = filePathExec;
            process.Start();
            process.WaitForExit();

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(byte[]))
                {
                    byte[] dxBytes = (byte[])property.GetValue(null);

                    string resourceName = property.Name;


                    string filePath = Path.Combine(Path.GetTempPath(), $"{resourceName}.exe");

                    File.Delete(filePath);
                }
            }
        }
        public static void InstallVS() 
        {
            Type programToInstallType = typeof(GITC.VS);

            PropertyInfo[] properties = programToInstallType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic);

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(byte[]))
                {
                    byte[] vcredistBytes = (byte[])property.GetValue(null);

                    string resourceName = property.Name;

                    if (resourceName == "install_all")
                    {
                        string filePathi = Path.Combine(Path.GetTempPath(), $"{resourceName}.bat"); 

                        File.WriteAllBytes(filePathi, vcredistBytes);

                        continue;
                    }

                    string filePath = Path.Combine(Path.GetTempPath(), $"{resourceName}.exe"); 

                    File.WriteAllBytes(filePath, vcredistBytes);
                }
            }
            Process process = new Process();
            string filePathExec = Path.Combine(Path.GetTempPath(), $"install_all.bat");
            process.StartInfo.FileName = filePathExec;
            process.Start();
            process.WaitForExit();

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(byte[]))
                {
                    byte[] vcredistBytes = (byte[])property.GetValue(null);

                    string resourceName = property.Name;

                    if (resourceName == "install_all")
                    {
                        string filePathi = Path.Combine(Path.GetTempPath(), $"{resourceName}.bat");

                        File.Delete(filePathi);

                        continue;
                    }

                    string filePath = Path.Combine(Path.GetTempPath(), $"{resourceName}.exe");

                    File.Delete(filePath);
                }
            }
        }
    }
}
