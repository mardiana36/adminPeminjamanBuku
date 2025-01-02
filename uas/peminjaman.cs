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
    public partial class peminjaman : Form
    {
        public peminjaman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPeminjaman pinjam = new cPeminjaman();
            pinjam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uPeminjaman update = new uPeminjaman();
            update.Show();
        }
    }
}
