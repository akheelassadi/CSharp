using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpProject
{
    public class CheckProcessStatus
    {
        public static bool IsProcessRunning(string processName)
        {
            Process[] proc = Process.GetProcessesByName(processName);

            if (proc.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void RestartProcess(string processName, string processPath)
        {
            Process[] proc = Process.GetProcessesByName(processName);
            for (int i = 0; i < proc.Length; i++)
            {
                proc[i].Kill();
                proc[i].WaitForExit();
            }

                       
        }
    }
}
