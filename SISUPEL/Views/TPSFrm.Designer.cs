namespace SISUPEL.Views
{
    partial class TPSFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TPSFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.NakelCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.natpsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodtpsTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TPSDgv = new System.Windows.Forms.DataGridView();
            this.kode_tps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_tps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPSDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.hapusBtn);
            this.panel1.Controls.Add(this.simpanBtn);
            this.panel1.Controls.Add(this.NakelCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.natpsTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kodtpsTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 267);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 77;
            this.label4.Text = "Cari Data";
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(209, 215);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(594, 30);
            this.searchTxt.TabIndex = 76;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelBtn.Location = new System.Drawing.Point(319, 156);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 41);
            this.CancelBtn.TabIndex = 74;
            this.CancelBtn.Text = "Batal";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hapusBtn.Location = new System.Drawing.Point(450, 156);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(129, 41);
            this.hapusBtn.TabIndex = 73;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.simpanBtn.Location = new System.Drawing.Point(170, 156);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(143, 41);
            this.simpanBtn.TabIndex = 72;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            // 
            // NakelCmb
            // 
            this.NakelCmb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NakelCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NakelCmb.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NakelCmb.FormattingEnabled = true;
            this.NakelCmb.Location = new System.Drawing.Point(170, 110);
            this.NakelCmb.Name = "NakelCmb";
            this.NakelCmb.Size = new System.Drawing.Size(409, 31);
            this.NakelCmb.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 70;
            this.label3.Text = "Lokasi TPS";
            // 
            // natpsTxt
            // 
            this.natpsTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.natpsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.natpsTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpsTxt.Location = new System.Drawing.Point(170, 65);
            this.natpsTxt.Multiline = true;
            this.natpsTxt.Name = "natpsTxt";
            this.natpsTxt.Size = new System.Drawing.Size(409, 30);
            this.natpsTxt.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nama TPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 67;
            this.label1.Text = "Kode TPS";
            // 
            // kodtpsTxt
            // 
            this.kodtpsTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kodtpsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kodtpsTxt.Enabled = false;
            this.kodtpsTxt.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodtpsTxt.Location = new System.Drawing.Point(170, 18);
            this.kodtpsTxt.Multiline = true;
            this.kodtpsTxt.Name = "kodtpsTxt";
            this.kodtpsTxt.Size = new System.Drawing.Size(278, 30);
            this.kodtpsTxt.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(41, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 1);
            this.panel4.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(638, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Komisi Pemilihan Umum";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Hak Cipta © 2022 ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TPSDgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 255);
            this.panel3.TabIndex = 2;
            // 
            // TPSDgv
            // 
            this.TPSDgv.AllowUserToAddRows = false;
            this.TPSDgv.AllowUserToDeleteRows = false;
            this.TPSDgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.TPSDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPSDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TPSDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_tps,
            this.nama_tps,
            this.nama_kelurahan});
            this.TPSDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPSDgv.Location = new System.Drawing.Point(0, 0);
            this.TPSDgv.Name = "TPSDgv";
            this.TPSDgv.ReadOnly = true;
            this.TPSDgv.RowHeadersWidth = 51;
            this.TPSDgv.RowTemplate.Height = 24;
            this.TPSDgv.Size = new System.Drawing.Size(845, 255);
            this.TPSDgv.TabIndex = 73;
            // 
            // kode_tps
            // 
            this.kode_tps.DataPropertyName = "kode_tps";
            this.kode_tps.HeaderText = "Kode TPS";
            this.kode_tps.MinimumWidth = 6;
            this.kode_tps.Name = "kode_tps";
            this.kode_tps.ReadOnly = true;
            this.kode_tps.Width = 300;
            // 
            // nama_tps
            // 
            this.nama_tps.DataPropertyName = "nama_tps";
            this.nama_tps.HeaderText = "Nama TPS";
            this.nama_tps.MinimumWidth = 6;
            this.nama_tps.Name = "nama_tps";
            this.nama_tps.ReadOnly = true;
            this.nama_tps.Width = 500;
            // 
            // nama_kelurahan
            // 
            this.nama_kelurahan.DataPropertyName = "nama_kelurahan";
            this.nama_kelurahan.HeaderText = "Lokasi TPS (Kelurahan)";
            this.nama_kelurahan.MinimumWidth = 6;
            this.nama_kelurahan.Name = "nama_kelurahan";
            this.nama_kelurahan.ReadOnly = true;
            this.nama_kelurahan.Width = 550;
            // 
            // TPSFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(845, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TPSFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPSFrm";
            this.Load += new System.EventHandler(this.TPSFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TPSDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.ComboBox NakelCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox natpsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodtpsTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView TPSDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_tps;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_tps;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kelurahan;
    }
}