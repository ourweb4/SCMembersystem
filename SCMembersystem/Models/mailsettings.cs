// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 10-01-2016
//
// Last Modified By : Bill
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="mailsettings.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// <summary>
    /// Class mailsettings.
    /// </summary>
    class mailsettings
    {
        /// <summary>
        /// The mailservertxt
        /// </summary>
        public string mailservertxt;
        /// <summary>
        /// The porttxt
        /// </summary>
        public string porttxt;
        /// <summary>
        /// The emailtxt
        /// </summary>
        public string emailtxt;
        /// <summary>
        /// The usernametxt
        /// </summary>
        public string usernametxt;
        /// <summary>
        /// The passwordtxt
        /// </summary>
        public string passwordtxt;
        /// <summary>
        /// Initializes a new instance of the <see cref="mailsettings"/> class.
        /// </summary>
        public mailsettings()
        {
            mailservertxt = Properties.Settings.Default.mailserver;
            porttxt = Properties.Settings.Default.mailport;
            emailtxt = Properties.Settings.Default.fromemail;
            usernametxt = Properties.Settings.Default.mailuser;
            passwordtxt = Properties.Settings.Default.mailpass;

        }
    }
}
