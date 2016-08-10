using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class Committe: BaseModel
    {
        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
