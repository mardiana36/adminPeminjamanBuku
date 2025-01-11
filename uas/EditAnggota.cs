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
    public partial class EditAnggota : Form
    {
        private int idA;
        private SqlConnection conn;
        private string directoryFile;
        private bool checkImgDB = false;
        public EditAnggota()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }
        public void Read(int id)
        {
            this.idA = id;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void EditAnggota_Shown(object sender, EventArgs e)
        {
            if (idA > 0)
            {
                checkImgDB = false;
                string query = "SELECT * FROM anggota WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idA);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        string path = Path.Combine(Application.StartupPath, "..", "..", "img", reader["fotoKTM"].ToString());
                        Image imgKtm = Image.FromFile(path);
                        Console.WriteLine("add data...");
                        previewFile.Image = imgKtm;
                        fileName.Text = reader["fotoKTM"].ToString();
                        inputNim.Text = reader["nim"].ToString();
                        inputNama.Text = reader["nama"].ToString();
                        selectStatus.Text = reader["status"].ToString();
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

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                checkImgDB = true;
                previewFile.Image = Image.FromFile(openFileDialog.FileName);
                fileName.Text = openFileDialog.SafeFileName;
                directoryFile = openFileDialog.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(fileName.Text))
                {
                    MessageBox.Show("Pilih gambar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(inputNim.Text))
                {
                    MessageBox.Show("NIM Tidak Boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(inputNama.Text))
                {
                    MessageBox.Show("Nama Tidak Boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else if (selectStatus.SelectedItem == null)
                {
                    MessageBox.Show("Status Tidak Boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;
                if (checkImgDB == true)
                {
                    string sourceFile = directoryFile;
                    string extension = Path.GetExtension(sourceFile);
                    string newFileName = Guid.NewGuid().ToString() + extension;
                    string destionationPath = Path.Combine(Application.StartupPath, "..", "..", "img", newFileName);

                    if (!Directory.Exists(Path.Combine(Application.StartupPath, "..", "..", "img")))
                    {
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "..", "..", "img"));
                    }
                    File.Copy(sourceFile, destionationPath, true);

                    query = "UPDATE anggota SET nama = @nama, nim = @nim, fotoKTM = @fotoKTM, status = @status WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@nama", inputNama.Text);
                        cmd.Parameters.AddWithValue("@nim", inputNim.Text);
                        cmd.Parameters.AddWithValue("@fotoKTM", newFileName);
                        cmd.Parameters.AddWithValue("@status", selectStatus.SelectedItem.ToString());
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
                    catch (Exception ex) {
                    MessageBox.Show($"Gagal Memperbarui data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                   

                }
                else
                {
                    query = "UPDATE anggota SET nama = @nama, nim = @nim, status = @status WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@nama", inputNama.Text);
                    cmd.Parameters.AddWithValue("@nim", inputNim.Text);
                    cmd.Parameters.AddWithValue("@status", selectStatus.SelectedItem.ToString());
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
}
