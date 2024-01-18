using System.Diagnostics;

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
    }
}
