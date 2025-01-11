namespace uas
{
    partial class cPeminjaman
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
            this.dateTimePickerPinjam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nimBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerTenggat = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dateTimePickerPinjam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxBuku);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nimBox);
            this.panel1.Controls.Add(this.dateTimePickerTenggat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(400, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 507);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerPinjam
            // 
            this.dateTimePickerPinjam.Location = new System.Drawing.Point(183, 143);
            this.dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            this.dateTimePickerPinjam.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerPinjam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tgl Pinjam";
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.ItemHeight = 16;
            this.listBoxBuku.Location = new System.Drawing.Point(183, 246);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxBuku.Size = new System.Drawing.Size(243, 132);
            this.listBoxBuku.TabIndex = 13;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubmitButton.Location = new System.Drawing.Point(43, 410);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(387, 39);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 193);
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
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIM";
            // 
            // nimBox
            // 
            this.nimBox.Location = new System.Drawing.Point(183, 98);
            this.nimBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nimBox.Name = "nimBox";
            this.nimBox.Size = new System.Drawing.Size(247, 22);
            this.nimBox.TabIndex = 6;
            this.nimBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePickerTenggat
            // 
            this.dateTimePickerTenggat.Location = new System.Drawing.Point(180, 191);
            this.dateTimePickerTenggat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTenggat.Name = "dateTimePickerTenggat";
            this.dateTimePickerTenggat.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerTenggat.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(31, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 7);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Peminjaman";
            // 
            // cPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 629);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cPeminjaman";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.cPeminjaman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTenggat;
        private System.Windows.Forms.TextBox nimBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox listBoxBuku;
        private System.Windows.Forms.DateTimePicker dateTimePickerPinjam;
        private System.Windows.Forms.Label label2;
    }
}