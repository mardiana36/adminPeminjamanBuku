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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            peminjaman form = new peminjaman();
            form.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool statusPw = false;
        private void showHide_Click(object sender, EventArgs e)
        {
            statusPw = !statusPw;
            
            if (!statusPw)
            {
                inputPassword.PasswordChar = '*';
                showHide.Image = Properties.Resources.icons8_hide_100;
            }
            else
            {
                inputPassword.PasswordChar = '\0';
                showHide.Image = Properties.Resources.icons8_show_100;
            }
        }
    }
}
