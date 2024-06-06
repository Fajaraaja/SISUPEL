namespace SISUPEL.Views
{
    partial class DashboardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KelurahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PendudukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.KelurahanToolStripMenuItem,
            this.TPSToolStripMenuItem,
            this.PendudukToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(157, 605);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(144, 95);
            this.fileToolStripMenuItem.Text = "SISUPEL";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // KelurahanToolStripMenuItem
            // 
            this.KelurahanToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelurahanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.KelurahanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("KelurahanToolStripMenuItem.Image")));
            this.KelurahanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KelurahanToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.KelurahanToolStripMenuItem.Name = "KelurahanToolStripMenuItem";
            this.KelurahanToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.KelurahanToolStripMenuItem.Text = "Kelurahan";
            this.KelurahanToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KelurahanToolStripMenuItem.Click += new System.EventHandler(this.KelurahanToolStripMenuItem_Click);
            // 
            // TPSToolStripMenuItem
            // 
            this.TPSToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.TPSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TPSToolStripMenuItem.Image")));
            this.TPSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TPSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TPSToolStripMenuItem.Name = "TPSToolStripMenuItem";
            this.TPSToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.TPSToolStripMenuItem.Text = "TPS - Lokasi";
            this.TPSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TPSToolStripMenuItem.Click += new System.EventHandler(this.TPSToolStripMenuItem_Click);
            // 
            // PendudukToolStripMenuItem
            // 
            this.PendudukToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendudukToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.PendudukToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PendudukToolStripMenuItem.Image")));
            this.PendudukToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PendudukToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.PendudukToolStripMenuItem.Name = "PendudukToolStripMenuItem";
            this.PendudukToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.PendudukToolStripMenuItem.Text = "Penduduk";
            this.PendudukToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PendudukToolStripMenuItem.Click += new System.EventHandler(this.PendudukToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 550, 0, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(157, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 605);
            this.panel1.TabIndex = 3;
            // 
            // DashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISUPEL - Sistem Informasi Surat Undangan Pemilu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KelurahanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PendudukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}