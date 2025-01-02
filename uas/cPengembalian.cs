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
    public partial class cPengembalian : Form
    {
        public cPengembalian()
        {
            InitializeComponent();
        }

        private void cPengembalian_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPengembalian2 cPengembalian = new cPengembalian2();
            cPengembalian.Show();
            this.Close();
        }
    }
}
