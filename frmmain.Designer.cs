namespace sotietkiem99
{
    partial class frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mndanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnchucvu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnkyhan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dỊCHVỤToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsotietkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnbaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltenhienthi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHỐNGToolStripMenuItem,
            this.mndanhmuc,
            this.dỊCHVỤToolStripMenuItem,
            this.mnbaocao,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 56);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHOÁTToolStripMenuItem,
            this.mnlogin});
            this.hỆTHỐNGToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hỆTHỐNGToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources._1124957994_1992;
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(179, 52);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources._500px_Crystal_Clear_action_exit1;
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            this.tHOÁTToolStripMenuItem.Click += new System.EventHandler(this.tHOÁTToolStripMenuItem_Click);
            // 
            // mnlogin
            // 
            this.mnlogin.BackgroundImage = global::sotietkiem99.Properties.Resources._500px_Crystal_Clear_action_exit_svg;
            this.mnlogin.Image = global::sotietkiem99.Properties.Resources._1124959648_2040;
            this.mnlogin.Name = "mnlogin";
            this.mnlogin.Size = new System.Drawing.Size(252, 54);
            this.mnlogin.Text = "Logout";
            this.mnlogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mndanhmuc
            // 
            this.mndanhmuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mndanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnchucvu,
            this.toolStripSeparator1,
            this.mnkyhan,
            this.toolStripSeparator2,
            this.mnkhachhang,
            this.mnnhanvien,
            this.toolStripSeparator4});
            this.mndanhmuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mndanhmuc.Image = global::sotietkiem99.Properties.Resources._949_implementations_view;
            this.mndanhmuc.Name = "mndanhmuc";
            this.mndanhmuc.Size = new System.Drawing.Size(275, 52);
            this.mndanhmuc.Text = "QUẢN LÝ DANH MỤC";
            this.mndanhmuc.Click += new System.EventHandler(this.mndanhmuc_Click);
            // 
            // mnchucvu
            // 
            this.mnchucvu.Name = "mnchucvu";
            this.mnchucvu.Size = new System.Drawing.Size(325, 28);
            this.mnchucvu.Text = "QUẢN LÝ CHỨC VỤ";
            this.mnchucvu.Click += new System.EventHandler(this.mnchucvu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(322, 6);
            // 
            // mnkyhan
            // 
            this.mnkyhan.Image = global::sotietkiem99.Properties.Resources._1124959648_20218;
            this.mnkyhan.Name = "mnkyhan";
            this.mnkyhan.Size = new System.Drawing.Size(325, 28);
            this.mnkyhan.Text = "QUẢN LÝ KỲ HẠN";
            this.mnkyhan.Click += new System.EventHandler(this.mnkyhan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(322, 6);
            // 
            // mnkhachhang
            // 
            this.mnkhachhang.Image = global::sotietkiem99.Properties.Resources._5;
            this.mnkhachhang.Name = "mnkhachhang";
            this.mnkhachhang.Size = new System.Drawing.Size(325, 28);
            this.mnkhachhang.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.mnkhachhang.Click += new System.EventHandler(this.mnkhachhang_Click);
            // 
            // mnnhanvien
            // 
            this.mnnhanvien.Image = global::sotietkiem99.Properties.Resources._1124959648_20161;
            this.mnnhanvien.Name = "mnnhanvien";
            this.mnnhanvien.Size = new System.Drawing.Size(325, 28);
            this.mnnhanvien.Text = "QL NHÂN VIÊN";
            this.mnnhanvien.Click += new System.EventHandler(this.mnnhanvien_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(322, 6);
            // 
            // dỊCHVỤToolStripMenuItem
            // 
            this.dỊCHVỤToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dỊCHVỤToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsotietkiem});
            this.dỊCHVỤToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dỊCHVỤToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dỊCHVỤToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources._1124959648_20149;
            this.dỊCHVỤToolStripMenuItem.Name = "dỊCHVỤToolStripMenuItem";
            this.dỊCHVỤToolStripMenuItem.Size = new System.Drawing.Size(155, 52);
            this.dỊCHVỤToolStripMenuItem.Text = "DỊCH VỤ";
            this.dỊCHVỤToolStripMenuItem.Click += new System.EventHandler(this.dỊCHVỤToolStripMenuItem_Click);
            // 
            // mnsotietkiem
            // 
            this.mnsotietkiem.Image = global::sotietkiem99.Properties.Resources._1124972299_2366;
            this.mnsotietkiem.Name = "mnsotietkiem";
            this.mnsotietkiem.Size = new System.Drawing.Size(290, 54);
            this.mnsotietkiem.Text = "QL SỔ TIẾT KIỆM";
            this.mnsotietkiem.Click += new System.EventHandler(this.mnsotietkiem_Click);
            // 
            // mnbaocao
            // 
            this.mnbaocao.BackColor = System.Drawing.Color.Green;
            this.mnbaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnbaocao.Image = global::sotietkiem99.Properties.Resources._1124959648_2073;
            this.mnbaocao.Name = "mnbaocao";
            this.mnbaocao.Size = new System.Drawing.Size(164, 52);
            this.mnbaocao.Text = "BÁO CÁO";
            this.mnbaocao.Click += new System.EventHandler(this.mnbaocao_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupAboutToolStripMenuItem,
            this.appAboutToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBOUTToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources.about;
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(142, 52);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // groupAboutToolStripMenuItem
            // 
            this.groupAboutToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources._1124959648_20161;
            this.groupAboutToolStripMenuItem.Name = "groupAboutToolStripMenuItem";
            this.groupAboutToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.groupAboutToolStripMenuItem.Text = "Group About";
            this.groupAboutToolStripMenuItem.Click += new System.EventHandler(this.groupAboutToolStripMenuItem_Click);
            // 
            // appAboutToolStripMenuItem
            // 
            this.appAboutToolStripMenuItem.Image = global::sotietkiem99.Properties.Resources.app;
            this.appAboutToolStripMenuItem.Name = "appAboutToolStripMenuItem";
            this.appAboutToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.appAboutToolStripMenuItem.Text = "App About";
            this.appAboutToolStripMenuItem.Click += new System.EventHandler(this.appAboutToolStripMenuItem_Click);
            // 
            // lbltenhienthi
            // 
            this.lbltenhienthi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenhienthi.ForeColor = System.Drawing.Color.Red;
            this.lbltenhienthi.Name = "lbltenhienthi";
            this.lbltenhienthi.Size = new System.Drawing.Size(41, 28);
            this.lbltenhienthi.Text = "Tên";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 28);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltenhienthi,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1257, 34);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sotietkiem99.Properties.Resources.demo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 706);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ TIỀN TIẾT KIỆM- SỔ TIẾT KIỆM NGÂN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnlogin;
        private System.Windows.Forms.ToolStripMenuItem mndanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnchucvu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnkyhan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnkhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnnhanvien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem dỊCHVỤToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsotietkiem;
        private System.Windows.Forms.ToolStripMenuItem mnbaocao;
        private System.Windows.Forms.ToolStripStatusLabel lbltenhienthi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appAboutToolStripMenuItem;
    }
}

