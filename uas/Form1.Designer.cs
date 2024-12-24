namespace uas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 762);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnRegistrasi);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inputUsername);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(133, 123);
            this.panel2.MaximumSize = new System.Drawing.Size(400, 500);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(400, 500);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrasi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrasi.Location = new System.Drawing.Point(32, 338);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(340, 42);
            this.btnRegistrasi.TabIndex = 9;
            this.btnRegistrasi.Text = "LOGIN";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(32, 437);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(340, 5);
            this.panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(32, 247);
            this.textBox1.MaximumSize = new System.Drawing.Size(4, 40);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 40);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(340, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // inputUsername
            // 
            this.inputUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUsername.Location = new System.Drawing.Point(32, 156);
            this.inputUsername.MaximumSize = new System.Drawing.Size(4, 40);
            this.inputUsername.MinimumSize = new System.Drawing.Size(100, 40);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(100, 40);
            this.inputUsername.TabIndex = 4;
            this.inputUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsername.Location = new System.Drawing.Point(32, 124);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(340, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username / Email";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(32, 85);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(340, 5);
            this.panel3.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(0, 20);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(400, 66);
            this.Login.TabIndex = 1;
            this.Login.Text = "LOGIN";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(677, 762);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

