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
    public partial class tambahAnggota : Form
    {
        public tambahAnggota()
        {
            InitializeComponent();
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
    }
}
