using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class Invoice: BaseModel
    {
        public virtual Member member { get; set; }

        [Required]
        public int memberId { get; set; }
        public DateTime invdate { get; set; }
        [Required]
        public decimal amount { get; set; }

        public decimal paidamount { get; set; }

        [StringLength(100)]
        public string  description { get; set; }
    }
}
