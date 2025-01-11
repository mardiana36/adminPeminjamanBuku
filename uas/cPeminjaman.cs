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
    public partial class cPeminjaman : Form
    {
        public cPeminjaman(){

            InitializeComponent();
        }


        private void cPeminjaman_Load(object sender, EventArgs e)
        {
            LoadBuku();
        }

        private void LoadBuku()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                string query = "SELECT id, judul FROM buku WHERE stok > 0"; 
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nim = nimBox.Text;
        }

       
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string nim = nimBox.Text;

            
            if (string.IsNullOrWhiteSpace(nim))
            {
                MessageBox.Show("NIM tidak boleh kosong.");
                return;
            }

            int idAnggota = GetIdAnggotaByNim(nim);
            bool checkPeminjaman = CheckPeminjamanByIdAnggota(idAnggota);
            if (idAnggota == -1)
            {
                MessageBox.Show("NIM tidak ditemukan.");
                return;

            }else if(checkPeminjaman == true)
            {
                MessageBox.Show("Masih terdapat status peminjaman yang aktif.");
                return;
            }

            foreach (var selectedItem in listBoxBuku.SelectedItems)
            {
                
                int idBuku = (int)((DataRowView)selectedItem)["id"];
                
            }

            
            SimpanPeminjaman(idAnggota);

        }

        private void SimpanPeminjaman(int idAnggota)
        {
            DateTime tanggalPeminjaman = dateTimePickerPinjam.Value;
            DateTime tenggatPeminjaman = dateTimePickerTenggat.Checked ? dateTimePickerTenggat.Value : DateTime.Now.AddDays(7); 

            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection()) 
            {
                if (conn == null) return; 

                try
                {

                    string insertPeminjaman = @"
                    INSERT INTO peminjaman (tgl_pinjam, tenggat_pinjam, id_user, id_mhs, status) 
                    OUTPUT INSERTED.id 
                    VALUES (@tglPinjam, @tenggatPinjam, @idUser , @idMhs, 'dipinjam')";

                    using (SqlCommand cmd = new SqlCommand(insertPeminjaman, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@tglPinjam", tanggalPeminjaman);
                        cmd.Parameters.AddWithValue("@tenggatPinjam", tenggatPeminjaman);
                        cmd.Parameters.AddWithValue("@idUser ", Properties.Settings.Default.id); 
                        cmd.Parameters.AddWithValue("@idMhs", idAnggota);

                        int idPeminjaman = (int)cmd.ExecuteScalar(); 

                        
                        foreach (DataRowView selectedBook in listBoxBuku.SelectedItems)
                        {
                            int idBuku = (int)selectedBook["id"];
                            string insertDetail = "INSERT INTO detail_peminjaman (id_pinjam, id_buku, jumlah) VALUES (@idPinjam, @idBuku, @jumlah)";
                            using (SqlCommand cmdDetail = new SqlCommand(insertDetail, conn)) 
                            {
                                cmdDetail.Parameters.AddWithValue("@idPinjam", idPeminjaman);
                                cmdDetail.Parameters.AddWithValue("@idBuku", idBuku);
                                cmdDetail.Parameters.AddWithValue("@jumlah", 1); 
                                cmdDetail.ExecuteNonQuery(); 
                            }
                        }
                        MessageBox.Show("Peminjaman berhasil disimpan.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving loan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private int GetIdAnggotaByNim(string nim)
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {     
                string query = "SELECT id FROM anggota WHERE nim = @nim";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nim", nim);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; 
                }
            }
        }

        private bool CheckPeminjamanByIdAnggota(int idAnggota)
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                string query = "SELECT COUNT(*) FROM peminjaman WHERE id_mhs = @id_mhs AND (status IS NULL OR status = 'dipinjam')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_mhs", idAnggota);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; 
                }
            }
        }

    }
}
