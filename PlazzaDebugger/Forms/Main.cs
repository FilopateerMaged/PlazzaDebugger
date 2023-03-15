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


        //_____________ On load the form fetches the PC name to display it __________________
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


            //__________________________Displaying the PC Name______________________________

            PcName.Start();
            while (!PcName.StandardOutput.EndOfStream)
            {

                string name = PcName.StandardOutput.ReadToEnd();
                label1.Text = "Your PC-Name is:" + name;
            }
        }
        

        //____________________ UI element to navigate to the network Form_____________________
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

        //_____________________Clearing temp Files_________________________________________________
        // This bascially goes to the temp directory makes sure it exists and deletes it recusrsively 
        // the catch error makes sure that if a file is being used it's not deleted and doesn't stop the deletion of the rest of the files

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

        //_____________________Clearing teams cache_________________________________________ 
        // the function CLoses teams .. navigates to the app data folder searches for the MS folder and teams inside it then deleting everything inside 
        // there's a check to make sure the folder exists first


        private void teams_cache_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /T /IM Teams.exe");
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var Ms = Path.Combine(appdata, "Microsoft");
            var teams = Path.Combine(Ms, "Teams");
            string cache = teams;
            // If directory does not exist, don't even try   
            if (Directory.Exists(cache))
            {
                Directory.Delete(cache, true);
            }
            MessageBox.Show("Teams Cache deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browsers browsers = new Browsers();
            browsers.TopLevel = false;
            browsers.TopMost = true;
            browsers.Dock = DockStyle.Fill;
            browsers.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
            Form form1 = (Form1)Application.OpenForms["Form1"];
            Panel panel1 = (Panel)form1.Controls["HomePanel"];
            panel1.Controls.Add(browsers);
            browsers.Show();
            browsers.BringToFront();
        }
    }

   }

