using System;
using System.Collections;
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
    public partial class editBuku : Form
    {
        private int idA;
        private SqlConnection conn;
        public editBuku()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }
        public void Read(int id)
        {
            this.idA = id;
        }

        private void editBuku_Shown(object sender, EventArgs e)
        {
            if (idA > 0)
            {
                string query = "SELECT * FROM buku WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idA);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        inputJudul.Text = reader["judul"].ToString();
                        inputKategori.Text = reader["kategori"].ToString();
                        inputPenerbit.Text = reader["penerbit"].ToString();
                        inputPengarang.Text = reader["pengarang"].ToString();
                        inputTahun.Text = reader["tahun"].ToString();
                        inputStok.Text = reader["stok"].ToString();
                        inputISBN.Text = reader["isbn"].ToString();
                        inputDeskripsi.Text = reader["deskripsi"].ToString();
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputJudul.Text))
            {
                MessageBox.Show("Judul buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(inputKategori.Text))
            {
                MessageBox.Show("Kategori buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(inputPenerbit.Text))
            {
                MessageBox.Show("Penerbit buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(inputPengarang.Text))
            {
                MessageBox.Show("Pengarang buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(inputTahun.Text))
            {
                MessageBox.Show("Tahun buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(inputStok.Text))
            {
                MessageBox.Show("Stok buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(inputISBN.Text))
            {
                MessageBox.Show("ISBN buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "UPDATE buku SET judul = @judul, deskripsi = @deskripsi, pengarang = @pengarang, penerbit = @penerbit, tahun = @tahun, isbn = @isbn, stok = @stok, kategori = @kategori WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Parameters.AddWithValue("@judul", inputJudul.Text);
                cmd.Parameters.AddWithValue("@deskripsi", inputDeskripsi.Text);
                cmd.Parameters.AddWithValue("@pengarang", inputPengarang.Text);
                cmd.Parameters.AddWithValue("@penerbit", inputPenerbit.Text);
                cmd.Parameters.AddWithValue("@tahun", inputTahun.Text);
                cmd.Parameters.AddWithValue("@isbn", inputISBN.Text);
                cmd.Parameters.AddWithValue("@stok", inputStok.Text);
                cmd.Parameters.AddWithValue("@kategori", inputKategori.Text);
                cmd.Parameters.AddWithValue("@id", idA);
                int check = cmd.ExecuteNonQuery();

                if (check > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang diperbarui!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Memperbarui data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
