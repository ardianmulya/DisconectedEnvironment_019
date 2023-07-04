using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconected_Environment
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

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Prodi DP = new Data_Prodi();
            DP.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Mahasiswa DM = new Data_Mahasiswa();
            DM.Show();
            this.Hide();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Status_Mahasiswa DS = new Data_Status_Mahasiswa();
            DS.Show();
            this.Hide();
        }
    }
}
