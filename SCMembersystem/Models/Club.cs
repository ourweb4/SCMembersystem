// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-18-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-18-2016
// ***********************************************************************
// <copyright file="Club.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// <summary>
    /// Class Club.
    /// </summary>
    /// <seealso cref="SCMembersystem.Models.BaseModel" />
    class Club : BaseModel
    {
        /// <summary>
        /// Gets or sets the clubname.
        /// </summary>
        /// <value>The clubname.</value>
        [Required]
        [StringLength(50)]
        public string clubname { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [Required]
        [StringLength(50)]
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [Required]
        [StringLength(50)]
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [Required]
        [StringLength(50)]
        public string state { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>The zip.</value>
        [Required]
        [StringLength(50)]
        public string zip { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        [Required]
        [StringLength(50)]
        public string phone { get; set; }


        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>The website.</value>
        [StringLength(50)]
        public string website { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [StringLength(50)]
        public string email { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Club"/> is trackhours.
        /// </summary>
        /// <value><c>true</c> if trackhours; otherwise, <c>false</c>.</value>
        public bool  trackhours{ get; set; }
        /// <summary>
        /// Gets or sets the hours percent.
        /// </summary>
        /// <value>The hours percent.</value>
        public int  hours_percent { get; set; }
    }
}
