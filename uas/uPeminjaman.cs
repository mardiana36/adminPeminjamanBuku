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
    public partial class uPeminjaman : Form
    {
        private int idPeminjaman;
        public uPeminjaman(string nim, DateTime tglPinjam, DateTime tenggatPinjam, int idPeminjaman)
        {
            InitializeComponent();

            
            textNIM.Text = nim;
            dateTimePickerPinjam.Value = tglPinjam;
            dateTimePickerTenggat.Value = tenggatPinjam;
            this.idPeminjaman = idPeminjaman; 

           
            LoadBukuDipinjam();
            LoadAvailableBooks(); 
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

                        
                        listBoxBukuDipinjam.DataSource = dt;
                        listBoxBukuDipinjam.DisplayMember = "judul"; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat buku yang dipinjam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void LoadAvailableBooks()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return; 

                try
                {
                    
                    string query =  "SELECT id, judul FROM buku WHERE stok > 0"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        
                        listBoxBuku.DataSource = dt;
                        listBoxBuku.DisplayMember = "judul"; 
                        listBoxBuku.ValueMember = "id"; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat buku yang tersedia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nim = textNIM.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nim = textNIM.Text;
            DateTime tglPinjam = dateTimePickerPinjam.Value;
            DateTime tenggatPinjam = dateTimePickerTenggat.Value;

            
            if (string.IsNullOrWhiteSpace(nim))
            {
                MessageBox.Show("NIM tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int idBukuBaru = (int)((DataRowView)listBoxBuku.SelectedItem)["id"]; 

            
            UpdatePeminjaman(idPeminjaman, idBukuBaru, nim, tglPinjam, tenggatPinjam);
        }

        private void UpdatePeminjaman(int idPeminjaman, int idBukuBaru, string nim, DateTime tglPinjam, DateTime tenggatPinjam)
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return; 

                try
                {
                    
                    string updatePeminjamanQuery = @"
                    UPDATE peminjaman 
                    SET tgl_pinjam = @tglPinjam, tenggat_pinjam = @tenggatPinjam 
                    WHERE id = @idPeminjaman";

                    using (SqlCommand cmd = new SqlCommand(updatePeminjamanQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@tglPinjam", tglPinjam);
                        cmd.Parameters.AddWithValue("@tenggatPinjam", tenggatPinjam);
                        cmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);

                        cmd.ExecuteNonQuery(); 
                    }

                    
                    string deleteDetailQuery = "DELETE FROM detail_peminjaman WHERE id_pinjam = @idPeminjaman";
                    using (SqlCommand cmdDelete = new SqlCommand(deleteDetailQuery, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                        cmdDelete.ExecuteNonQuery(); 
                    }

                    
                    string insertDetailQuery = "INSERT INTO detail_peminjaman (id_pinjam, id_buku, jumlah) VALUES (@idPinjam, @idBuku, @jumlah)";
                    using (SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn))
                    {
                        cmdDetail.Parameters.AddWithValue("@idPinjam", idPeminjaman);
                        cmdDetail.Parameters.AddWithValue("@idBuku", idBukuBaru);
                        cmdDetail.Parameters.AddWithValue("@jumlah", 1); 
                        cmdDetail.ExecuteNonQuery(); 
                    }

                    MessageBox.Show("Detail peminjaman berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error memperbarui peminjaman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
    }
}
