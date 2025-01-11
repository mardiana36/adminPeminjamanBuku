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
    public partial class uPengembalian : Form
    {
        private int idPinjam;
        public uPengembalian(int idPinjam,int denda,string status)
        {
            InitializeComponent();

            dendaBox.Text = denda.ToString();
            statusBox.Text = status;
            this.idPinjam = idPinjam;
        }

        private void UpdatePengembalian()
        {
            string status = statusBox.Text;
            string dendaText = dendaBox.Text;

           
            if (!int.TryParse(dendaText, out int updateDenda))
            {
                MessageBox.Show("Denda harus berupa angka.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {
                if (conn == null) return;

                try
                {
                    string query = @"
                    UPDATE pengembalian 
                    SET status = @status, denda = @denda 
                    WHERE id_pinjam = @idPinjam;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@denda", updateDenda);
                        cmd.Parameters.AddWithValue("@idPinjam", idPinjam); 

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data pengembalian berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data pengembalian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat memperbarui data pengembalian: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UpdatePengembalian();
            
        }

    }
}
