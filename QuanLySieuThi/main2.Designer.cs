namespace QuanLySieuThi
{
    partial class main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main2));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mn_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_tkquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_doimk = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dx = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_phieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_phieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_phieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_nhapnhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_xuatle = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_bannhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1356, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quyền :";
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.Color.Red;
            this.lb_quyen.Location = new System.Drawing.Point(1516, 92);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(220, 46);
            this.lb_quyen.TabIndex = 2;
            this.lb_quyen.Text = "....................";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1328, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(420, 36);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // mn_hethong
            // 
            this.mn_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_nhanvien,
            this.mn_tkquanly,
            this.mn_admin,
            this.toolStripMenuItem1,
            this.mn_doimk,
            this.mn_dx});
            this.mn_hethong.Name = "mn_hethong";
            this.mn_hethong.Size = new System.Drawing.Size(89, 24);
            this.mn_hethong.Text = " Hệ thống";
            // 
            // mn_nhanvien
            // 
            this.mn_nhanvien.Name = "mn_nhanvien";
            this.mn_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mn_nhanvien.Size = new System.Drawing.Size(287, 26);
            this.mn_nhanvien.Text = " - Tài khoản nhân viên";
            this.mn_nhanvien.Click += new System.EventHandler(this.tàiKhoảnNhânViênToolStripMenuItem_Click);
            // 
            // mn_tkquanly
            // 
            this.mn_tkquanly.Name = "mn_tkquanly";
            this.mn_tkquanly.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mn_tkquanly.Size = new System.Drawing.Size(287, 26);
            this.mn_tkquanly.Text = "- Tài khoản Quản lý";
            this.mn_tkquanly.Click += new System.EventHandler(this.mn_tkquanly_Click);
            // 
            // mn_admin
            // 
            this.mn_admin.Name = "mn_admin";
            this.mn_admin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mn_admin.Size = new System.Drawing.Size(287, 26);
            this.mn_admin.Text = "- Tài khoản admin";
            this.mn_admin.Click += new System.EventHandler(this.mn_admin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(284, 6);
            // 
            // mn_doimk
            // 
            this.mn_doimk.Name = "mn_doimk";
            this.mn_doimk.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mn_doimk.Size = new System.Drawing.Size(287, 26);
            this.mn_doimk.Text = "- Đổi mật khẩu";
            this.mn_doimk.Click += new System.EventHandler(this.mn_doimk_Click);
            // 
            // mn_dx
            // 
            this.mn_dx.Name = "mn_dx";
            this.mn_dx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mn_dx.Size = new System.Drawing.Size(287, 26);
            this.mn_dx.Text = "- Đăng xuất";
            this.mn_dx.Click += new System.EventHandler(this.mn_dx_Click);
            // 
            // mn_quanly
            // 
            this.mn_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ql_phieunhap,
            this.ql_phieuxuat,
            this.ql_ncc,
            this.ql_khachhang,
            this.ql_nhanvien,
            this.quảnLýSảnPhẩmToolStripMenuItem});
            this.mn_quanly.Name = "mn_quanly";
            this.mn_quanly.Size = new System.Drawing.Size(77, 24);
            this.mn_quanly.Text = "Quản lý ";
            this.mn_quanly.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // ql_phieunhap
            // 
            this.ql_phieunhap.Name = "ql_phieunhap";
            this.ql_phieunhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ql_phieunhap.Size = new System.Drawing.Size(298, 26);
            this.ql_phieunhap.Text = " - Quản lý phiếu nhập";
            this.ql_phieunhap.Click += new System.EventHandler(this.ql_phieunhap_Click);
            // 
            // ql_phieuxuat
            // 
            this.ql_phieuxuat.Name = "ql_phieuxuat";
            this.ql_phieuxuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ql_phieuxuat.Size = new System.Drawing.Size(298, 26);
            this.ql_phieuxuat.Text = "- Quản lý phiếu xuất";
            this.ql_phieuxuat.Click += new System.EventHandler(this.ql_phieuxuat_Click);
            // 
            // ql_ncc
            // 
            this.ql_ncc.Name = "ql_ncc";
            this.ql_ncc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.ql_ncc.Size = new System.Drawing.Size(298, 26);
            this.ql_ncc.Text = " - Quản lý nhà cung cấp";
            this.ql_ncc.Click += new System.EventHandler(this.ql_ncc_Click);
            // 
            // ql_khachhang
            // 
            this.ql_khachhang.Name = "ql_khachhang";
            this.ql_khachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.ql_khachhang.Size = new System.Drawing.Size(298, 26);
            this.ql_khachhang.Text = "- Quản lý khách hàng";
            this.ql_khachhang.Click += new System.EventHandler(this.ql_khachhang_Click);
            // 
            // ql_nhanvien
            // 
            this.ql_nhanvien.Name = "ql_nhanvien";
            this.ql_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.ql_nhanvien.Size = new System.Drawing.Size(298, 26);
            this.ql_nhanvien.Text = " - Quản lý nhân viên";
            this.ql_nhanvien.Click += new System.EventHandler(this.ql_nhanvien_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "- Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // mn_banhang
            // 
            this.mn_banhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bh_phieunhap,
            this.bh_nhapnhieu,
            this.bh_xuatle,
            this.bh_bannhieu});
            this.mn_banhang.Name = "mn_banhang";
            this.mn_banhang.Size = new System.Drawing.Size(85, 24);
            this.mn_banhang.Text = "Bán hàng";
            this.mn_banhang.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // bh_phieunhap
            // 
            this.bh_phieunhap.Name = "bh_phieunhap";
            this.bh_phieunhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.bh_phieunhap.Size = new System.Drawing.Size(245, 26);
            this.bh_phieunhap.Text = " - Nhập hàng lẻ";
            this.bh_phieunhap.Click += new System.EventHandler(this.bh_phieunhap_Click);
            // 
            // bh_nhapnhieu
            // 
            this.bh_nhapnhieu.Name = "bh_nhapnhieu";
            this.bh_nhapnhieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bh_nhapnhieu.Size = new System.Drawing.Size(245, 26);
            this.bh_nhapnhieu.Text = "- Nhập hàng";
            this.bh_nhapnhieu.Click += new System.EventHandler(this.bh_nhapnhieu_Click);
            // 
            // bh_xuatle
            // 
            this.bh_xuatle.Name = "bh_xuatle";
            this.bh_xuatle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.bh_xuatle.Size = new System.Drawing.Size(245, 26);
            this.bh_xuatle.Text = "- Xuất lẻ";
            this.bh_xuatle.Click += new System.EventHandler(this.bh_xuatle_Click);
            // 
            // bh_bannhieu
            // 
            this.bh_bannhieu.Name = "bh_bannhieu";
            this.bh_bannhieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.bh_bannhieu.Size = new System.Drawing.Size(245, 26);
            this.bh_bannhieu.Text = "- Bán hàng";
            this.bh_bannhieu.Click += new System.EventHandler(this.bh_bannhieu_Click);
            // 
            // mn_thongtin
            // 
            this.mn_thongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinPhầnMềmToolStripMenuItem,
            this.hỗTrợToolStripMenuItem1});
            this.mn_thongtin.Name = "mn_thongtin";
            this.mn_thongtin.Size = new System.Drawing.Size(86, 24);
            this.mn_thongtin.Text = "Thông tin";
            this.mn_thongtin.Click += new System.EventHandler(this.mn_thongtin_Click);
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = " - Thông tin phần mềm";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem1
            // 
            this.hỗTrợToolStripMenuItem1.Name = "hỗTrợToolStripMenuItem1";
            this.hỗTrợToolStripMenuItem1.Size = new System.Drawing.Size(324, 26);
            this.hỗTrợToolStripMenuItem1.Text = " - Hỗ trợ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_hethong,
            this.mn_quanly,
            this.mn_banhang,
            this.mn_thongtin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1765, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuThi.Properties.Resources._14421158247_0bea4c652d_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1765, 681);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main2";
            this.Text = "Quản Lý siêu thị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ToolStripMenuItem mn_hethong;
        public System.Windows.Forms.ToolStripMenuItem mn_nhanvien;
        public System.Windows.Forms.ToolStripMenuItem mn_tkquanly;
        public System.Windows.Forms.ToolStripMenuItem mn_admin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mn_doimk;
        public System.Windows.Forms.ToolStripMenuItem mn_dx;
        public System.Windows.Forms.ToolStripMenuItem mn_quanly;
        public System.Windows.Forms.ToolStripMenuItem ql_phieunhap;
        public System.Windows.Forms.ToolStripMenuItem ql_phieuxuat;
        public System.Windows.Forms.ToolStripMenuItem ql_ncc;
        public System.Windows.Forms.ToolStripMenuItem ql_khachhang;
        public System.Windows.Forms.ToolStripMenuItem ql_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mn_banhang;
        public System.Windows.Forms.ToolStripMenuItem bh_phieunhap;
        public System.Windows.Forms.ToolStripMenuItem bh_nhapnhieu;
        public System.Windows.Forms.ToolStripMenuItem bh_xuatle;
        public System.Windows.Forms.ToolStripMenuItem bh_bannhieu;
        public System.Windows.Forms.ToolStripMenuItem mn_thongtin;
        public System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}