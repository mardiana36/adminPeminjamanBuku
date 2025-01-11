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
    public partial class cPengembalian2 : Form
    {
        private int idPeminjaman;
        public cPengembalian2()
        {
            InitializeComponent();
        }

        private void findPeminjaman()
        {
            string nim = nimBox.Text.Trim(); 

            if (string.IsNullOrEmpty(nim))
            {
                MessageBox.Show("Silakan masukkan NIM.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    
                    string query = @"
                    SELECT p.id AS idPeminjaman, p.tenggat_pinjam, a.nama 
                    FROM peminjaman p
                    JOIN anggota a ON p.id_mhs = a.id
                    WHERE a.nim = @nim AND p.status = 'dipinjam'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nim", nim);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            
                            idPeminjaman = reader.GetInt32(reader.GetOrdinal("idPeminjaman"));
                            DateTime tenggatPinjam = reader.GetDateTime(reader.GetOrdinal("tenggat_pinjam"));
                            string namaAnggota = reader.GetString(reader.GetOrdinal("nama"));

                            
                            dateTimePickerTenggat.Value = tenggatPinjam; 
                            namaBox.Text = namaAnggota; 

                            
                            LoadBukuDipinjam(); 
                        }
                        else
                        {
                            MessageBox.Show("NIM tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mencari peminjaman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBukuDipinjam()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {

                    string query = @"
                    SELECT b.judul 
                    FROM detail_peminjaman dp
                    JOIN buku b ON dp.id_buku = b.id
                    WHERE dp.id_pinjam = @idPeminjaman";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        listBoxBuku.DataSource = dt;
                        listBoxBuku.DisplayMember = "judul";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat buku yang dipinjam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            findPeminjaman();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string status = statusBox.Text;
            string dendaText = dendaBox.Text;

            
            if (!int.TryParse(dendaText, out int denda))
            {
                MessageBox.Show("Denda harus berupa angka.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DateTime tglKembali = DateTime.Today;


            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    string query = @"
                    INSERT INTO pengembalian (id_pinjam, status, denda, tgl_kembali) 
                    VALUES (@idPinjam, @status, @denda, @tglKembali)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPinjam", idPeminjaman); 
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@denda", denda);
                        cmd.Parameters.AddWithValue("@tglKembali", tglKembali);

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            string updateQuery = @"
                            UPDATE peminjaman 
                            SET status = 'dikembalikan' 
                            WHERE id = @idPinjam";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@idPinjam", idPeminjaman);
                                int updateRowsAffected = updateCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Data pengembalian berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data pengembalian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat menyimpan data pengembalian: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
