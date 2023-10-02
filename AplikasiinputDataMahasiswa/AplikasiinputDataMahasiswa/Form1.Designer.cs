namespace AplikasiinputDataMahasiswa
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
            this.Nim = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.Kelas = new System.Windows.Forms.Label();
            this.Nilai = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.DaftarMahasisaw = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.DaftarMahasisaw.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nim
            // 
            this.Nim.AutoSize = true;
            this.Nim.Location = new System.Drawing.Point(15, 28);
            this.Nim.Name = "Nim";
            this.Nim.Size = new System.Drawing.Size(25, 13);
            this.Nim.TabIndex = 0;
            this.Nim.Text = "Nim";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(15, 57);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // Kelas
            // 
            this.Kelas.AutoSize = true;
            this.Kelas.Location = new System.Drawing.Point(15, 83);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(33, 13);
            this.Kelas.TabIndex = 2;
            this.Kelas.Text = "Kelas";
            this.Kelas.Click += new System.EventHandler(this.label3_Click);
            // 
            // Nilai
            // 
            this.Nilai.AutoSize = true;
            this.Nilai.Location = new System.Drawing.Point(15, 109);
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(27, 13);
            this.Nilai.TabIndex = 3;
            this.Nilai.Text = "Nilai";
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(67, 28);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(91, 20);
            this.txtNim.TabIndex = 4;
            this.txtNim.TextChanged += new System.EventHandler(this.txtNim_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(67, 57);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(177, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(67, 83);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(89, 20);
            this.txtKelas.TabIndex = 6;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(67, 109);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(86, 20);
            this.txtNilai.TabIndex = 7;
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 163);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(69, 20);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 20);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DaftarMahasisaw
            // 
            this.DaftarMahasisaw.Controls.Add(this.lvwMahasiswa);
            this.DaftarMahasisaw.Controls.Add(this.btnHapus);
            this.DaftarMahasisaw.Controls.Add(this.btnTampilkanData);
            this.DaftarMahasisaw.Location = new System.Drawing.Point(254, 16);
            this.DaftarMahasisaw.Name = "DaftarMahasisaw";
            this.DaftarMahasisaw.Size = new System.Drawing.Size(359, 286);
            this.DaftarMahasisaw.TabIndex = 10;
            this.DaftarMahasisaw.TabStop = false;
            this.DaftarMahasisaw.Text = "Daftar Mahasiswa";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 49);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(347, 231);
            this.lvwMahasiswa.TabIndex = 2;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(109, 20);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(6, 20);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(97, 23);
            this.btnTampilkanData.TabIndex = 0;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DaftarMahasisaw);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.Nilai);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Nim);
            this.Name = "Form1";
            this.Text = "Nim";
            this.DaftarMahasisaw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nim;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Kelas;
        private System.Windows.Forms.Label Nilai;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox DaftarMahasisaw;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTampilkanData;
    }
}

