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
            this.TenTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhdo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trình độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trình độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã trình độ";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(452, 209);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 3;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(157, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(157, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(452, 270);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(452, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(452, 142);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // dgvTrinhdo
            // 
            this.dgvTrinhdo.AllowUserToAddRows = false;
            this.dgvTrinhdo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhdo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTrinhDo,
            this.MaTrinhDo});
            this.dgvTrinhdo.EnableHeadersVisualStyles = false;
            this.dgvTrinhdo.Location = new System.Drawing.Point(81, 339);
            this.dgvTrinhdo.Name = "dgvTrinhdo";
            this.dgvTrinhdo.RowHeadersVisible = false;
            this.dgvTrinhdo.RowHeadersWidth = 51;
            this.dgvTrinhdo.RowTemplate.Height = 24;
            this.dgvTrinhdo.Size = new System.Drawing.Size(541, 150);
            this.dgvTrinhdo.TabIndex = 9;
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.Location = new System.Drawing.Point(227, 88);
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(163, 22);
            this.txtTrinhdo.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(619, 514);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtMatrinhdo
            // 
            this.txtMatrinhdo.Location = new System.Drawing.Point(227, 145);
            this.txtMatrinhdo.Name = "txtMatrinhdo";
            this.txtMatrinhdo.Size = new System.Drawing.Size(163, 22);
            this.txtMatrinhdo.TabIndex = 13;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(561, 142);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(122, 22);
            this.txtTim.TabIndex = 14;
            // 
            // TenTrinhDo
            // 
            this.TenTrinhDo.HeaderText = "Trình độ";
            this.TenTrinhDo.MinimumWidth = 6;
            this.TenTrinhDo.Name = "TenTrinhDo";
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.HeaderText = "Mã trình độ";
            this.MaTrinhDo.MinimumWidth = 6;
            this.MaTrinhDo.Name = "MaTrinhDo";
            // 
            // TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 549);
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
            this.Controls.Add(this.label1);
            this.Name = "TrinhDo";
            this.Text = "TrinhDo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhdo)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
    }
}