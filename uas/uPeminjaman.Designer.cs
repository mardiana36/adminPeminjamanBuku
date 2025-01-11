namespace uas
{
    partial class uPeminjaman
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNIM = new System.Windows.Forms.TextBox();
            this.dateTimePickerTenggat = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerPinjam = new System.Windows.Forms.DateTimePicker();
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxBukuDipinjam = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.listBoxBukuDipinjam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBoxBuku);
            this.panel1.Controls.Add(this.dateTimePickerPinjam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textNIM);
            this.panel1.Controls.Add(this.dateTimePickerTenggat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 564);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(43, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buku Baru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tgl Tengat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIM";
            // 
            // textNIM
            // 
            this.textNIM.Location = new System.Drawing.Point(183, 102);
            this.textNIM.Name = "textNIM";
            this.textNIM.Size = new System.Drawing.Size(247, 22);
            this.textNIM.TabIndex = 6;
            this.textNIM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePickerTenggat
            // 
            this.dateTimePickerTenggat.Location = new System.Drawing.Point(183, 190);
            this.dateTimePickerTenggat.Name = "dateTimePickerTenggat";
            this.dateTimePickerTenggat.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerTenggat.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(31, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 8);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tgl Pinjam";
            // 
            // dateTimePickerPinjam
            // 
            this.dateTimePickerPinjam.Location = new System.Drawing.Point(183, 145);
            this.dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            this.dateTimePickerPinjam.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerPinjam.TabIndex = 16;
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.ItemHeight = 16;
            this.listBoxBuku.Location = new System.Drawing.Point(183, 350);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.Size = new System.Drawing.Size(247, 116);
            this.listBoxBuku.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Buku Dipinjam";
            // 
            // listBoxBukuDipinjam
            // 
            this.listBoxBukuDipinjam.FormattingEnabled = true;
            this.listBoxBukuDipinjam.ItemHeight = 16;
            this.listBoxBukuDipinjam.Location = new System.Drawing.Point(183, 228);
            this.listBoxBukuDipinjam.Name = "listBoxBukuDipinjam";
            this.listBoxBukuDipinjam.Size = new System.Drawing.Size(247, 116);
            this.listBoxBukuDipinjam.TabIndex = 19;
            // 
            // uPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 633);
            this.Controls.Add(this.panel1);
            this.Name = "uPeminjaman";
            this.Text = "uPeminjaman";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNIM;
        private System.Windows.Forms.DateTimePicker dateTimePickerTenggat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBuku;
        private System.Windows.Forms.DateTimePicker dateTimePickerPinjam;
        private System.Windows.Forms.ListBox listBoxBukuDipinjam;
        private System.Windows.Forms.Label label5;
    }
}