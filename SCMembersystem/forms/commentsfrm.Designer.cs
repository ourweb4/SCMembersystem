namespace SCMembersystem.forms
{
    partial class commentsfrm
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
            this.namelab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commenttxt = new System.Windows.Forms.TextBox();
            this.newbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.Location = new System.Drawing.Point(13, 13);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(35, 13);
            this.namelab.TabIndex = 0;
            this.namelab.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comment";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(105, 314);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // commenttxt
            // 
            this.commenttxt.Location = new System.Drawing.Point(105, 359);
            this.commenttxt.Name = "commenttxt";
            this.commenttxt.Size = new System.Drawing.Size(540, 20);
            this.commenttxt.TabIndex = 4;
            this.commenttxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newbut
            // 
            this.newbut.Location = new System.Drawing.Point(86, 425);
            this.newbut.Name = "newbut";
            this.newbut.Size = new System.Drawing.Size(75, 23);
            this.newbut.TabIndex = 5;
            this.newbut.Text = "New";
            this.newbut.UseVisualStyleBackColor = true;
            this.newbut.Click += new System.EventHandler(this.newbut_Click);
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(201, 425);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 6;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.commentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 191);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // commentsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.newbut);
            this.Controls.Add(this.commenttxt);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelab);
            this.Name = "commentsfrm";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.commentsfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox commenttxt;
        private System.Windows.Forms.Button newbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commentBindingSource;
    }
}