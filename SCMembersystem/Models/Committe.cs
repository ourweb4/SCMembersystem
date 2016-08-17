/// @file Models\Committe.cs
///
/// Implements the committe class.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    /// A committe.
    ///
    /// @author Bill Banks - office@ourweb.net
    /// @date 8/16/2016

    class Committe: BaseModel
    {
        /// Gets or sets the name.
        ///
        /// @return The name.

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
