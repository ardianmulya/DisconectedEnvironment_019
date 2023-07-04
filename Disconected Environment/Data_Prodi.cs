using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconected_Environment
{
    public partial class Data_Prodi : Form
    {
        private string stringConnection = "data source = MSI\\ARDIANMULYA;database=BLOB;MultipleActiveResultSets=True;User ID = sa; Password = namaku123";
        private SqlConnection koneksi;

        private void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = true;
            Save.Enabled = true;
            Clear.Enabled = true;
        }
        public Data_Prodi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView();
            Open.Enabled = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            Save.Enabled = true;
            Clear.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Close();
                string str = "insert into dbo.Prodi (nama_prodi)" + "values(@id";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", nmProdi));

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void Data_Prodi_Closed(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void Data_Prodi_Load(object sender, EventArgs e)
        {

        }
    }
}
