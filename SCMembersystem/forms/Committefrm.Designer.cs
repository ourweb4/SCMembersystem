namespace SCMembersystem.forms
{
    partial class Committefrm
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
            this.CommittedataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.addbut = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CommittedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CommittedataGridView
            // 
            this.CommittedataGridView.AllowUserToAddRows = false;
            this.CommittedataGridView.AutoGenerateColumns = false;
            this.CommittedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommittedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn});
            this.CommittedataGridView.DataSource = this.committeBindingSource;
            this.CommittedataGridView.Location = new System.Drawing.Point(118, 57);
            this.CommittedataGridView.Name = "CommittedataGridView";
            this.CommittedataGridView.Size = new System.Drawing.Size(602, 192);
            this.CommittedataGridView.TabIndex = 0;
            this.CommittedataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommittedataGridView_CellEndEdit);
            this.CommittedataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.CommittedataGridView_UserDeletingRow);
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
            // committeBindingSource
            // 
            this.committeBindingSource.DataSource = typeof(SCMembersystem.Models.Committe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(216, 349);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(346, 20);
            this.nametxt.TabIndex = 2;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(281, 417);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 23);
            this.addbut.TabIndex = 3;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // Committefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 677);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommittedataGridView);
            this.Name = "Committefrm";
            this.Text = "Committees";
            this.Load += new System.EventHandler(this.Committefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommittedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CommittedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource committeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}