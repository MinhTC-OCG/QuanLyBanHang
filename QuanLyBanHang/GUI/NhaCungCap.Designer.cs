namespace GUI
{
    partial class NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.bnNhapLai = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.bnSua = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.bnXem = new System.Windows.Forms.Button();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SoDT});
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.Location = new System.Drawing.Point(10, 231);
            this.dgvNCC.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(841, 230);
            this.dgvNCC.TabIndex = 0;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(131, 69);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNCC.Multiline = true;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(295, 25);
            this.txtMaNCC.TabIndex = 5;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(131, 109);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(295, 25);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(556, 69);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(295, 25);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(556, 109);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDT.Multiline = true;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(295, 25);
            this.txtSoDT.TabIndex = 8;
            // 
            // bnNhapLai
            // 
            this.bnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("bnNhapLai.Image")));
            this.bnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnNhapLai.Location = new System.Drawing.Point(639, 149);
            this.bnNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.bnNhapLai.Name = "bnNhapLai";
            this.bnNhapLai.Size = new System.Drawing.Size(89, 35);
            this.bnNhapLai.TabIndex = 9;
            this.bnNhapLai.Text = "Nhập lại";
            this.bnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnNhapLai.UseVisualStyleBackColor = true;
            // 
            // bnThem
            // 
            this.bnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThem.Image = ((System.Drawing.Image)(resources.GetObject("bnThem.Image")));
            this.bnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnThem.Location = new System.Drawing.Point(10, 192);
            this.bnThem.Margin = new System.Windows.Forms.Padding(2);
            this.bnThem.Name = "bnThem";
            this.bnThem.Size = new System.Drawing.Size(75, 35);
            this.bnThem.TabIndex = 10;
            this.bnThem.Text = "Thêm";
            this.bnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnThem.UseVisualStyleBackColor = true;
            // 
            // bnSua
            // 
            this.bnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSua.Image = ((System.Drawing.Image)(resources.GetObject("bnSua.Image")));
            this.bnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnSua.Location = new System.Drawing.Point(89, 192);
            this.bnSua.Margin = new System.Windows.Forms.Padding(2);
            this.bnSua.Name = "bnSua";
            this.bnSua.Size = new System.Drawing.Size(75, 35);
            this.bnSua.TabIndex = 11;
            this.bnSua.Text = "Sửa";
            this.bnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnSua.UseVisualStyleBackColor = true;
            // 
            // bnXoa
            // 
            this.bnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXoa.Image = ((System.Drawing.Image)(resources.GetObject("bnXoa.Image")));
            this.bnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnXoa.Location = new System.Drawing.Point(168, 192);
            this.bnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(75, 35);
            this.bnXoa.TabIndex = 12;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnXoa.UseVisualStyleBackColor = true;
            // 
            // bnXem
            // 
            this.bnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnXem.Image = ((System.Drawing.Image)(resources.GetObject("bnXem.Image")));
            this.bnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnXem.Location = new System.Drawing.Point(732, 149);
            this.bnXem.Margin = new System.Windows.Forms.Padding(2);
            this.bnXem.Name = "bnXem";
            this.bnXem.Size = new System.Drawing.Size(75, 35);
            this.bnXem.TabIndex = 13;
            this.bnXem.Text = "Xem";
            this.bnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnXem.UseVisualStyleBackColor = true;
            // 
            // bnThoat
            // 
            this.bnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnThoat.Image = ((System.Drawing.Image)(resources.GetObject("bnThoat.Image")));
            this.bnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnThoat.Location = new System.Drawing.Point(811, 149);
            this.bnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(40, 35);
            this.bnThoat.TabIndex = 14;
            this.bnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnThoat.UseVisualStyleBackColor = true;
            // 
            // bnTim
            // 
            this.bnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTim.Image = ((System.Drawing.Image)(resources.GetObject("bnTim.Image")));
            this.bnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnTim.Location = new System.Drawing.Point(247, 192);
            this.bnTim.Margin = new System.Windows.Forms.Padding(2);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(75, 35);
            this.bnTim.TabIndex = 15;
            this.bnTim.Text = "Tìm";
            this.bnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnTim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 40);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "NHÀ CUNG CẤP";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnTim);
            this.Controls.Add(this.bnThoat);
            this.Controls.Add(this.bnXem);
            this.Controls.Add(this.bnXoa);
            this.Controls.Add(this.bnSua);
            this.Controls.Add(this.bnThem);
            this.Controls.Add(this.bnNhapLai);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNCC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Button bnNhapLai;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.Button bnSua;
        private System.Windows.Forms.Button bnXoa;
        private System.Windows.Forms.Button bnXem;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}