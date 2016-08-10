using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        
        [Required]
        public DateTime UpdatedOn { get; set; }

        
    }
}
