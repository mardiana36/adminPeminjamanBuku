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
    public partial class tambahBuku : Form
    {
        private SqlConnection conn;
        public tambahBuku()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }


        private void button2_Click(object sender, EventArgs e)
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
            }
            else if (string.IsNullOrEmpty(inputPengarang.Text))
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
            }
            else if (string.IsNullOrEmpty(inputISBN.Text))
            {
                MessageBox.Show("ISBN buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO buku (judul, deskripsi, pengarang, penerbit, tahun, isbn, stok, kategori) VALUES (@judul, @deskripsi, @pengarang, @penerbit, @tahun, @isbn, @stok, @kategori)";
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
                int check = cmd.ExecuteNonQuery();

                if (check > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang ditambahkan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Menambah data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
