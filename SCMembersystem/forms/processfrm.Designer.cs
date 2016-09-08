namespace SCMembersystem.forms
{
    partial class processfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runninglab = new System.Windows.Forms.Label();
            this.fromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourcheckBox = new System.Windows.Forms.CheckBox();
            this.processbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // runninglab
            // 
            this.runninglab.AutoSize = true;
            this.runninglab.Location = new System.Drawing.Point(211, 354);
            this.runninglab.Name = "runninglab";
            this.runninglab.Size = new System.Drawing.Size(67, 13);
            this.runninglab.TabIndex = 2;
            this.runninglab.Text = "Not Running";
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.Location = new System.Drawing.Point(142, 37);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromdateTimePicker.TabIndex = 3;
            // 
            // todateTimePicker
            // 
            this.todateTimePicker.Location = new System.Drawing.Point(142, 78);
            this.todateTimePicker.Name = "todateTimePicker";
            this.todateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.todateTimePicker.TabIndex = 4;
            // 
            // hourcheckBox
            // 
            this.hourcheckBox.AutoSize = true;
            this.hourcheckBox.Location = new System.Drawing.Point(142, 138);
            this.hourcheckBox.Name = "hourcheckBox";
            this.hourcheckBox.Size = new System.Drawing.Size(92, 17);
            this.hourcheckBox.TabIndex = 5;
            this.hourcheckBox.Text = "Include Hours";
            this.hourcheckBox.UseVisualStyleBackColor = true;
            // 
            // processbut
            // 
            this.processbut.Location = new System.Drawing.Point(142, 224);
            this.processbut.Name = "processbut";
            this.processbut.Size = new System.Drawing.Size(75, 23);
            this.processbut.TabIndex = 6;
            this.processbut.Text = "Process";
            this.processbut.UseVisualStyleBackColor = true;
            this.processbut.Click += new System.EventHandler(this.processbut_Click);
            // 
            // processfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.processbut);
            this.Controls.Add(this.hourcheckBox);
            this.Controls.Add(this.todateTimePicker);
            this.Controls.Add(this.fromdateTimePicker);
            this.Controls.Add(this.runninglab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "processfrm";
            this.Text = "Process Invoices";
            this.Load += new System.EventHandler(this.processfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label runninglab;
        private System.Windows.Forms.DateTimePicker fromdateTimePicker;
        private System.Windows.Forms.DateTimePicker todateTimePicker;
        private System.Windows.Forms.CheckBox hourcheckBox;
        private System.Windows.Forms.Button processbut;
    }
}