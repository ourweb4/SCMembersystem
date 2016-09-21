namespace SCMembersystem.forms
{
    partial class invoicesfrm
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
            this.firstnamelab = new System.Windows.Forms.Label();
            this.lastnamelab = new System.Windows.Forms.Label();
            this.addresslab = new System.Windows.Forms.Label();
            this.citylab = new System.Windows.Forms.Label();
            this.statelab = new System.Windows.Forms.Label();
            this.ziplab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amtduelab = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.invdatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.amountnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.paidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnamelab
            // 
            this.firstnamelab.AutoSize = true;
            this.firstnamelab.Location = new System.Drawing.Point(30, 38);
            this.firstnamelab.Name = "firstnamelab";
            this.firstnamelab.Size = new System.Drawing.Size(35, 13);
            this.firstnamelab.TabIndex = 0;
            this.firstnamelab.Text = "label1";
            // 
            // lastnamelab
            // 
            this.lastnamelab.AutoSize = true;
            this.lastnamelab.Location = new System.Drawing.Point(278, 38);
            this.lastnamelab.Name = "lastnamelab";
            this.lastnamelab.Size = new System.Drawing.Size(35, 13);
            this.lastnamelab.TabIndex = 1;
            this.lastnamelab.Text = "label1";
            // 
            // addresslab
            // 
            this.addresslab.AutoSize = true;
            this.addresslab.Location = new System.Drawing.Point(33, 83);
            this.addresslab.Name = "addresslab";
            this.addresslab.Size = new System.Drawing.Size(35, 13);
            this.addresslab.TabIndex = 2;
            this.addresslab.Text = "label1";
            // 
            // citylab
            // 
            this.citylab.AutoSize = true;
            this.citylab.Location = new System.Drawing.Point(36, 122);
            this.citylab.Name = "citylab";
            this.citylab.Size = new System.Drawing.Size(35, 13);
            this.citylab.TabIndex = 3;
            this.citylab.Text = "label1";
            // 
            // statelab
            // 
            this.statelab.AutoSize = true;
            this.statelab.Location = new System.Drawing.Point(281, 122);
            this.statelab.Name = "statelab";
            this.statelab.Size = new System.Drawing.Size(35, 13);
            this.statelab.TabIndex = 4;
            this.statelab.Text = "label1";
            // 
            // ziplab
            // 
            this.ziplab.AutoSize = true;
            this.ziplab.Location = new System.Drawing.Point(428, 122);
            this.ziplab.Name = "ziplab";
            this.ziplab.Size = new System.Drawing.Size(35, 13);
            this.ziplab.TabIndex = 5;
            this.ziplab.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount Due";
            // 
            // amtduelab
            // 
            this.amtduelab.AutoSize = true;
            this.amtduelab.Location = new System.Drawing.Point(171, 175);
            this.amtduelab.Name = "amtduelab";
            this.amtduelab.Size = new System.Drawing.Size(35, 13);
            this.amtduelab.TabIndex = 7;
            this.amtduelab.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.invdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paidamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(SCMembersystem.Models.Invoice);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount Paid";
            // 
            // invdatedateTimePicker
            // 
            this.invdatedateTimePicker.Location = new System.Drawing.Point(113, 413);
            this.invdatedateTimePicker.Name = "invdatedateTimePicker";
            this.invdatedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invdatedateTimePicker.TabIndex = 13;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(113, 443);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(296, 20);
            this.descriptiontxt.TabIndex = 14;
            // 
            // amountnumericUpDown
            // 
            this.amountnumericUpDown.DecimalPlaces = 2;
            this.amountnumericUpDown.Location = new System.Drawing.Point(113, 472);
            this.amountnumericUpDown.Name = "amountnumericUpDown";
            this.amountnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountnumericUpDown.TabIndex = 15;
            // 
            // paidnumericUpDown
            // 
            this.paidnumericUpDown.DecimalPlaces = 2;
            this.paidnumericUpDown.Location = new System.Drawing.Point(113, 514);
            this.paidnumericUpDown.Name = "paidnumericUpDown";
            this.paidnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.paidnumericUpDown.TabIndex = 16;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(592, 413);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 23);
            this.addbut.TabIndex = 17;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(592, 439);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 18;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(592, 469);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 19;
            this.deletebut.Text = "Delete";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Invoice No.";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invdateDataGridViewTextBoxColumn
            // 
            this.invdateDataGridViewTextBoxColumn.DataPropertyName = "invdate";
            this.invdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.invdateDataGridViewTextBoxColumn.Name = "invdateDataGridViewTextBoxColumn";
            this.invdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidamountDataGridViewTextBoxColumn
            // 
            this.paidamountDataGridViewTextBoxColumn.DataPropertyName = "paidamount";
            this.paidamountDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidamountDataGridViewTextBoxColumn.Name = "paidamountDataGridViewTextBoxColumn";
            this.paidamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 615);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.paidnumericUpDown);
            this.Controls.Add(this.amountnumericUpDown);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.invdatedateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.amtduelab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ziplab);
            this.Controls.Add(this.statelab);
            this.Controls.Add(this.citylab);
            this.Controls.Add(this.addresslab);
            this.Controls.Add(this.lastnamelab);
            this.Controls.Add(this.firstnamelab);
            this.Name = "invoicesfrm";
            this.Text = "Member Invoices";
            this.Load += new System.EventHandler(this.invoicesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnamelab;
        private System.Windows.Forms.Label lastnamelab;
        private System.Windows.Forms.Label addresslab;
        private System.Windows.Forms.Label citylab;
        private System.Windows.Forms.Label statelab;
        private System.Windows.Forms.Label ziplab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amtduelab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker invdatedateTimePicker;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.NumericUpDown amountnumericUpDown;
        private System.Windows.Forms.NumericUpDown paidnumericUpDown;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidamountDataGridViewTextBoxColumn;
    }
}