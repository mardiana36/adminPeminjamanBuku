namespace uas
{
    partial class tambahAnggota
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pilihStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPilihFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previewFile = new System.Windows.Forms.PictureBox();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pilihStatus);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.inputNama);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.inputNim);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnPilihFile);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.previewFile);
            this.panel3.Controls.Add(this.pathFile);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(223, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 796);
            this.panel3.TabIndex = 9;
            // 
            // pilihStatus
            // 
            this.pilihStatus.AllowDrop = true;
            this.pilihStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pilihStatus.Enabled = false;
            this.pilihStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihStatus.FormattingEnabled = true;
            this.pilihStatus.Items.AddRange(new object[] {
            "Aktif"});
            this.pilihStatus.Location = new System.Drawing.Point(340, 579);
            this.pilihStatus.Name = "pilihStatus";
            this.pilihStatus.Size = new System.Drawing.Size(496, 32);
            this.pilihStatus.TabIndex = 19;
            this.pilihStatus.Tag = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputNama
            // 
            this.inputNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNama.Location = new System.Drawing.Point(340, 520);
            this.inputNama.Multiline = true;
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(496, 33);
            this.inputNama.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nama :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputNim
            // 
            this.inputNim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNim.Location = new System.Drawing.Point(340, 461);
            this.inputNim.Multiline = true;
            this.inputNim.Name = "inputNim";
            this.inputNim.Size = new System.Drawing.Size(496, 33);
            this.inputNim.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIM :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPilihFile
            // 
            this.btnPilihFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPilihFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPilihFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilihFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPilihFile.Location = new System.Drawing.Point(716, 398);
            this.btnPilihFile.Name = "btnPilihFile";
            this.btnPilihFile.Size = new System.Drawing.Size(120, 35);
            this.btnPilihFile.TabIndex = 13;
            this.btnPilihFile.Text = "Pilih File";
            this.btnPilihFile.UseVisualStyleBackColor = false;
            this.btnPilihFile.Click += new System.EventHandler(this.btnPilihFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Foto KTM :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // previewFile
            // 
            this.previewFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previewFile.BackColor = System.Drawing.Color.Transparent;
            this.previewFile.BackgroundImage = global::uas.Properties.Resources.question;
            this.previewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewFile.Location = new System.Drawing.Point(340, 222);
            this.previewFile.Name = "previewFile";
            this.previewFile.Size = new System.Drawing.Size(496, 170);
            this.previewFile.TabIndex = 11;
            this.previewFile.TabStop = false;
            // 
            // pathFile
            // 
            this.pathFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathFile.Location = new System.Drawing.Point(340, 400);
            this.pathFile.Multiline = true;
            this.pathFile.Name = "pathFile";
            this.pathFile.ReadOnly = true;
            this.pathFile.Size = new System.Drawing.Size(370, 33);
            this.pathFile.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(84, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 700);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Anggota";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambah.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTambah.Location = new System.Drawing.Point(87, 604);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(671, 51);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 886);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tambahAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 886);
            this.Controls.Add(this.panel1);
            this.Name = "tambahAnggota";
            this.Text = "tambahAnggota";
            this.Load += new System.EventHandler(this.tambahAnggota_Load);
            this.Shown += new System.EventHandler(this.tambahAnggota_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox pilihStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPilihFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox previewFile;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTambah;
    }
}