namespace GUI
{
    partial class TrinhDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrinhDo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTrinhdo = new System.Windows.Forms.DataGridView();
            this.txtTrinhdo = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMatrinhdo = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhdo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRÌNH ĐỘ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trình độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã trình độ:";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaplai.Image")));
            this.btnNhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaplai.Location = new System.Drawing.Point(784, 224);
            this.btnNhaplai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(121, 43);
            this.btnNhaplai.TabIndex = 3;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(115, 224);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 43);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(9, 224);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(911, 224);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 43);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(220, 224);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 43);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(325, 224);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 43);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTrinhdo
            // 
            this.dgvTrinhdo.AllowUserToAddRows = false;
            this.dgvTrinhdo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhdo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTD,
            this.TenTD});
            this.dgvTrinhdo.EnableHeadersVisualStyles = false;
            this.dgvTrinhdo.Location = new System.Drawing.Point(9, 272);
            this.dgvTrinhdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrinhdo.Name = "dgvTrinhdo";
            this.dgvTrinhdo.RowHeadersVisible = false;
            this.dgvTrinhdo.RowHeadersWidth = 51;
            this.dgvTrinhdo.RowTemplate.Height = 24;
            this.dgvTrinhdo.Size = new System.Drawing.Size(1060, 277);
            this.dgvTrinhdo.TabIndex = 9;
            this.dgvTrinhdo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhdo_RowEnter);
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhdo.Location = new System.Drawing.Point(152, 139);
            this.txtTrinhdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrinhdo.Multiline = true;
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(392, 30);
            this.txtTrinhdo.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1016, 224);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(53, 43);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMatrinhdo
            // 
            this.txtMatrinhdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrinhdo.Location = new System.Drawing.Point(152, 91);
            this.txtMatrinhdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatrinhdo.Multiline = true;
            this.txtMatrinhdo.Name = "txtMatrinhdo";
            this.txtMatrinhdo.Size = new System.Drawing.Size(392, 30);
            this.txtMatrinhdo.TabIndex = 13;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(416, 224);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(239, 42);
            this.txtTim.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 49);
            this.panel1.TabIndex = 15;
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD_1";
            this.MaTD.HeaderText = "Mã trình độ";
            this.MaTD.MinimumWidth = 6;
            this.MaTD.Name = "MaTD";
            this.MaTD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenTD1";
            this.TenTD.HeaderText = "Trình độ";
            this.TenTD.MinimumWidth = 6;
            this.TenTD.Name = "TenTD";
            this.TenTD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtMatrinhdo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTrinhdo);
            this.Controls.Add(this.dgvTrinhdo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrinhDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.TrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhdo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTrinhdo;
        private System.Windows.Forms.TextBox txtTrinhdo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMatrinhdo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
    }
}