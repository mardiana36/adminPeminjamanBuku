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
    public partial class tambahAnggota : Form
    {
        private SqlConnection conn;
        private string directoryFile;
        public tambahAnggota()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota a = new Anggota();
            a.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buku buku = new buku(); 
            buku.Show();
            this.Close();

        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengembalian pengembalian = new pengembalian();
            pengembalian.Show();
            this.Close();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peminjaman peminjaman = new peminjaman();
            peminjaman.Show();
            this.Close();  
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                previewFile.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                pathFile.Text = openFileDialog.SafeFileName;
                directoryFile = openFileDialog.FileName;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathFile.Text))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (string.IsNullOrEmpty(inputNim.Text))
            {
                MessageBox.Show("NIM Tidak Boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(inputNama.Text))
            {
                MessageBox.Show("Nama Tidak Boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string sourceFile = directoryFile;
            string extension = Path.GetExtension(sourceFile);
            string newFileName = Guid.NewGuid().ToString() + extension;
            string destionationPath = Path.Combine(Application.StartupPath,"..","..", "img", newFileName);

            if (!Directory.Exists(Path.Combine(Application.StartupPath, "..", "..", "img")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "..", "..", "img"));
            }
            File.Copy(sourceFile, destionationPath, true);

            string query = "INSERT INTO anggota (nama, nim, fotoKTM, status) VALUES (@nama, @nim, @fotoKTM, @status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            try {
                cmd.Parameters.AddWithValue("@nama", inputNama.Text);
                cmd.Parameters.AddWithValue("@nim", inputNim.Text);
                cmd.Parameters.AddWithValue("@fotoKTM", newFileName);
                cmd.Parameters.AddWithValue("@status", pilihStatus.SelectedItem.ToString());
                int check = cmd.ExecuteNonQuery();

                if (check > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Anggota anggota = new Anggota();
                    anggota.Show();
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

        private void tambahAnggota_Shown(object sender, EventArgs e)
        {
            pilihStatus.Text = "Aktif";
        }
    }
}
