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
    /// An invoice.
    ///
    /// @author Bill Banks - office@ourweb.net
    /// @date 8/16/2016

    class Invoice: BaseModel
    {
        /// Gets or sets the member.
        ///
        /// @return The member.

        public virtual Member member { get; set; }

        /// Gets or sets the identifier of the member.
        ///
        /// @return The identifier of the member.

        [Required]
        public int memberId { get; set; }

        /// Gets or sets the Date/Time of the invdate.
        ///
        /// @return The invdate.

        public DateTime invdate { get; set; }

        /// Gets or sets the amount.
        ///
        /// @return The amount.

        [Required]
        public decimal amount { get; set; }

        /// Gets or sets the paidamount.
        ///
        /// @return The paidamount.

        public decimal paidamount { get; set; }

        /// Gets or sets the description.
        ///
        /// @return The description.

        [StringLength(100)]
        public string  description { get; set; }
    }
}
