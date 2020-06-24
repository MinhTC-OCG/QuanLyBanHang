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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBH_DataSet = new GUI.QLBH_DataSet();
            this.HoaDonTongHop12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTongHop12TableAdapter = new GUI.QLBH_DataSetTableAdapters.HoaDonTongHop12TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonTongHop12BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Size = new System.Drawing.Size(1254, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBH_DataSet
            // 
            this.QLBH_DataSet.DataSetName = "QLBH_DataSet";
            this.QLBH_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonTongHop12BindingSource
            // 
            this.HoaDonTongHop12BindingSource.DataMember = "HoaDonTongHop12";
            this.HoaDonTongHop12BindingSource.DataSource = this.QLBH_DataSet;
            // 
            // HoaDonTongHop12TableAdapter
            // 
            this.HoaDonTongHop12TableAdapter.ClearBeforeFill = true;
            // 
            // ReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 534);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHoaDon";
            this.Text = "ReportHoaDon";
            this.Load += new System.EventHandler(this.ReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBH_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonTongHop12BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonTongHop12BindingSource;
        private QLBH_DataSet QLBH_DataSet;
        private QLBH_DataSetTableAdapters.HoaDonTongHop12TableAdapter HoaDonTongHop12TableAdapter;
    }
}