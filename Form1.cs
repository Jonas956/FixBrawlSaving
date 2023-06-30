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
        string szsname = string.Empty;
        string szsdname = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(wszst))
            {
                lblwszst.Text = "Wiimms SZS Tools found!";
                lblwszst.ForeColor = Color.Green;
            }
            else
            {
                lblwszst.Text = "Wiimms SZS Tools not found!";
                lblwszst.ForeColor = Color.Red;
            }
        }

        private async void debug_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("start");
            await Task.Delay(10000);
            MessageBox.Show("ende");

        }

        private string convertszs(string szs)
        {
            return szs.Replace(".szs", ".d");
        }

        private async void loadszs_Click(object sender, EventArgs e)
        {
           


            saveszs.Enabled = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                szspath = openFileDialog1.FileName;
            }

            
            szsdpath = convertszs(szspath);
            szsname = openFileDialog1.SafeFileName;
            szsdname = convertszs(szsname);

         
            //Creation of the Tempfolder where the file will be extracted to!
            string mktemp = "/c cd %temp% && mkdir tempwszst";

            Process cmdmktemp = new Process();
            cmdmktemp.StartInfo.FileName = "cmd.exe";
            cmdmktemp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdmktemp.StartInfo.Arguments = mktemp;
            cmdmktemp.Start();

           // System.Diagnostics.Process.Start("CMD.exe","cmd.exe /c" + mktemp);

            lblszs.Text = "Current SZS: " + szspath;

            //Extracting the SZS File to %temp%

            string extractszs = "/c wszst extract "+szspath+" -d %temp%\\tempwszst\\"+szsdname +" && timeout / t 2";

            Process cmdextractszs = new Process();
            cmdextractszs.StartInfo.FileName = "cmd.exe";
            cmdextractszs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdextractszs.StartInfo.Arguments = extractszs;
            cmdextractszs.Start();

            await Task.Delay(10000);
            


            //System.Diagnostics.Process.Start("CMD.exe", "cmd.exe /c" + extractszs);


            //Fix SZS 

            string fixszspath = "%temp%\tempwzst" + szsdname;
            

            string fixszs = "/c cd $env:TEMP\\tempwszst\\; mv .\\"+szsdname+"\\bg\\timg\\button\\ .\\"+szsdname+"\\;" + //Funktioniert bis hier!
                "mv .\\"+szsdname+ "\\button\\timg\\control\\ .\\" + szsdname+"\\;" +
                "mv .\\"+szsdname+"\\control\\timg\\dpd_pointer\\ .\\"+szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\dpd_pointer\\timg\\effect\\ .\\" + szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\dpd_pointer\\timg\\globe\\ .\\" + szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\globe\\ctrl\\message_window\\ .\\" + szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\message_window\\timg\\model\\ .\\" + szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\model\\timg\\pad_recognize\\ .\\" + szsdname+"\\; " +
                "mv .\\"+szsdname+ "\\pad_recognize\\timg\\parameter\\ .\\" + szsdname+ "\\";

            Process cmdfixszs = new Process();
            cmdfixszs.StartInfo.FileName = "powershell.exe";
            cmdfixszs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdfixszs.StartInfo.Arguments = fixszs;
            cmdfixszs.Start();

            //System.Diagnostics.Process.Start("powershell",fixszs);
            saveszs.Enabled = true;

        }

        private void saveszs_Click(object sender, EventArgs e)
        {
            loadszs.Enabled = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }

            string saveto = saveFileDialog1.FileName;

            string saveszs = "/c wszst c %temp%\\tempwszst\\"+szsdname+ " -d "+saveto;

            Process cmdsaveszs = new Process();
            cmdsaveszs.StartInfo.FileName = "cmd.exe";
            cmdsaveszs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdsaveszs.StartInfo.Arguments = saveszs;
            cmdsaveszs.Start();

            loadszs.Enabled = true;

            //MessageBox.Show(saveszs);


            //System.Diagnostics.Process.Start("cmd", saveszs);

        }
    }
}
