// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 10-01-2016
//
// Last Modified By : Bill
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="Mailfrm.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMembersystem.forms
{
    /// <summary>
    /// Class Mailfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Mailfrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mailfrm"/> class.
        /// </summary>
        public Mailfrm()
        {
            InitializeComponent();

            loadsetting();
        }

        /// <summary>
        /// Loadsettings this instance.
        /// </summary>
        private void loadsetting()
        {
            mailservertxt.Text = Properties.Settings.Default.mailserver;
            porttxt.Text = Properties.Settings.Default.mailport;
            emailtxt.Text = Properties.Settings.Default.fromemail;
            usernametxt.Text = Properties.Settings.Default.mailuser;
            passwordtxt.Text = Properties.Settings.Default.mailpass;
        }

        /// <summary>
        /// Savesettings this instance.
        /// </summary>
        private void savesetting()
        {
            Properties.Settings.Default.mailserver = mailservertxt.Text;
            Properties.Settings.Default.mailport = porttxt.Text;
            Properties.Settings.Default.fromemail = emailtxt.Text;
            Properties.Settings.Default.mailuser = usernametxt.Text;
            Properties.Settings.Default.mailpass = passwordtxt.Text;

            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {
            savesetting();

            if (testemailcheckBox.Checked)
            {
                var email = new USendMail();
                email.Subject = "Test Message from SC";
                var from = emailtxt.Text;
                email.To = String.Format("office@ourweb.net, {0}", from);
                email.emailine("Testing");
                email.send();
            }



            this.Close();
        }

        private void Mailfrm_Load(object sender, EventArgs e)
        {

        }

        private void porttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
