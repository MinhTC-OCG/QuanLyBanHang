﻿namespace GUI
{
    partial class NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaTD = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.bnNhapLai = new System.Windows.Forms.Button();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnXem = new System.Windows.Forms.Button();
            this.bnTim = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.bnSua = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã trình độ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên:";
            // 
            // cbMaTD
            // 
            this.cbMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTD.FormattingEnabled = true;
            this.cbMaTD.Location = new System.Drawing.Point(554, 63);
            this.cbMaTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaTD.Name = "cbMaTD";
            this.cbMaTD.Size = new System.Drawing.Size(316, 25);
            this.cbMaTD.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(104, 96);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(296, 23);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(104, 59);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(296, 23);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(104, 27);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(296, 23);
            this.txtMaNV.TabIndex = 8;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(554, 28);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(316, 23);
            this.txtSoDT.TabIndex = 9;
            // 
            // bnNhapLai
            // 
            this.bnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNhapLai.Location = new System.Drawing.Point(9, 172);
            this.bnNhapLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnNhapLai.Name = "bnNhapLai";
            this.bnNhapLai.Size = new System.Drawing.Size(75, 35);
            this.bnNhapLai.TabIndex = 10;
            this.bnNhapLai.Text = "Nhập lại";
            this.bnNhapLai.UseVisualStyleBackColor = true;
            // 
            // bnThoat
            // 
            this.bnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThoat.Location = new System.Drawing.Point(795, 172);
            this.bnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(75, 35);
            this.bnThoat.TabIndex = 11;
            this.bnThoat.Text = "Thoát";
            this.bnThoat.UseVisualStyleBackColor = true;
            // 
            // bnXem
            // 
            this.bnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXem.Location = new System.Drawing.Point(716, 172);
            this.bnXem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnXem.Name = "bnXem";
            this.bnXem.Size = new System.Drawing.Size(75, 35);
            this.bnXem.TabIndex = 12;
            this.bnXem.Text = "Xem";
            this.bnXem.UseVisualStyleBackColor = true;
            // 
            // bnTim
            // 
            this.bnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTim.Location = new System.Drawing.Point(325, 172);
            this.bnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(75, 35);
            this.bnTim.TabIndex = 13;
            this.bnTim.Text = "Tìm";
            this.bnTim.UseVisualStyleBackColor = true;
            // 
            // bnXoa
            // 
            this.bnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXoa.Location = new System.Drawing.Point(246, 172);
            this.bnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(75, 35);
            this.bnXoa.TabIndex = 14;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.UseVisualStyleBackColor = true;
            // 
            // bnSua
            // 
            this.bnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSua.Location = new System.Drawing.Point(167, 172);
            this.bnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSua.Name = "bnSua";
            this.bnSua.Size = new System.Drawing.Size(75, 35);
            this.bnSua.TabIndex = 15;
            this.bnSua.Text = "Sửa";
            this.bnSua.UseVisualStyleBackColor = true;
            // 
            // bnThem
            // 
            this.bnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThem.Location = new System.Drawing.Point(88, 172);
            this.bnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnThem.Name = "bnThem";
            this.bnThem.Size = new System.Drawing.Size(75, 35);
            this.bnThem.TabIndex = 16;
            this.bnThem.Text = "Thêm";
            this.bnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.DiaChi,
            this.SoDT,
            this.MaTD});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(9, 211);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 217);
            this.dataGridView1.TabIndex = 17;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.HeaderText = "Mã TD";
            this.MaTD.MinimumWidth = 6;
            this.MaTD.Name = "MaTD";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnThem);
            this.Controls.Add(this.bnSua);
            this.Controls.Add(this.bnXoa);
            this.Controls.Add(this.bnTim);
            this.Controls.Add(this.bnXem);
            this.Controls.Add(this.bnThoat);
            this.Controls.Add(this.bnNhapLai);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbMaTD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaTD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Button bnNhapLai;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnXem;
        private System.Windows.Forms.Button bnTim;
        private System.Windows.Forms.Button bnXoa;
        private System.Windows.Forms.Button bnSua;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTD;
    }
}