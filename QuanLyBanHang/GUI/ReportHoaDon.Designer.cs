namespace GUI
{
    partial class ReportHoaDon
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
            this.HoaDonTongHop12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBHDataSet = new GUI.QLBHDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonTongHop12TableAdapter = new GUI.QLBHDataSetTableAdapters.HoaDonTongHop12TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonTongHop12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonTongHop12BindingSource
            // 
            this.HoaDonTongHop12BindingSource.DataMember = "HoaDonTongHop12";
            this.HoaDonTongHop12BindingSource.DataSource = this.QLBHDataSet;
            // 
            // QLBHDataSet
            // 
            this.QLBHDataSet.DataSetName = "QLBHDataSet";
            this.QLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonTongHop12BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDonTongHop12TableAdapter
            // 
            this.HoaDonTongHop12TableAdapter.ClearBeforeFill = true;
            // 
            // ReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportHoaDon";
            this.Load += new System.EventHandler(this.ReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonTongHop12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonTongHop12BindingSource;
        private QLBHDataSet QLBHDataSet;
        private QLBHDataSetTableAdapters.HoaDonTongHop12TableAdapter HoaDonTongHop12TableAdapter;
    }
}