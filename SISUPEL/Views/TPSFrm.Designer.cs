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
            this.natpsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodtpsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NakelCmb = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TPSDgv = new System.Windows.Forms.DataGridView();
            this.kode_tps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_tps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TPSDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // natpsTxt
            // 
            this.natpsTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.natpsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.natpsTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpsTxt.Location = new System.Drawing.Point(167, 69);
            this.natpsTxt.Multiline = true;
            this.natpsTxt.Name = "natpsTxt";
            this.natpsTxt.Size = new System.Drawing.Size(409, 30);
            this.natpsTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama TPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kode TPS";
            // 
            // kodtpsTxt
            // 
            this.kodtpsTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kodtpsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kodtpsTxt.Enabled = false;
            this.kodtpsTxt.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodtpsTxt.Location = new System.Drawing.Point(167, 22);
            this.kodtpsTxt.Multiline = true;
            this.kodtpsTxt.Name = "kodtpsTxt";
            this.kodtpsTxt.Size = new System.Drawing.Size(278, 30);
            this.kodtpsTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lokasi TPS";
            // 
            // NakelCmb
            // 
            this.NakelCmb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NakelCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NakelCmb.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NakelCmb.FormattingEnabled = true;
            this.NakelCmb.Location = new System.Drawing.Point(167, 114);
            this.NakelCmb.Name = "NakelCmb";
            this.NakelCmb.Size = new System.Drawing.Size(409, 31);
            this.NakelCmb.TabIndex = 20;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelBtn.Location = new System.Drawing.Point(316, 160);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 41);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "Batal";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hapusBtn.Location = new System.Drawing.Point(447, 160);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(129, 41);
            this.hapusBtn.TabIndex = 22;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.simpanBtn.Location = new System.Drawing.Point(167, 160);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(143, 41);
            this.simpanBtn.TabIndex = 21;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Komisi Pemilihan Umum";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hak Cipta © 2022 ";
            // 
            // TPSDgv
            // 
            this.TPSDgv.AllowUserToAddRows = false;
            this.TPSDgv.AllowUserToDeleteRows = false;
            this.TPSDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TPSDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPSDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TPSDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_tps,
            this.nama_tps,
            this.nama_kelurahan});
            this.TPSDgv.Location = new System.Drawing.Point(47, 264);
            this.TPSDgv.Name = "TPSDgv";
            this.TPSDgv.ReadOnly = true;
            this.TPSDgv.RowHeadersWidth = 51;
            this.TPSDgv.RowTemplate.Height = 24;
            this.TPSDgv.Size = new System.Drawing.Size(753, 221);
            this.TPSDgv.TabIndex = 26;
            this.TPSDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TPSDgv_CellClick);
            // 
            // kode_tps
            // 
            this.kode_tps.DataPropertyName = "kode_tps";
            this.kode_tps.HeaderText = "Kode TPS";
            this.kode_tps.MinimumWidth = 6;
            this.kode_tps.Name = "kode_tps";
            this.kode_tps.ReadOnly = true;
            this.kode_tps.Width = 125;
            // 
            // nama_tps
            // 
            this.nama_tps.DataPropertyName = "nama_tps";
            this.nama_tps.HeaderText = "Nama TPS";
            this.nama_tps.MinimumWidth = 6;
            this.nama_tps.Name = "nama_tps";
            this.nama_tps.ReadOnly = true;
            this.nama_tps.Width = 125;
            // 
            // nama_kelurahan
            // 
            this.nama_kelurahan.DataPropertyName = "nama_kelurahan";
            this.nama_kelurahan.HeaderText = "Lokasi TPS (Kelurahan)";
            this.nama_kelurahan.MinimumWidth = 6;
            this.nama_kelurahan.Name = "nama_kelurahan";
            this.nama_kelurahan.ReadOnly = true;
            this.nama_kelurahan.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(47, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 1);
            this.panel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cari Data";
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(206, 219);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(594, 30);
            this.searchTxt.TabIndex = 29;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(625, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // TPSFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(845, 546);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TPSDgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.NakelCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.natpsTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodtpsTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TPSFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TPSFrm";
            this.Load += new System.EventHandler(this.TPSFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TPSDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox natpsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodtpsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NakelCmb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TPSDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_tps;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_tps;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kelurahan;
    }
}