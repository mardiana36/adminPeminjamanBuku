using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas
{
    public partial class EditAnggota : Form
    {
        private int idA;
        public EditAnggota()
        {
            InitializeComponent();
        }
        public void Read(int id)
        {
            this.idA = id;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void EditAnggota_Shown(object sender, EventArgs e)
        {
            MessageBox.Show($"idnya ={idA}", "Tes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
