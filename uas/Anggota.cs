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
            tA.ShowDialog();
            ReadData();
         
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
            Properties.Settings.Default.username = null;
            Properties.Settings.Default.email = null;
            Properties.Settings.Default.id = 0;
            Properties.Settings.Default.isLogin = false;
            Program.LoginForm.Show();
            this.Close();
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
            usernameL.Text = "Username: " + Properties.Settings.Default.username;
            emailL.Text = "Email: " + Properties.Settings.Default.email;
        }

        private void ReadData()
        {
            string query = "SELECT * FROM anggota";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                tabelAnggota.Rows.Clear();
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
                    if (tabelAnggota.Rows.Count > 1) {
                        idA = (int)tabelAnggota.Rows[e.RowIndex].Cells["id"].Value;
                        if (idA != 0)
                        {
                            EditAnggota editAnggota = new EditAnggota();
                            editAnggota.Read(idA);
                            editAnggota.ShowDialog();
                            ReadData();
                        }
                    }
                }else if (e.ColumnIndex == tabelAnggota.Columns["delete"].Index)
                {
                    if (tabelAnggota.Rows.Count > 1)
                    {
                        idA = (int)tabelAnggota.Rows[e.RowIndex].Cells["id"].Value;
                        if (idA != 0)
                        {
                            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "DELETE FROM anggota WHERE id = @id";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@id", idA);
                                int esecute = cmd.ExecuteNonQuery();
                                if (esecute > 0)
                                {                              
                                    MessageBox.Show("Data Berhasil Di hapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ReadData();
                                }
                            }
                        }
                    }
                    
                } 
            }
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
