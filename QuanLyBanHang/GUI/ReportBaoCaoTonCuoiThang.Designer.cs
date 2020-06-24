namespace GUI
{
    partial class ReportBaoCaoTonCuoiThang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LichSuHang12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBHDataSet = new GUI.QLBHDataSet();
            this.LichSuHang12TableAdapter = new GUI.QLBHDataSetTableAdapters.LichSuHang12TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LichSuHang12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LichSuHang12BindingSource
            // 
            this.LichSuHang12BindingSource.DataMember = "LichSuHang12";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LichSuHang12BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBaoCaoTonCuoiThang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBHDataSet
            // 
            this.QLBHDataSet.DataSetName = "QLBHDataSet";
            this.QLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LichSuHang12TableAdapter
            // 
            this.LichSuHang12TableAdapter.ClearBeforeFill = true;
            // 
            // ReportBaoCaoTonCuoiThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBaoCaoTonCuoiThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportBaoCaoTheoThang";
            this.Load += new System.EventHandler(this.ReportBaoCaoTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LichSuHang12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource LichSuHang12BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLBHDataSet QLBHDataSet;
        private QLBHDataSetTableAdapters.LichSuHang12TableAdapter LichSuHang12TableAdapter;
    }
}