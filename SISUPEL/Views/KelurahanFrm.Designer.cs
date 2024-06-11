namespace SISUPEL.Views
{
    partial class KelurahanFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelurahanFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.nakelTxt = new System.Windows.Forms.TextBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodekelTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kelurahanDgv = new System.Windows.Forms.DataGridView();
            this.kode_kelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelurahanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.searchTxt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.hapusBtn);
            this.panel2.Controls.Add(this.nakelTxt);
            this.panel2.Controls.Add(this.simpanBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.kodekelTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 243);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cari Data";
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(247, 191);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(569, 30);
            this.searchTxt.TabIndex = 28;
            this.searchTxt.Click += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelBtn.Image = global::SISUPEL.Properties.Resources.Close;
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(349, 123);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 41);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Batal";
            this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hapusBtn.Image = global::SISUPEL.Properties.Resources.Trash;
            this.hapusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapusBtn.Location = new System.Drawing.Point(480, 123);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(129, 41);
            this.hapusBtn.TabIndex = 25;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // nakelTxt
            // 
            this.nakelTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nakelTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nakelTxt.Font = new System.Drawing.Font("Poppins", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nakelTxt.Location = new System.Drawing.Point(200, 69);
            this.nakelTxt.Multiline = true;
            this.nakelTxt.Name = "nakelTxt";
            this.nakelTxt.Size = new System.Drawing.Size(409, 30);
            this.nakelTxt.TabIndex = 24;
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Poppins Medium", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.simpanBtn.Image = global::SISUPEL.Properties.Resources.Save;
            this.simpanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpanBtn.Location = new System.Drawing.Point(200, 123);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(143, 41);
            this.simpanBtn.TabIndex = 23;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nama Kelurahan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kode Kelurahan";
            // 
            // kodekelTxt
            // 
            this.kodekelTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kodekelTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kodekelTxt.Enabled = false;
            this.kodekelTxt.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodekelTxt.Location = new System.Drawing.Point(200, 22);
            this.kodekelTxt.Multiline = true;
            this.kodekelTxt.Name = "kodekelTxt";
            this.kodekelTxt.Size = new System.Drawing.Size(278, 30);
            this.kodekelTxt.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 51);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(34, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 1);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Komisi Pemilihan Umum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hak Cipta © 2022 ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kelurahanDgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(845, 252);
            this.panel4.TabIndex = 22;
            // 
            // kelurahanDgv
            // 
            this.kelurahanDgv.AllowUserToAddRows = false;
            this.kelurahanDgv.AllowUserToDeleteRows = false;
            this.kelurahanDgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.kelurahanDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kelurahanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelurahanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_kelurahan,
            this.nama_kelurahan});
            this.kelurahanDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kelurahanDgv.Location = new System.Drawing.Point(0, 0);
            this.kelurahanDgv.Name = "kelurahanDgv";
            this.kelurahanDgv.ReadOnly = true;
            this.kelurahanDgv.RowHeadersWidth = 51;
            this.kelurahanDgv.RowTemplate.Height = 24;
            this.kelurahanDgv.Size = new System.Drawing.Size(845, 252);
            this.kelurahanDgv.TabIndex = 7;
            this.kelurahanDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kelurahanDgv_CellClick);
            // 
            // kode_kelurahan
            // 
            this.kode_kelurahan.DataPropertyName = "kode_kelurahan";
            this.kode_kelurahan.HeaderText = "Kode Kelurahan";
            this.kode_kelurahan.MinimumWidth = 6;
            this.kode_kelurahan.Name = "kode_kelurahan";
            this.kode_kelurahan.ReadOnly = true;
            this.kode_kelurahan.Width = 460;
            // 
            // nama_kelurahan
            // 
            this.nama_kelurahan.DataPropertyName = "nama_kelurahan";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kelurahan.DefaultCellStyle = dataGridViewCellStyle1;
            this.nama_kelurahan.HeaderText = "Nama Kelurahan";
            this.nama_kelurahan.MinimumWidth = 6;
            this.nama_kelurahan.Name = "nama_kelurahan";
            this.nama_kelurahan.ReadOnly = true;
            this.nama_kelurahan.Width = 900;
            // 
            // KelurahanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(845, 546);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KelurahanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KelurahanFrm";
            this.Load += new System.EventHandler(this.KelurahanFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kelurahanDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.TextBox nakelTxt;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodekelTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView kelurahanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_kelurahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kelurahan;
    }
}