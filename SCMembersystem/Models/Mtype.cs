// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-08-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-23-2016
// ***********************************************************************
// <copyright file="Mtype.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// <summary>
    /// Class Mtype.
    /// </summary>
    /// <seealso cref="SCMembersystem.Models.BaseModel" />
    class Mtype : BaseModel 
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        [StringLength(25)]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        [Required]
        public decimal  cost { get; set; }
        /// <summary>
        /// Gets or sets the initfee.
        /// </summary>
        /// <value>The initfee.</value>
        [Required]
        public decimal initfee { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>The hours.</value>
        public int hours { get; set; }

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>The days.</value>
        public int days { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Mtype"/> is once.
        /// </summary>
        /// <value><c>true</c> if once; otherwise, <c>false</c>.</value>
        public bool once { get; set; }
    }
}
