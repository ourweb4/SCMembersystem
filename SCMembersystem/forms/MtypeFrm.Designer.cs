﻿namespace SCMembersystem.forms
{
    partial class mtypefrm
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
            this.MtypesdataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.costUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.addbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MtypesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MtypesdataGridView
            // 
            this.MtypesdataGridView.AllowUserToDeleteRows = false;
            this.MtypesdataGridView.AutoGenerateColumns = false;
            this.MtypesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MtypesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn});
            this.MtypesdataGridView.DataSource = this.mtypeBindingSource;
            this.MtypesdataGridView.Location = new System.Drawing.Point(86, 42);
            this.MtypesdataGridView.Name = "MtypesdataGridView";
            this.MtypesdataGridView.Size = new System.Drawing.Size(736, 189);
            this.MtypesdataGridView.TabIndex = 1;
            this.MtypesdataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MtypesdataGridView_CellEndEdit);
            this.MtypesdataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.MtypesdataGridView_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // mtypeBindingSource
            // 
            this.mtypeBindingSource.DataSource = typeof(SCMembersystem.Models.Mtype);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(168, 281);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(394, 20);
            this.nametxt.TabIndex = 5;
            // 
            // costUpDown
            // 
            this.costUpDown.DecimalPlaces = 2;
            this.costUpDown.Location = new System.Drawing.Point(168, 329);
            this.costUpDown.Name = "costUpDown";
            this.costUpDown.Size = new System.Drawing.Size(120, 20);
            this.costUpDown.TabIndex = 6;
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.Location = new System.Drawing.Point(168, 380);
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(120, 20);
            this.hoursUpDown.TabIndex = 7;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(168, 430);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 37);
            this.addbut.TabIndex = 8;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // mtypefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.hoursUpDown);
            this.Controls.Add(this.costUpDown);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtypesdataGridView);
            this.Name = "mtypefrm";
            this.Text = "Membership Types";
            this.Load += new System.EventHandler(this.mtypefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MtypesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MtypesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mtypeBindingSource;
        private string Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.NumericUpDown costUpDown;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.Label label3;
    }
}