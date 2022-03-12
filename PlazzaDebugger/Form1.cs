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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void formMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void airForm1_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.BackColor != Color.Black)
            {

                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
