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
    public partial class pengembalian : Form
    {
        public pengembalian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPengembalian check = new cPengembalian();
            check.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uPengembalian uPengembalian = new uPengembalian();
            uPengembalian.Show();
        }
    }
}
