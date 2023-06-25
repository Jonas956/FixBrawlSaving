using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        private void debug_Click(object sender, EventArgs e)
        {
            /*
             MessageBox.Show(szspath);
             MessageBox.Show(szsdpath);
             MessageBox.Show(szsname);
             MessageBox.Show(szsdname);
            */

            MessageBox.Show("cd $env: TEMP\\tempwszst\\; mv.\\"+szsdname+"\\bg\\timg\\button\\ .\\"+szsdname+"\\");

        }

        private string convertszs(string szs)
        {
            return szs.Replace(".szs", ".d");
        }

        private void loadszs_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                szspath = openFileDialog1.FileName;
            }

            
            szsdpath = convertszs(szspath);
            szsname = openFileDialog1.SafeFileName;
            szsdname = convertszs(szsname);

         /*
            //Creation of the Tempfolder where the file will be extracted to!
            string mktemp = "cd %temp% && mkdir tempwszst";
            System.Diagnostics.Process.Start("CMD.exe","cmd.exe /c" + mktemp);

            lblszs.Text = "Current SZS: " + szspath;

            //Extracting the SZS File to %temp%

            string extractszs = "wszst extract "+szspath+" -d %temp%\\tempwszst\\"+szsdname;
            System.Diagnostics.Process.Start("CMD.exe", "cmd.exe /c" + extractszs);
         */

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
                "mv .\\"+szsdname+ "\\pad_recognize\\timg\\parameter\\ .\\" + szsdname+"\\";

            System.Diagnostics.Process.Start("powershell",fixszs);
        }

        private void saveszs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
