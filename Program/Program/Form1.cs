using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Notepad")
            {
                System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo();
                procInfo.FileName = ("notepad.exe");
                System.Diagnostics.Process.Start(procInfo);
            }

            if (comboBox1.Text == "Paint")
            {
                System.Diagnostics.ProcessStartInfo pRocInfo = new System.Diagnostics.ProcessStartInfo();
                pRocInfo.FileName = ("mspaint.exe");
                System.Diagnostics.Process.Start(pRocInfo);
            }
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko Dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxDescription.Clear();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da zelite da zatvorite aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
