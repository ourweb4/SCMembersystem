using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class Comment: BaseModel
    {
        [Required]
        public int memberid { get;  set; }

        public DateTime cdate { get; set; }
        [StringLength(255)]

        public string comment { get; set; }


    }
}
