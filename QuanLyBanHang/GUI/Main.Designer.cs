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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.BaoCaoTheoThangMenuItem.Click += new System.EventHandler(this.BaoCaoTheoThangMenuItem_Click);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTSQuanLy,
            this.mnTSBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1070, 54);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 432);
            this.panel1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, -1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.HotTrack;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(606, 432);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(661, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 95);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 93);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(661, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 95);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 93);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 93);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số KH:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(661, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 95);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 93);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(-1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 93);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng số KH:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(661, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 100);
            this.panel5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 93);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(-1, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 93);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tổng số KH:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 490);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

