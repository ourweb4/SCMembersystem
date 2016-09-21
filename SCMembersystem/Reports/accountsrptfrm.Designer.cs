namespace SCMembersystem.Reports
{
    partial class accountsrptfrm
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
            this.accountDS1 = new SCMembersystem.DataSets.AccountDS();
            this.dataTable1TableAdapter1 = new SCMembersystem.DataSets.AccountDSTableAdapters.DataTable1TableAdapter();
            this.accountDS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersDS = new SCMembersystem.DataSets.MembersDS();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new SCMembersystem.DataSets.MembersDSTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCMembersystem.Reports.accounts1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1062, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // accountDS1
            // 
            this.accountDS1.DataSetName = "AccountDS";
            this.accountDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // accountDS1BindingSource
            // 
            this.accountDS1BindingSource.DataSource = this.accountDS1;
            this.accountDS1BindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.accountDS1BindingSource;
            // 
            // membersDS
            // 
            this.membersDS.DataSetName = "MembersDS";
            this.membersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.membersDS;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // accountsrptfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "accountsrptfrm";
            this.Text = "Accounts Report";
            this.Load += new System.EventHandler(this.accountsrptfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.AccountDS accountDS1;
        private DataSets.AccountDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource accountDS1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSets.MembersDS membersDS;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private DataSets.MembersDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}