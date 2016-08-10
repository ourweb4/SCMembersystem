using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    class Member: BaseModel
    {
        public virtual  Mtype mtypeh { get; set; }

        [Required]
        public int mtype { get; set; } 
        
        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string lastname { get; set; }
        [Required]
        [StringLength(50)]
        public string address { get; set; }
        [Required]
        [StringLength(50)]
        public string city { get; set; }
        [Required]
        [StringLength(50)]
        public string state { get; set; }
        [Required]
        [StringLength(50)]
        public string zip { get; set; }
        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string cell { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(50)]
        public string employedby { get; set; }
        [Required]
        [StringLength(50)]
        public string occupation { get; set; }
    

        public  DateTime dob { get; set; }

        [Required]
        
        public DateTime join { get; set; }

        public bool fid { get; set; }
        public bool  ltc { get; set; }
        public bool fishing { get; set; }
        public bool hunting { get; set; }
        public bool goal { get; set; }

        public bool nra { get; set; }

        public string  committees { get; set; }

        //tract fields

        public int hours { get; set; }

        public decimal amtdue { get; set; }

        public DateTime nextbill { get; set; }




    }
}
