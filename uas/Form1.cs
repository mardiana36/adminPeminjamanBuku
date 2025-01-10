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
using BCrypt.Net;

namespace uas
{
    public partial class Form1 : Form
    {
        private bool statusPw = false;
        private bool statusPwR = false;
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            getConnection connection = new getConnection();
            conn = connection.GetDatabaseConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string hashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool verifiyPassword(string password, string hasdPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password,hasdPassword);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void showHide_Click(object sender, EventArgs e)
        {
            statusPw = !statusPw;
            
            if (!statusPw)
            {
                inputPasswordL.PasswordChar = '*';
                showHide.Image = Properties.Resources.icons8_hide_100;
            }
            else
            {
                inputPasswordL.PasswordChar = '\0';
                showHide.Image = Properties.Resources.icons8_show_100;
            }
        }

        private void inputEmailL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT username, email, password FROM userL";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader(); 
            try
            {
                while (reader.Read()) {
                    if ((inputEmailL.Text == reader["username"].ToString() || inputEmailL.Text == reader["email"].ToString()) && verifiyPassword(inputPasswordL.Text, reader["password"].ToString()) == true)
                    {
                        Anggota anggota = new Anggota();
                        Properties.Settings.Default.username =reader["username"].ToString();
                        Properties.Settings.Default.email =reader["email"].ToString();
                        Properties.Settings.Default.isLogin =true;
                        MessageBox.Show("Login Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        anggota.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Username/Email/Password Salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error menambah data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { reader.Close(); }

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            PanelRegis.Visible = false;
            inputUsernameR.Text = null;
            inputEmailR.Text = null;
            inputPasswordR.Text = null;

            btnL.BackColor = SystemColors.MenuHighlight;
            btnL.ForeColor = SystemColors.Window;
            btnR.BackColor = SystemColors.Window;
            btnR.ForeColor = SystemColors.MenuHighlight;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = false;
            PanelRegis.Visible = true;
            inputEmailL.Text = null;
            inputPasswordL.Text = null;

            btnL.BackColor = SystemColors.Window;
            btnL.ForeColor = SystemColors.MenuHighlight;
            btnR.BackColor = SystemColors.MenuHighlight;
            btnR.ForeColor = SystemColors.Window;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            statusPwR = !statusPwR;

            if (!statusPwR)
            {
                inputPasswordR.PasswordChar = '*';
                showHideR.Image = Properties.Resources.icons8_hide_100;
            }
            else
            {
                inputPasswordR.PasswordChar = '\0';
                showHideR.Image = Properties.Resources.icons8_show_100;
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO userL (username,email,password,role) VALUES (@username, @email, @password, @role)";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                string password = hashPassword(inputPasswordR.Text);
                cmd.Parameters.AddWithValue("@username", inputUsernameR.Text);
                cmd.Parameters.AddWithValue("@email", inputEmailR.Text);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", 1);
                int check = cmd.ExecuteNonQuery();

                if (check > 0)
                {
                    MessageBox.Show("Registrasi Berhasil Silahkan Login !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    btnL_Click(this, new EventArgs());
                } else
                {
                    MessageBox.Show("Registrasi Gagal Silahkan Ualangi !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Gagal menambah data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            PanelRegis.Visible = false;
        }
    }
}
