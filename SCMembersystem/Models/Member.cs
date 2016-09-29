// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-09-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-28-2016
// ***********************************************************************
// <copyright file="Member.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// <summary>
    /// Class Member.
    /// </summary>
    /// <seealso cref="SCMembersystem.Models.BaseModel" />
    class Member : BaseModel
    {
        /// <summary>
        /// Gets or sets the mtypeh.
        /// </summary>
        /// <value>The mtypeh.</value>
        public virtual  Mtype mtypeh { get; set; }

        /// <summary>
        /// Gets or sets the mtype.
        /// </summary>
        /// <value>The mtype.</value>
        [Required]
        public int mtype { get; set; }

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        /// <value>The firstname.</value>
        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        /// <value>The lastname.</value>
        [Required]
        [StringLength(50)]
        public string lastname { get; set; }
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
        /// Gets or sets the cell.
        /// </summary>
        /// <value>The cell.</value>

        [StringLength(50)]
        public string cell { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>

        [StringLength(50)]
        public string email { get; set; }
        /// <summary>
        /// Gets or sets the employedby.
        /// </summary>
        /// <value>The employedby.</value>
       // [Required]
        [StringLength(50)]
        public string employedby { get; set; }
        /// <summary>
        /// Gets or sets the occupation.
        /// </summary>
        /// <value>The occupation.</value>
       // [Required]
        [StringLength(50)]
        public string occupation { get; set; }


        /// <summary>
        /// Gets or sets the dob.
        /// </summary>
        /// <value>The dob.</value>
        public DateTime dob { get; set; }

        /// <summary>
        /// Gets or sets the join.
        /// </summary>
        /// <value>The join.</value>


        public DateTime join { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is fid.
        /// </summary>
        /// <value><c>true</c> if fid; otherwise, <c>false</c>.</value>
        public bool fid { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is LTC.
        /// </summary>
        /// <value><c>true</c> if LTC; otherwise, <c>false</c>.</value>
        public bool  ltc { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is fishing.
        /// </summary>
        /// <value><c>true</c> if fishing; otherwise, <c>false</c>.</value>
        public bool fishing { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is hunting.
        /// </summary>
        /// <value><c>true</c> if hunting; otherwise, <c>false</c>.</value>
        public bool hunting { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is goal.
        /// </summary>
        /// <value><c>true</c> if goal; otherwise, <c>false</c>.</value>
        public bool goal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is nra.
        /// </summary>
        /// <value><c>true</c> if nra; otherwise, <c>false</c>.</value>
        public bool nra { get; set; }
        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>The invoices.</value>
        public OLS<Invoice> Invoices { get; set; }
        /// <summary>
        /// Gets or sets the committees.
        /// </summary>
        /// <value>The committees.</value>
        public string  committees { get; set; }

        //tract fields

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>The hours.</value>
        public int hours { get; set; }

        /// <summary>
        /// Gets or sets the amtdue.
        /// </summary>
        /// <value>The amtdue.</value>
        public decimal amtdue { get; set; }

        /// <summary>
        /// Gets or sets the nextbill.
        /// </summary>
        /// <value>The nextbill.</value>
        public DateTime nextbill { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool active { get; set; }
        /// <summary>
        /// Gets or sets the keycard.
        /// </summary>
        /// <value>The keycard.</value>
        public string keycard { get; set; }
        /// <summary>
        /// Gets or sets the keymain.
        /// </summary>
        /// <value>The keymain.</value>
        public string keymain { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is mainactive.
        /// </summary>
        /// <value><c>true</c> if mainactive; otherwise, <c>false</c>.</value>
        public bool mainactive { get; set; }
        /// <summary>
        /// Gets or sets the keyrange.
        /// </summary>
        /// <value>The keyrange.</value>
        public string keyrange { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member" /> is rangeactive.
        /// </summary>
        /// <value><c>true</c> if rangeactive; otherwise, <c>false</c>.</value>
        public bool rangeactive { get; set; }

        /// <summary>
        /// Gets or sets the fob.
        /// </summary>
        /// <value>The fob.</value>
        public string fob { get; set; }
        /// <summary>
        /// Gets or sets the fobmain.
        /// </summary>
        /// <value>The fobmain.</value>
        public string fobmain { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member"/> is fobmainactive.
        /// </summary>
        /// <value><c>true</c> if fobmainactive; otherwise, <c>false</c>.</value>
        public bool fobmainactive { get; set; }
        /// <summary>
        /// Gets or sets the fobrange.
        /// </summary>
        /// <value>The fobrange.</value>
        public string fobrange { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Member"/> is fobrangractive.
        /// </summary>
        /// <value><c>true</c> if fobrangractive; otherwise, <c>false</c>.</value>
        public bool fobrangractive { get; set; }
    }
}
