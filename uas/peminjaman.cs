﻿using System;
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

        private void peminjaman_Load(object sender, EventArgs e)
        {

        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengembalian pg = new pengembalian();
            pg.Show();
            this.Close();
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota ag = new Anggota();
            ag.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buku bk = new buku();
            bk.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is cPeminjaman)
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }
    }
}
