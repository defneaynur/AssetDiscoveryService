using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebAppAssetDiscovery.App_Start.Data
{
    public class GetData
    {
        public String GetAssetInfo(string nmapCmdInput)
        {
            string outputNmap = "";
            var proc = new Process();
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                psi.RedirectStandardInput = true;
                proc = Process.Start(psi);
                proc.StandardInput.WriteLine(nmapCmdInput);
                proc.StandardInput.WriteLine("exit");
                outputNmap = proc.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {

                throw;
            }

            return outputNmap;
        }
    }
}