namespace GUI
{
    partial class ReportBaoCaoTheoThang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBH_DataSet = new GUI.QLBH_DataSet();
            this.LichSuHang12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LichSuHang12TableAdapter = new GUI.QLBH_DataSetTableAdapters.LichSuHang12TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichSuHang12BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LichSuHang12BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBaoCaoTheoThang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBH_DataSet
            // 
            this.QLBH_DataSet.DataSetName = "QLBH_DataSet";
            this.QLBH_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LichSuHang12BindingSource
            // 
            this.LichSuHang12BindingSource.DataMember = "LichSuHang12";
            this.LichSuHang12BindingSource.DataSource = this.QLBH_DataSet;
            // 
            // LichSuHang12TableAdapter
            // 
            this.LichSuHang12TableAdapter.ClearBeforeFill = true;
            // 
            // ReportBaoCaoTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBaoCaoTheoThang";
            this.Text = "ReportBaoCaoTheoThang";
            this.Load += new System.EventHandler(this.ReportBaoCaoTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichSuHang12BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LichSuHang12BindingSource;
        private QLBH_DataSet QLBH_DataSet;
        private QLBH_DataSetTableAdapters.LichSuHang12TableAdapter LichSuHang12TableAdapter;
    }
}