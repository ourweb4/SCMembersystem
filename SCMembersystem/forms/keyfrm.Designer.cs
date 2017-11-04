namespace SCMembersystem.forms
{
    partial class keyfrm
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
            this.keytxt = new System.Windows.Forms.TextBox();
            this.savebut = new System.Windows.Forms.Button();
            this.messkey = new System.Windows.Forms.Label();
            this.dayslab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "You must be online to regstar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // keytxt
            // 
            this.keytxt.Location = new System.Drawing.Point(239, 81);
            this.keytxt.Name = "keytxt";
            this.keytxt.Size = new System.Drawing.Size(397, 20);
            this.keytxt.TabIndex = 2;
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(375, 122);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 3;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // messkey
            // 
            this.messkey.AutoSize = true;
            this.messkey.Location = new System.Drawing.Point(333, 175);
            this.messkey.Name = "messkey";
            this.messkey.Size = new System.Drawing.Size(0, 13);
            this.messkey.TabIndex = 4;
            // 
            // dayslab
            // 
            this.dayslab.AutoSize = true;
            this.dayslab.Location = new System.Drawing.Point(297, 221);
            this.dayslab.Name = "dayslab";
            this.dayslab.Size = new System.Drawing.Size(0, 13);
            this.dayslab.TabIndex = 5;
            // 
            // keyfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 261);
            this.Controls.Add(this.dayslab);
            this.Controls.Add(this.messkey);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.keytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "keyfrm";
            this.Text = "Software Registration";
            this.Load += new System.EventHandler(this.keyfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keytxt;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Label messkey;
        private System.Windows.Forms.Label dayslab;
    }
}