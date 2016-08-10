using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class Mtype: BaseModel 
    {
        [Required]
        [StringLength(25)]
        public string name { get; set; }

        [Required]
        public decimal  cost { get; set; }

        public int hours { get; set; }
    }
}
