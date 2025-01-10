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
    public partial class buku : Form
    {
        SqlConnection conn;
        public buku()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota ag = new Anggota();
            ag.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            tambahBuku tambahBuku = new tambahBuku();
            tambahBuku.ShowDialog();
            ReadData();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void buku_Shown(object sender, EventArgs e)
        {
            ReadData();
            usernameL.Text = "Username: " + Properties.Settings.Default.username;
            emailL.Text = "Email: " + Properties.Settings.Default.email;
        }

        private void ReadData()
        {
            string query = "SELECT * FROM buku";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                tabelBuku.Rows.Clear();
                while (reader.Read())
                {
                    
                    tabelBuku.Rows.Add(
                    reader["id"],
                    reader["judul"].ToString(),
                    reader["deskripsi"].ToString(),
                    reader["pengarang"].ToString(),
                    reader["penerbit"].ToString(),
                    reader["tahun"].ToString(),
                    reader["isbn"].ToString(),
                    reader["stok"].ToString(),
                    reader["kategori"].ToString(),
                    "Edit",
                    "Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
            }
        }

        private void tabelBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idA = 0;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tabelBuku.Columns["edit"].Index)
                {
                    if (tabelBuku.Rows.Count > 1)
                    {
                        idA = (int)tabelBuku.Rows[e.RowIndex].Cells["id"].Value;
                        if (idA != 0)
                        {
                            editBuku buku = new editBuku();
                            buku.Read(idA);
                            buku.ShowDialog();
                            ReadData();
                        }
                    }
                }
                else if (e.ColumnIndex == tabelBuku.Columns["delete"].Index)
                {
                    if (tabelBuku.Rows.Count > 1)
                    {
                        idA = (int)tabelBuku.Rows[e.RowIndex].Cells["id"].Value;
                        if (idA != 0)
                        {
                            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "DELETE FROM buku WHERE id = @id";
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
    }
}
