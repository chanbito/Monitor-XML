using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorDanfe
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length >= 1)
            {
                switch (args.FirstOrDefault().ToLower())
                {
                    case "/quit":
                        var processoCorrente = System.Diagnostics.Process.GetCurrentProcess();
                        string procname = processoCorrente.ProcessName;
                        int id = processoCorrente.Id;

                        foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcesses())
                        {
                            if (process.ProcessName.Equals(procname))
                            {
                                try
                                {
                                    process.Kill();
                                    return;
                                }
                                catch
                                {

                                }
                            }
                        }

                    break;
                    default:
                    break;
                }
            }



            Application.Run(new Form1());
        }
    }
}
