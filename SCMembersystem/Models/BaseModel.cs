/// @file Models\BaseModel.cs
///
/// Implements the base model class.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// A data Model for the base.
    ///
    /// @author Bill Banks - office@ourweb.net
    /// @date 8/16/2016

    class BaseModel
    {
        /// Gets or sets the identifier.
        ///
        /// @return The identifier.

        [Key]
        [Required]
        public int Id { get; set; }

        /// Gets or sets the Date/Time of the updated on.
        ///
        /// @return The updated on.

       
        public DateTime? UpdatedOn { get; set; }

        
    }
}
