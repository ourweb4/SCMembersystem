// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-08-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-16-2016
// ***********************************************************************
// <copyright file="Invoice.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
/// @file Models\Invoice.cs
///
/// Implements the invoice class.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{

    /// <summary>
    /// Class Invoice.
    /// </summary>
    /// <seealso cref="SCMembersystem.Models.BaseModel" />
    class Invoice : BaseModel
    {

        /// <summary>
        /// Gets or sets the member.
        /// </summary>
        /// <value>The member.</value>
        public virtual Member member { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>The member identifier.</value>
        [Required]
        public int memberId { get; set; }

        /// <summary>
        /// Gets or sets the invdate.
        /// </summary>
        /// <value>The invdate.</value>
        public DateTime invdate { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [Required]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or sets the paidamount.
        /// </summary>
        /// <value>The paidamount.</value>
        public decimal paidamount { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [StringLength(100)]
        public string  description { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>The hours.</value>
        public int  hours { get; set; }
    }
}
