using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FixBrawlSaving
{
    public partial class Form1 : Form
    {
        string wszst = @"C:\Program Files\Wiimm\SZS\wszst.exe";
        string szspath = string.Empty;
        string szsdpath = string.Empty;
        string lm_szspath = string.Empty;
        string lm_szsdpath = string.Empty;
        string lm_szsname = string.Empty;
        string lm_szsdname = string.Empty;
        string szsname = string.Empty;
        string szsdname = string.Empty;
        string tempFolderPath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "tempwszst");
        string infotxt = "info.txt";
        string szsdefaultname = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                if (Directory.Exists(tempFolderPath))   //Deletes tempfolder if it still exists to clean up old files
                {
                Process cmdcleartemp = new Process();
                cmdcleartemp.StartInfo.FileName = "cmd.exe";
                cmdcleartemp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmdcleartemp.StartInfo.Arguments = "/c rmdir %temp%\tempwszst /s /q";
                cmdcleartemp.Start();
                }

            if (File.Exists(wszst)) //Does the user have wszst installed
            {
                lblwszst.Text = "Wiimms SZS Tools found!";
                lblwszst.ForeColor = Color.Green;
            }
            else
            {
                lblwszst.Text = "Wiimms SZS Tools not found!";
                lblwszst.ForeColor = Color.Red;
                DialogResult result = MessageBox.Show("Do you wish to download Wiimms SZS Tools now?", "Wiimms SZS Tools seems to be missing!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    DialogResult result2 = MessageBox.Show("Do you wish to contine?", "Do you wish to contine?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result2 == DialogResult.No)
                    {
                        Close();
                    }
                }
                else
                {
                    string url = "https://szs.wiimm.de/download.html";

                    Process.Start(url);
                    Close();
                }           
            }
        }

        private string convertszs(string szs)   //Converts given string from .szs to .d 
        {
            return szs.Replace(".szs", ".d");   
        }

        private string convertlm (string szs)
        {
            return "\""+szs+"\"";
        }

        private async void loadszs_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Status: Working...";


            saveszs.Enabled = false;    
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                szspath = openFileDialog1.FileName;
            }
  
            szsdpath = convertszs(szspath);
            szsname = openFileDialog1.SafeFileName; 
            szsdname = convertszs(szsname);
            lm_szspath = convertlm(szspath);
            lm_szsdpath = convertlm(szsdpath);
            lm_szsname= convertlm(szsname);
            lm_szsdname = convertlm(szsdname);

            lblszs.Text = "Current SZS: " + szspath;

            string extractszs = "/c wszst extract "+lm_szspath+" -d %temp%\\tempwszst\\"+lm_szsdname;

            MessageBox.Show(extractszs);

            Process cmdextractszs = new Process();
            cmdextractszs.StartInfo.FileName = "cmd.exe";
            cmdextractszs.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            cmdextractszs.StartInfo.Arguments = extractszs;
            cmdextractszs.Start();

            await Task.Delay(10000);    //Needed delay to ensure the steps from above finished before moving on, (might be too long)

            string fixszspath = "%temp%\tempwzst" + szsdname;

            string fixszs = "/c cd $env:TEMP\\tempwszst\\;  mv '.\\" + szsdname + "\\bg\\timg\\button\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\button\\timg\\control\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\control\\timg\\dpd_pointer\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\dpd_pointer\\timg\\effect\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\dpd_pointer\\timg\\globe\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\globe\\ctrl\\message_window\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\message_window\\timg\\model\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\model\\timg\\pad_recognize\\' '.\\" + szsdname + "\\'; " +
                "mv '.\\" + szsdname + "\\pad_recognize\\timg\\parameter\\' '.\\" + szsdname + "\\'";

            Process cmdfixszs = new Process();
            cmdfixszs.StartInfo.FileName = "powershell.exe";
            cmdfixszs.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            cmdfixszs.StartInfo.Arguments = fixszs;
            cmdfixszs.Start();
         
            saveszs.Enabled = true;
            lblstatus.Text = "Status: Finished!";
            lblstatus.ForeColor = Color.Green;

            await Task.Delay(4000); //delay for changing text

            lblstatus.Text = "Status: Waiting...";

            lblstatus.ForeColor = Color.Black;
        }

        private async void saveszs_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Status: Working...";
            lblstatus.ForeColor = Color.Black;
            loadszs.Enabled = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            string saveto = saveFileDialog1.FileName;

            string saveszs = "/c wszst c --overwrite \"%temp%\\tempwszst\\" + szsdname + "\" -d \"" + saveto+"\"";

            Process cmdsaveszs = new Process();
            cmdsaveszs.StartInfo.FileName = "cmd.exe";
            cmdsaveszs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdsaveszs.StartInfo.Arguments = saveszs;
            cmdsaveszs.Start();

            loadszs.Enabled = true;

            lblstatus.Text = "Status: Finished!";
            lblstatus.ForeColor = Color.Green;

            await Task.Delay(4000); //delay for changing text

            lblstatus.Text = "Status: Waiting...";

            lblstatus.ForeColor = Color.Black;  
        }  
    }
}
