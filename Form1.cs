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

namespace FixBrawlSaving
{
    public partial class Form1 : Form
    {

        string wszst = @"C:\Program Files\Wiimm\SZS\wszst.exe";
        

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
            if (File.Exists(wszst)) {

                MessageBox.Show("yes");
            }
        }
    }
}
