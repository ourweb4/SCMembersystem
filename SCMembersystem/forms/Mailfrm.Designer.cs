namespace SCMembersystem.forms
{
    partial class Mailfrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailservertxt = new System.Windows.Forms.TextBox();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.savebut = new System.Windows.Forms.Button();
            this.testemailcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail  Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // mailservertxt
            // 
            this.mailservertxt.Location = new System.Drawing.Point(129, 28);
            this.mailservertxt.Name = "mailservertxt";
            this.mailservertxt.Size = new System.Drawing.Size(631, 20);
            this.mailservertxt.TabIndex = 5;
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(129, 67);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(100, 20);
            this.porttxt.TabIndex = 6;
            this.porttxt.TextChanged += new System.EventHandler(this.porttxt_TextChanged);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(129, 112);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(482, 20);
            this.emailtxt.TabIndex = 7;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(129, 166);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(465, 20);
            this.usernametxt.TabIndex = 8;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(123, 225);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(471, 20);
            this.passwordtxt.TabIndex = 9;
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(148, 362);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 10;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // testemailcheckBox
            // 
            this.testemailcheckBox.AutoSize = true;
            this.testemailcheckBox.Location = new System.Drawing.Point(148, 272);
            this.testemailcheckBox.Name = "testemailcheckBox";
            this.testemailcheckBox.Size = new System.Drawing.Size(75, 17);
            this.testemailcheckBox.TabIndex = 11;
            this.testemailcheckBox.Text = "Test Email";
            this.testemailcheckBox.UseVisualStyleBackColor = true;
            // 
            // Mailfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 478);
            this.Controls.Add(this.testemailcheckBox);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.mailservertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mailfrm";
            this.Text = "Mail Settings";
            this.Load += new System.EventHandler(this.Mailfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailservertxt;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.CheckBox testemailcheckBox;
    }
}