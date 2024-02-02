using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBackups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_startdaemon_Click(object sender, EventArgs e)
        {
            // Arrancamos el proceso "hijo"
            Process process = new Process();
            // Redirigimos la salida del proceso para poder capturarla desde nuestro programa
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.FileName = "C:\\Users\\josea\\Documents\\Visual Studio 2022\\Programas Propios Github\\PhoneBackups\\PhoneBackups\\Binarios\\adb.exe"; // Arrancamos el servidor de ADB desde visual studio
            process.StartInfo.FileName = ".\\Binarios\\adb.exe"; // Arrancamos el servidor de ADB
            process.StartInfo.Arguments = "start-server";
            process.StartInfo.CreateNoWindow = true;    // Para que no salga prompt cuando ejecutemos proceso
            process.Start();
            process.WaitForExit();
            process.StartInfo.Arguments = "devices";
            process.Start();
            
            string output = process.StandardOutput.ReadToEnd();
            string output_solodedispositivos = output.Replace("List of devices attached\r\n\r\n", "");  // Eliminamos la primera línea que siempre pone ADB para detectar luego si hay algún "device" conectado
            if (output_solodedispositivos.Contains("device"))
            {
                this.checkBox1_phonedetected.Checked = true;
                this.textBox1.Clear();
                this.textBox1.AppendText(output);
                this.textBox1.AppendText("\n\nYou are ready now to push the Backup button");
            }
            else 
            {
                this.textBox1.Clear();
                this.textBox1.AppendText("No device has been detected, please try to push the first button again");
            }
            process.WaitForExit();
        }

        private void Button_backup_Click(object sender, EventArgs e)
        {
            if (this.checkBox1_phonedetected.Checked == true)
            {
                Leelineasadbasincronas();

            }
            else
                MessageBox.Show("Phone not detected, push the first button instead","Phone connection failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CheckBox1_phonedetected_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Leelineasadbasincronas()
        {
            // Arrancamos el proceso "hijo"
            Process process = new Process();
            // Redirigimos la salida del proceso para poder capturarla desde nuestro programa (false)
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.RedirectStandardError = false;
            //process.StartInfo.FileName = "C:\\Users\\josea\\Documents\\Visual Studio 2022\\Programas Propios Github\\PhoneBackups\\PhoneBackups\\Binarios\\adb.exe"; // Arrancamos el servidor de ADB desde visual studio
            process.StartInfo.FileName = ".\\Binarios\\adb.exe"; // Arrancamos el servidor de ADB
            process.StartInfo.Arguments = "pull -a /sdcard";
            process.StartInfo.CreateNoWindow = false;    // Para que no salga prompt cuando ejecutemos proceso
            this.textBox1.Clear();
            this.textBox1.AppendText("The process will continue in a new window...");
            process.Start();
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                process.StartInfo.CreateNoWindow = true;    // Para que no salga prompt cuando ejecutemos proceso
                process.StartInfo.Arguments = "kill-server";    // Si termina la copia exitosamente, se cierra ADB para que no corra en segundo plano
                process.Start();
                process.WaitForExit();
                this.textBox1.Clear();
                this.textBox1.AppendText("Finished!");
                MessageBox.Show("The back up process has finished successfully, you'll find the backup copy inside \"\\sdcard\" folder", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                process.StartInfo.CreateNoWindow = true;    // Para que no salga prompt cuando ejecutemos proceso
                process.StartInfo.Arguments = "kill-server";    // Si falla la copia, se cierra ADB para que no corra en segundo plano
                process.Start();
                process.WaitForExit();
                this.textBox1.Clear();
                this.textBox1.AppendText("Error! Try to make a new backup");
                MessageBox.Show("Error while copying files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
