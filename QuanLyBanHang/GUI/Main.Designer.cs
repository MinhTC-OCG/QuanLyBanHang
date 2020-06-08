namespace GUI
{
    partial class Main
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
            this.mnTSQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiHangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NCCMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LichSuGiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrinhDoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTSBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoTheoNgayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoTheoThangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoDoanhSoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnTSQuanLy
            // 
            this.mnTSQuanLy.AutoSize = false;
            this.mnTSQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoaiHangMenuItem,
            this.HangMenuItem,
            this.NCCMenuItem,
            this.NhanVienMenuItem,
            this.KhachHangMenuItem,
            this.LichSuGiaMenuItem,
            this.TrinhDoMenuItem,
            this.HoaDonMenuItem});
            this.mnTSQuanLy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnTSQuanLy.ForeColor = System.Drawing.Color.Black;
            this.mnTSQuanLy.Name = "mnTSQuanLy";
            this.mnTSQuanLy.Size = new System.Drawing.Size(95, 50);
            this.mnTSQuanLy.Text = "Quản lý";
            this.mnTSQuanLy.ToolTipText = "Quản lý";
            // 
            // LoaiHangMenuItem
            // 
            this.LoaiHangMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiHangMenuItem.Name = "LoaiHangMenuItem";
            this.LoaiHangMenuItem.Size = new System.Drawing.Size(177, 26);
            this.LoaiHangMenuItem.Text = "Loại hàng";
            this.LoaiHangMenuItem.Click += new System.EventHandler(this.LoaiHangMenuItem_Click);
            // 
            // HangMenuItem
            // 
            this.HangMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangMenuItem.Name = "HangMenuItem";
            this.HangMenuItem.Size = new System.Drawing.Size(177, 26);
            this.HangMenuItem.Text = "Hàng";
            this.HangMenuItem.Click += new System.EventHandler(this.HangMenuItem_Click);
            // 
            // NCCMenuItem
            // 
            this.NCCMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCCMenuItem.Name = "NCCMenuItem";
            this.NCCMenuItem.Size = new System.Drawing.Size(177, 26);
            this.NCCMenuItem.Text = "Nhà cung cấp";
            this.NCCMenuItem.Click += new System.EventHandler(this.NCCMenuItem_Click);
            // 
            // NhanVienMenuItem
            // 
            this.NhanVienMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVienMenuItem.Name = "NhanVienMenuItem";
            this.NhanVienMenuItem.Size = new System.Drawing.Size(177, 26);
            this.NhanVienMenuItem.Text = "Nhân viên";
            this.NhanVienMenuItem.Click += new System.EventHandler(this.NhanVienMenuItem_Click);
            // 
            // KhachHangMenuItem
            // 
            this.KhachHangMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachHangMenuItem.Name = "KhachHangMenuItem";
            this.KhachHangMenuItem.Size = new System.Drawing.Size(177, 26);
            this.KhachHangMenuItem.Text = "Khách hàng";
            this.KhachHangMenuItem.Click += new System.EventHandler(this.KhachHangMenuItem_Click);
            // 
            // LichSuGiaMenuItem
            // 
            this.LichSuGiaMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LichSuGiaMenuItem.Name = "LichSuGiaMenuItem";
            this.LichSuGiaMenuItem.Size = new System.Drawing.Size(177, 26);
            this.LichSuGiaMenuItem.Text = "Lịch sử giá";
            this.LichSuGiaMenuItem.Click += new System.EventHandler(this.LichSuGiaMenuItem_Click);
            // 
            // TrinhDoMenuItem
            // 
            this.TrinhDoMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrinhDoMenuItem.Name = "TrinhDoMenuItem";
            this.TrinhDoMenuItem.Size = new System.Drawing.Size(177, 26);
            this.TrinhDoMenuItem.Text = "Trình độ";
            this.TrinhDoMenuItem.Click += new System.EventHandler(this.TrinhDoMenuItem_Click);
            // 
            // HoaDonMenuItem
            // 
            this.HoaDonMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonMenuItem.Name = "HoaDonMenuItem";
            this.HoaDonMenuItem.Size = new System.Drawing.Size(177, 26);
            this.HoaDonMenuItem.Text = "Hóa đơn";
            this.HoaDonMenuItem.Click += new System.EventHandler(this.HoaDonMenuItem_Click);
            // 
            // mnTSBaoCao
            // 
            this.mnTSBaoCao.AutoSize = false;
            this.mnTSBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaoCaoTheoNgayMenuItem,
            this.BaoCaoTheoThangMenuItem,
            this.BaoCaoDoanhSoMenuItem});
            this.mnTSBaoCao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnTSBaoCao.ForeColor = System.Drawing.Color.Black;
            this.mnTSBaoCao.Name = "mnTSBaoCao";
            this.mnTSBaoCao.Size = new System.Drawing.Size(95, 50);
            this.mnTSBaoCao.Text = "Báo Cáo";
            this.mnTSBaoCao.ToolTipText = "Báo cáo";
            // 
            // BaoCaoTheoNgayMenuItem
            // 
            this.BaoCaoTheoNgayMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoTheoNgayMenuItem.Name = "BaoCaoTheoNgayMenuItem";
            this.BaoCaoTheoNgayMenuItem.Size = new System.Drawing.Size(273, 26);
            this.BaoCaoTheoNgayMenuItem.Text = "Báo cáo theo ngày";
            this.BaoCaoTheoNgayMenuItem.Click += new System.EventHandler(this.BaoCaoTheoNgayMenuItem_Click);
            // 
            // BaoCaoTheoThangMenuItem
            // 
            this.BaoCaoTheoThangMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoTheoThangMenuItem.Name = "BaoCaoTheoThangMenuItem";
            this.BaoCaoTheoThangMenuItem.Size = new System.Drawing.Size(273, 26);
            this.BaoCaoTheoThangMenuItem.Text = "Báo cáo theo tháng";
            // 
            // BaoCaoDoanhSoMenuItem
            // 
            this.BaoCaoDoanhSoMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoDoanhSoMenuItem.Name = "BaoCaoDoanhSoMenuItem";
            this.BaoCaoDoanhSoMenuItem.Size = new System.Drawing.Size(273, 26);
            this.BaoCaoDoanhSoMenuItem.Text = "Báo cáo doanh số bán hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTSQuanLy,
            this.mnTSBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(979, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 54);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 611);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem LoaiHangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NCCMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LichSuGiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrinhDoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnTSBaoCao;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoTheoNgayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoTheoThangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoDoanhSoMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnTSQuanLy;
        private System.Windows.Forms.Button btnDangXuat;
    }
}

