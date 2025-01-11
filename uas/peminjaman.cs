using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace uas
{
    public partial class peminjaman : Form
    {
        public peminjaman()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            cPeminjaman pinjam = new cPeminjaman();
            if (pinjam.ShowDialog() == DialogResult.OK)
            {
                LoadDataPeminjaman();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                var selectedRow = dataGridView1.SelectedRows[0];
                string nim = selectedRow.Cells["NIM"].Value.ToString();
                DateTime tglPinjam = Convert.ToDateTime(selectedRow.Cells["TanggalPeminjaman"].Value);
                DateTime tenggatPinjam = Convert.ToDateTime(selectedRow.Cells["TenggatPeminjaman"].Value);
                int idPeminjaman = Convert.ToInt32(selectedRow.Cells["ID"].Value); 
               
                uPeminjaman updateForm = new uPeminjaman(nim, tglPinjam, tenggatPinjam, idPeminjaman);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataPeminjaman();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih peminjaman yang ingin diubah.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void peminjaman_Load(object sender, EventArgs e)
        {
            LoadDataPeminjaman();
        }

        private void LoadDataPeminjaman()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    string query = @"
                        SELECT 
                            p.id AS ID,  
                            a.nama AS NamaAnggota,
                            a.nim AS NIM,
                            p.tgl_pinjam AS TanggalPeminjaman,
                            p.tenggat_pinjam AS TenggatPeminjaman,
                            STRING_AGG(b.judul, ', ') AS BukuDipinjam
                        FROM 
                            peminjaman p
                        JOIN 
                            anggota a ON p.id_mhs = a.id
                        JOIN 
                            detail_peminjaman dp ON p.id = dp.id_pinjam
                        JOIN 
                            buku b ON dp.id_buku = b.id
                        GROUP BY 
                            p.id, a.nama, a.nim, p.tgl_pinjam, p.tenggat_pinjam
                        ORDER BY 
                            p.id ASC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["ID"].HeaderText = "ID Peminjaman";
                    dataGridView1.Columns["NamaAnggota"].HeaderText = "Nama Anggota"; 
                    dataGridView1.Columns["NIM"].HeaderText = "NIM"; 
                    dataGridView1.Columns["TanggalPeminjaman"].HeaderText = "Tanggal Peminjaman"; 
                    dataGridView1.Columns["TenggatPeminjaman"].HeaderText = "Tenggat Peminjaman"; 
                    dataGridView1.Columns["BukuDipinjam"].HeaderText = "Daftar Buku"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                var selectedRow = dataGridView1.SelectedRows[0];
                int idPeminjaman = Convert.ToInt32(selectedRow.Cells["ID"].Value); 

                
                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus peminjaman ini?",
                                                     "Konfirmasi Hapus",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    DeletePeminjaman(idPeminjaman);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih peminjaman yang ingin dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePeminjaman(int idPeminjaman)
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return; 

                try
                { 
                    string deleteDetailQuery = "DELETE FROM detail_peminjaman WHERE id_pinjam = @idPinjam";
                    using (SqlCommand cmdDetail = new SqlCommand(deleteDetailQuery, conn))
                    {
                        cmdDetail.Parameters.AddWithValue("@idPinjam", idPeminjaman);
                        cmdDetail.ExecuteNonQuery(); 
                    }

                    
                    string deletePeminjamanQuery = "DELETE FROM peminjaman WHERE id = @idPeminjaman";
                    using (SqlCommand cmdPeminjaman = new SqlCommand(deletePeminjamanQuery, conn))
                    {
                        cmdPeminjaman.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                        int rowsAffected = cmdPeminjaman.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Peminjaman berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPeminjaman(); 
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

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void peminjaman_Shown(object sender, EventArgs e)
        {
            usernameL.Text = "Username: " + Properties.Settings.Default.username;
            emailL.Text = "Email: " + Properties.Settings.Default.email;
        }
    }
}
