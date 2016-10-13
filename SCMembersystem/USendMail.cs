// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 10-01-2016
//
// Last Modified By : Bill
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="USendMail.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMembersystem.Models;

namespace SCMembersystem
{
    /// <summary>
    /// Class USendMail.
    /// </summary>
    class USendMail
    {
        /// <summary>
        /// The lines
        /// </summary>
        private IList<string> lines = new List<string>();

        public bool error = false;
        /// <summary>
        /// The es mailsettings
        /// </summary>

        private mailsettings esMailsettings= new mailsettings();
        /// <summary>
        /// The countline
        /// </summary>
        private int countline = 0;
        /// <summary>
        /// The subject
        /// </summary>
        private string _subject;
        /// <summary>
        /// To
        /// </summary>
        private string _to;

        /// <summary>
        /// The message
        /// </summary>
        private MailMessage message;
        /// <summary>
        /// The SMTP
        /// </summary>
        private SmtpClient smtp;

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>To.</value>
        public string To
        {
            get
            {
                return _to;
            }

            set
            {
                _to = value;
            }
        }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        /// <summary>
        /// Emailines the specified line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <returns>System.Int32.</returns>
        public int emailine(string line)
        {
            lines.Add(line);
            countline++;
            return countline;
        }

        /// <summary>
        /// Sends this instance.
        /// </summary>
        public void send()
        {
            message=new MailMessage();
            smtp=new SmtpClient(esMailsettings.mailservertxt);

            message.From = new MailAddress(esMailsettings.emailtxt);
            message.To.Add(_to);
            message.Subject = _subject;


            message.Body = "";
            foreach (var line in lines)
                message.Body += line + "\n";

            smtp.Port = Convert.ToInt32(esMailsettings.porttxt);
            smtp.Credentials=new NetworkCredential( esMailsettings.usernametxt,esMailsettings.passwordtxt);
            try
            {


                smtp.Send(message);
            }
            catch (Exception exception)
            {
                DialogResult dialogResult = MessageBox.Show(exception.Message, "Send Mail Error", MessageBoxButtons.OK);
                error = true;
            }
        }
    }
}
