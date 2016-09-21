namespace SCMembersystem.Reports
{
    partial class invrptfrm
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SCMembersystem.DataSets.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportbut = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new SCMembersystem.DataSets.DataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.Location = new System.Drawing.Point(90, 13);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromdateTimePicker.TabIndex = 2;
            // 
            // todateTimePicker
            // 
            this.todateTimePicker.Location = new System.Drawing.Point(385, 13);
            this.todateTimePicker.Name = "todateTimePicker";
            this.todateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.todateTimePicker.TabIndex = 3;
            // 
            // reportbut
            // 
            this.reportbut.Location = new System.Drawing.Point(637, 9);
            this.reportbut.Name = "reportbut";
            this.reportbut.Size = new System.Drawing.Size(75, 23);
            this.reportbut.TabIndex = 4;
            this.reportbut.Text = "Report";
            this.reportbut.UseVisualStyleBackColor = true;
            this.reportbut.Click += new System.EventHandler(this.reportbut_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCMembersystem.Reports.invoices.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(180, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(712, 574);
            this.reportViewer1.TabIndex = 5;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // invrptfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 640);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.reportbut);
            this.Controls.Add(this.todateTimePicker);
            this.Controls.Add(this.fromdateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "invrptfrm";
            this.Text = "invrptfrm";
            this.Load += new System.EventHandler(this.invrptfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromdateTimePicker;
        private System.Windows.Forms.DateTimePicker todateTimePicker;
        private System.Windows.Forms.Button reportbut;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSets.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}