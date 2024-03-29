﻿namespace GUI
{
    partial class BaoCaoTonCuoiThang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bnIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dgvBCHTonThang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnXuat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHTonThang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bnIn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(398, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO HÀNG TỒN CUỐI THÁNG";
            // 
            // bnIn
            // 
            this.bnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnIn.Location = new System.Drawing.Point(9, 15);
            this.bnIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnIn.Name = "bnIn";
            this.bnIn.Size = new System.Drawing.Size(37, 26);
            this.bnIn.TabIndex = 7;
            this.bnIn.Text = "In";
            this.bnIn.UseVisualStyleBackColor = true;
            this.bnIn.Click += new System.EventHandler(this.bnIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người lập:";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.Location = new System.Drawing.Point(88, 71);
            this.lbNguoiLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(43, 20);
            this.lbNguoiLap.TabIndex = 3;
            this.lbNguoiLap.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(920, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày lập:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(996, 71);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(89, 20);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "yyyy/MM/dd";
            // 
            // dgvBCHTonThang
            // 
            this.dgvBCHTonThang.AllowUserToAddRows = false;
            this.dgvBCHTonThang.AllowUserToDeleteRows = false;
            this.dgvBCHTonThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCHTonThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCHTonThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHang,
            this.TenH,
            this.DonVT,
            this.SLC,
            this.GhiChu});
            this.dgvBCHTonThang.Location = new System.Drawing.Point(9, 109);
            this.dgvBCHTonThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBCHTonThang.Name = "dgvBCHTonThang";
            this.dgvBCHTonThang.RowHeadersVisible = false;
            this.dgvBCHTonThang.RowHeadersWidth = 51;
            this.dgvBCHTonThang.RowTemplate.Height = 24;
            this.dgvBCHTonThang.Size = new System.Drawing.Size(1087, 359);
            this.dgvBCHTonThang.TabIndex = 6;
            this.dgvBCHTonThang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvBCHTonThang_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            // 
            // TenH
            // 
            this.TenH.DataPropertyName = "TenHang";
            this.TenH.HeaderText = "Tên hàng";
            this.TenH.MinimumWidth = 6;
            this.TenH.Name = "TenH";
            // 
            // DonVT
            // 
            this.DonVT.DataPropertyName = "DonVi";
            this.DonVT.HeaderText = "Đơn vị";
            this.DonVT.MinimumWidth = 6;
            this.DonVT.Name = "DonVT";
            // 
            // SLC
            // 
            this.SLC.DataPropertyName = "SoLuongCon";
            this.SLC.HeaderText = "Số lượng có";
            this.SLC.MinimumWidth = 6;
            this.SLC.Name = "SLC";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "NgayCapNhat";
            this.GhiChu.HeaderText = "Ngày Cập Nhật";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // bnXuat
            // 
            this.bnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXuat.Location = new System.Drawing.Point(666, 67);
            this.bnXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnXuat.Name = "bnXuat";
            this.bnXuat.Size = new System.Drawing.Size(64, 24);
            this.bnXuat.TabIndex = 8;
            this.bnXuat.Text = "Xuất";
            this.bnXuat.UseVisualStyleBackColor = true;
            this.bnXuat.Click += new System.EventHandler(this.bnXuat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 67);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // BaoCaoTonCuoiThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 468);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bnXuat);
            this.Controls.Add(this.dgvBCHTonThang);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoTonCuoiThang";
            this.Text = "BaoCaoTonCuoiThang";
            this.Load += new System.EventHandler(this.BaoCaoTonCuoiThang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCHTonThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView dgvBCHTonThang;
        private System.Windows.Forms.Button bnIn;
        private System.Windows.Forms.Button bnXuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}