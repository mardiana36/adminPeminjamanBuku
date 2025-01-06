using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas
{
    public partial class Anggota : Form
    {
        private SqlConnection conn;

        public Anggota()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambahAnggota tA = new tambahAnggota();
            tA.Show();
            this.Close();
        }
        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peminjaman pj = new peminjaman();
            pj.Show();
            this.Close();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengembalian pg = new pengembalian();
            pg.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buku bk = new buku();
            bk.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is cPeminjaman)
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Anggota_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            string query = "SELECT * FROM anggota";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string path = Path.Combine(Application.StartupPath, "..", "..", "img", reader["fotoKTM"].ToString());
                    Image imgKtm = Image.FromFile(path);
                    tabelAnggota.Rows.Add(
                    reader["id"],
                    imgKtm,
                    reader["nim"].ToString(),
                    reader["nama"].ToString(),
                    reader["status"].ToString(),
                    "Edit",
                    "Delete"
                    );
                }
            }
            catch (Exception ex){
                MessageBox.Show($"Gagal mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                reader.Close();
            }
        }

        private void tabelAnggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idA = 0;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tabelAnggota.Columns["edit"].Index)
                {
                    idA = (int) tabelAnggota.Rows[e.RowIndex].Cells["id"].Value;
                    if (idA != 0)
                    {
                        EditAnggota editAnggota = new EditAnggota();
                        editAnggota.Show();
                        editAnggota.Read(idA);
                    }
                } 
            }
        }
    }
}
