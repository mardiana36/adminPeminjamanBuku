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

namespace uas
{
    public partial class pengembalian : Form
    {
        public pengembalian()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            cPengembalian2 cPengembalian = new cPengembalian2();
            if (cPengembalian.ShowDialog() == DialogResult.OK)
            {
                LoadDataPengembalian();
            }

        }
        private void LoadDataPengembalian()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    string query = @"
            SELECT 
                p.id AS IdPeminjaman,
                a.nama AS NamaAnggota,
                pg.tgl_kembali AS TanggalPengembalian,
                pg.status AS Status,
                pg.denda AS Denda,
                b.judul AS JudulBuku
                
            FROM 
                pengembalian pg
            JOIN 
                peminjaman p ON pg.id_pinjam = p.id
            JOIN 
                anggota a ON p.id_mhs = a.id
            JOIN 
                detail_peminjaman dp ON p.id = dp.id_pinjam
            JOIN 
                buku b ON dp.id_buku = b.id;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["IdPeminjaman"].HeaderText = "ID Peminjaman";
                    dataGridView1.Columns["NamaAnggota"].HeaderText = "Nama Anggota";
                    dataGridView1.Columns["TanggalPengembalian"].HeaderText = "Tanggal Pengembalian";
                    dataGridView1.Columns["JudulBuku"].HeaderText = "Daftar Buku";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat data pengembalian: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                var selectedRow = dataGridView1.SelectedRows[0];
                int idPeminjaman = Convert.ToInt32(selectedRow.Cells["IDPeminjaman"].Value);
                int denda = Convert.ToInt32(selectedRow.Cells["Denda"].Value);
                string status = selectedRow.Cells["Status"].Value.ToString();

                uPengembalian uPengembalian = new uPengembalian(idPeminjaman,denda,status);
                if (uPengembalian.ShowDialog() == DialogResult.OK) 
                {
                    LoadDataPengembalian();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih peminjaman yang ingin diubah.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peminjaman pj = new peminjaman();
            pj.Show();
            this.Close();
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota ag = new Anggota();
            ag.Show();
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

        private void pengembalian_Load(object sender, EventArgs e)
        {
            LoadDataPengembalian();
        }

        private void DeletePengembalian(int idPeminjaman)
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    string deletePengembalianQuery = "DELETE FROM pengembalian WHERE id_pinjam = @idPeminjaman";
                    using (SqlCommand cmdPengembalian = new SqlCommand(deletePengembalianQuery, conn))
                    {
                        cmdPengembalian.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                        int rowsAffected = cmdPengembalian.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Peminjaman berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPengembalian();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus peminjaman.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error menghapus peminjaman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                var selectedRow = dataGridView1.SelectedRows[0];
                int idPeminjaman = Convert.ToInt32(selectedRow.Cells["IDPeminjaman"].Value); 


                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus peminjaman ini?",
                                                     "Konfirmasi Hapus",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    DeletePengembalian(idPeminjaman);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih peminjaman yang ingin dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void pengembalian_Shown(object sender, EventArgs e)
        {
            usernameL.Text = "Username: " + Properties.Settings.Default.username;
            emailL.Text = "Email: " + Properties.Settings.Default.email;
        }
    }
}
