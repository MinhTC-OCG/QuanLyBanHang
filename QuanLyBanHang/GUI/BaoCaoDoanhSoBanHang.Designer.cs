namespace GUI
{
    partial class BaoCaoDoanhSoBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoDoanhSoBanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.dgvDoanhSoHang = new System.Windows.Forms.DataGridView();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahdcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Doanh Số Bán Hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(12, 73);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(51, 34);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(596, 80);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(71, 27);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(362, 80);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(172, 27);
            this.dtPicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời gian:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = " ";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(247, 135);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(65, 16);
            this.lbThang.TabIndex = 14;
            this.lbThang.Text = " MM/yyyy";
            // 
            // cbNV
            // 
            this.cbNV.AutoSize = true;
            this.cbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNV.Location = new System.Drawing.Point(371, 134);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(150, 20);
            this.cbNV.TabIndex = 15;
            this.cbNV.Text = "Doanh số Nhân Viên";
            this.cbNV.UseVisualStyleBackColor = true;
            this.cbNV.Click += new System.EventHandler(this.cbNV_CheckedChanged);
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbH.Location = new System.Drawing.Point(554, 131);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(150, 20);
            this.cbH.TabIndex = 16;
            this.cbH.Text = "Doanh số theo Hàng";
            this.cbH.UseVisualStyleBackColor = true;
            this.cbH.Click += new System.EventHandler(this.cbH_CheckedChanged);
            // 
            // dgvDoanhSoHang
            // 
            this.dgvDoanhSoHang.AllowUserToAddRows = false;
            this.dgvDoanhSoHang.AllowUserToResizeRows = false;
            this.dgvDoanhSoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhSoHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDoanhSoHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhSoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoanhSoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.MaH,
            this.TenH,
            this.TenL,
            this.TenNCC,
            this.MaHD,
            this.HoTenNV,
            this.HoTenKH,
            this.DonG,
            this.SoL,
            this.Tong});
            this.dgvDoanhSoHang.EnableHeadersVisualStyles = false;
            this.dgvDoanhSoHang.Location = new System.Drawing.Point(15, 237);
            this.dgvDoanhSoHang.Name = "dgvDoanhSoHang";
            this.dgvDoanhSoHang.RowHeadersVisible = false;
            this.dgvDoanhSoHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoanhSoHang.Size = new System.Drawing.Size(920, 271);
            this.dgvDoanhSoHang.TabIndex = 27;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(711, 80);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(71, 27);
            this.btnTatCa.TabIndex = 28;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.MaNV,
            this.HoTen,
            this.Mahdcl,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6});
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 237);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNhanVien.Size = new System.Drawing.Size(920, 271);
            this.dgvNhanVien.TabIndex = 29;
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.Location = new System.Drawing.Point(87, 135);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(0, 16);
            this.lbNguoiLap.TabIndex = 31;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "Ngày lập";
            this.NgayLap.FillWeight = 88.55048F;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // MaH
            // 
            this.MaH.DataPropertyName = "Mã hàng";
            this.MaH.FillWeight = 88.55048F;
            this.MaH.HeaderText = "Mã hàng";
            this.MaH.Name = "MaH";
            // 
            // TenH
            // 
            this.TenH.DataPropertyName = "Tên hàng";
            this.TenH.FillWeight = 88.55048F;
            this.TenH.HeaderText = "Tên hàng";
            this.TenH.Name = "TenH";
            // 
            // TenL
            // 
            this.TenL.DataPropertyName = "Tên loại";
            this.TenL.FillWeight = 88.55048F;
            this.TenL.HeaderText = "Tên loại";
            this.TenL.Name = "TenL";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "Nhà cung cấp";
            this.TenNCC.HeaderText = "Nhà cung cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "Mã hóa đơn";
            this.MaHD.FillWeight = 88.55048F;
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "Họ tên NV";
            this.HoTenNV.FillWeight = 88.55048F;
            this.HoTenNV.HeaderText = "Họ Tên NV";
            this.HoTenNV.Name = "HoTenNV";
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "Họ tên KH";
            this.HoTenKH.FillWeight = 88.55048F;
            this.HoTenKH.HeaderText = "Họ tên KH";
            this.HoTenKH.Name = "HoTenKH";
            // 
            // DonG
            // 
            this.DonG.DataPropertyName = "Đơn giá";
            this.DonG.FillWeight = 88.55048F;
            this.DonG.HeaderText = "Đơn giá";
            this.DonG.Name = "DonG";
            // 
            // SoL
            // 
            this.SoL.DataPropertyName = "Số lượng";
            this.SoL.FillWeight = 88.55048F;
            this.SoL.HeaderText = "Số lượng";
            this.SoL.Name = "SoL";
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "Tổng tiền";
            this.Tong.HeaderText = "Tổng";
            this.Tong.Name = "Tong";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ngày lập";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "Mã NV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Họ tên NV";
            this.HoTen.HeaderText = "Họ tên NV";
            this.HoTen.Name = "HoTen";
            // 
            // Mahdcl
            // 
            this.Mahdcl.DataPropertyName = "Mã hóa đơn";
            this.Mahdcl.HeaderText = "Mã hóa đơn";
            this.Mahdcl.Name = "Mahdcl";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Họ tên KH";
            this.Column1.HeaderText = "Họ tên KH";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mã hàng";
            this.Column3.HeaderText = "Mã hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tên hàng";
            this.Column4.HeaderText = "Tên hàng";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Số lượng";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Đơn giá";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tổng tiền";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            // 
            // BaoCaoDoanhSoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 520);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.dgvDoanhSoHang);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoDoanhSoBanHang";
            this.Text = "BaoCaoDoanhSoBanHang";
            this.Load += new System.EventHandler(this.BaoCaoDoanhSoBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.CheckBox cbNV;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.DataGridView dgvDoanhSoHang;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahdcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}