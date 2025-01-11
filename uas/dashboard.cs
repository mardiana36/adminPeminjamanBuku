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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            getConnection connection = new getConnection();
            using (SqlConnection conn = connection.GetDatabaseConnection())
            {

                string peminjamanQuery = "SELECT COUNT(*) FROM peminjaman";
                using (SqlCommand cmd = new SqlCommand(peminjamanQuery, conn))
                {
                    int peminjamanCount = (int)cmd.ExecuteScalar();
                    labelPeminjaman.Text = peminjamanCount.ToString();
                }

                
                string pengembalianQuery = "SELECT COUNT(*) FROM pengembalian";
                using (SqlCommand cmd = new SqlCommand(pengembalianQuery, conn))
                {
                    int pengembalianCount = (int)cmd.ExecuteScalar();
                    labelPengembalian.Text = pengembalianCount.ToString();
                }

                
                string bukuQuery = "SELECT COUNT(*) FROM buku";
                using (SqlCommand cmd = new SqlCommand(bukuQuery, conn))
                {
                    int bukuCount = (int)cmd.ExecuteScalar();
                    labelBuku.Text = bukuCount.ToString();
                }

                
                string anggotaQuery = "SELECT COUNT(*) FROM anggota";
                using (SqlCommand cmd = new SqlCommand(anggotaQuery, conn))
                {
                    int anggotaCount = (int)cmd.ExecuteScalar();
                    labelAnggota.Text = anggotaCount.ToString();
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peminjaman peminjaman = new peminjaman();
            peminjaman.Show();
            this.Close();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengembalian pengembalian = new pengembalian();
            pengembalian.Show();
            this.Close();
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota anggota = new Anggota();
            anggota.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buku buku = new buku();
            buku.Show();
            this.Close();
        }
    }
}
