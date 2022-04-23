using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlazzaDebugger
{


    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
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

            PcName.Start();
            while (!PcName.StandardOutput.EndOfStream)
            {

                string name = PcName.StandardOutput.ReadToEnd();
                label1.Text = "Your PC-Name is:" + name;
            }
        }

        private void Network_Click(object sender, EventArgs e)
        {
           
            
                Back network = new Back();
                network.TopLevel = false;
                network.TopMost = true;
                network.Dock = DockStyle.Fill;
                network.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Panel panel1 = (Panel)form1.Controls["HomePanel"];
                panel1.Controls.Add(network);
                network.Show();
            network.BringToFront();
            
        }

        private void Delete_Temp_Click(object sender, EventArgs e)
        {
            var tmpPath = Path.GetTempPath();
            try
            {
                if (Directory.Exists(tmpPath))
                {
                    Directory.Delete(tmpPath,true);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            MessageBox.Show("Temp Files Deleted!");

            
        }
    }

   }

