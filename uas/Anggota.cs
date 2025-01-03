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
    public partial class Anggota : Form
    {
        public Anggota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getConnection connection = new getConnection();
            SqlConnection conn = connection.GetDatabaseConnection();

            if (conn != null)
            {
                MessageBox.Show("koneksi berhasil", "suksess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
        }
    }
}
