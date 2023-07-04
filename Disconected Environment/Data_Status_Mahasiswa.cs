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
    public partial class Data_Status_Mahasiswa : Form
    {
        private string stringConnection = "data source = MSI\\ARDIANMULYA;database=BLOB;MultipleActiveResultSets=True;User ID = sa; Password = namaku123";
        private SqlConnection koneksi;
        double val = 0;

        private void refreshform()
        {
            Nama.Enabled = false;
            StatusMahasiswa.Enabled = false;
            TahunMasuk.Enabled = false;
            Nama.SelectedIndex = -1;
            StatusMahasiswa.SelectedIndex = -1;
            TahunMasuk.SelectedIndex = -1;
            txtNIM.Visible = false;
            Save.Enabled = false;
            Clear.Enabled = false;
            Add.Enabled = true;
        }
        public Data_Status_Mahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void cbNama()
        {
            koneksi.Open();
            string str = "SELECT nama_mahasiswa FROM Mahasiswa";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                Nama.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();
        }

        private void cbTahunMasuk()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    TahunMasuk.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    TahunMasuk.Items.Add(l.ToString());
                }
            }

        }



        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView();
            Open.Enabled = false;
        }

        private void Nama_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select nim from dbo.mahasiswa where nama_mahasiswa = @nama_mahasiswa";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = Nama.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_mahasiswa", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nim = dr.GetString(0);
                txtNIM.Text = nim;
            }
            else
            {
                txtNIM.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TahunMasuk.Enabled = true;
            Nama.Enabled = true;
            StatusMahasiswa.Enabled = true;
            txtNIM.Visible = true;
            cbTahunMasuk();
            cbNama();
            Clear.Enabled = true;
            Save.Enabled = true;
            Add.Enabled = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string nim = txtNIM.Text;
            string statusMahasiswa = StatusMahasiswa.Text;
            string tahunMasuk = TahunMasuk.Text;
            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.status_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                string queryString = "select Max(id_status) from dbo.status_mahasiswa";
                cm = new SqlCommand(queryString, koneksi);
                SqlCommand cmStatusMahasiswa = new SqlCommand(queryString, koneksi);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    tempKodeStatus = dr.GetString(0);
                }
                dr.Close();
                int tempKode = int.Parse(tempKodeStatus);
                tempKode++;
                kodeStatus = tempKode.ToString();
            }
            string queryStrings = "INSERT INTO dbo.status_mahasiswa (id_status, nim, status_mahasiswa, tahun_masuk) VALUES (@id_status, @nim, @status_mahasiswa, @tahun_masuk)";
            SqlCommand cmd = new SqlCommand(queryStrings, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_status", kodeStatus));
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("status_mahasiswa", statusMahasiswa));
            cmd.Parameters.Add(new SqlParameter("tahun_masuk", tahunMasuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }
        private void Data_Status_Mahasiswa_FormClosed(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        private void autoIDStatus()
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("Select count (id_status) from dbo.status_mahasiswa", koneksi);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            koneksi.Close();
            i++;
            label3.Text = "STM" + val + i.ToString();
        }

        private void Data_Status_Mahasiswa_Load(object sender, EventArgs e)
        {
            autoIDStatus();
        }
    }
}
