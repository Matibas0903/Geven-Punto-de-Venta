using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMerceria
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Instalar LocalDB si no está
            string rutaInstalador = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SqlLocalDB.msi");

            if (!LocalDBInstalada())
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo("msiexec.exe", "/i \"" + rutaInstalador + "\" /quiet /norestart");
                    psi.UseShellExecute = false;
                    Process proceso = Process.Start(psi);
                    proceso.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error instalando SQL Server LocalDB: " + ex.Message);
                    return; // Cortar ejecución si falla
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            bool LocalDBInstalada()
            {
                string rutaLocalDB = Environment.ExpandEnvironmentVariables(@"%ProgramFiles%\Microsoft SQL Server\110\LocalDB\Binn\SqlLocalDB.exe");
                return File.Exists(rutaLocalDB);
            }
        }
    }
}
