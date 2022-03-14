using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace PlazzaDebugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process PcName = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C hostname",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            Process UserName = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C whoami",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }




            };

            UserName.Start();
            while (!UserName.StandardOutput.EndOfStream)
            {

                string username = UserName.StandardOutput.ReadToEnd();
                label2.Text = "Hello " + username;
            }

            PcName.Start();
            while (!PcName.StandardOutput.EndOfStream)
            {

                string name = PcName.StandardOutput.ReadToEnd();
                label1.Text = "Your PC-Name is:"+ name;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Process Pause = new Process
            {
               StartInfo = new ProcessStartInfo
               {
                   FileName = "cmd.exe",
                   Arguments ="/C ipconfig /all & Pause"
               }
            };
            Pause.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // OBS IT SUPPORT LINK 
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer","https://plazza.orange.com/community/it-support/obs-it-support");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Fetches file from resources creates a bat file and runs it
        private void button8_Click(object sender, EventArgs e)
        {

            string batFileName = "bataba.bat";
            string programName = Assembly.GetExecutingAssembly().GetName().Name;

            using (Stream input = Assembly.GetExecutingAssembly().GetManifestResourceStream(programName + "." + batFileName))
            {
                using (TextReader tr = new StreamReader(input))
                {
                    File.WriteAllText(batFileName, tr.ReadToEnd());
                }
            }


            Process proc = new Process();
            proc.EnableRaisingEvents = true;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = batFileName;
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process PKI = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C start SACTools.exe"
                }
            };
            MessageBox.Show("Press OK to open Safenet authenitcation client tools and generate a challenge code that you can provide us with on plazza");
            MessageBoxDefaultButton.Button1.Equals("Open safenet authentication client tools");
            PKI.Start();
        }
    }
}
