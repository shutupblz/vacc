using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    public class User
    {
        [Required]
        [Range(1,100000)]
        public string name { get; set; }
        [Required]
        public int idnum { get; set; }
        [Required]
        public string pass { get; set; }
        [Required]
        public string combogen { get; set; }
        public int age { get; set; }
        public string governate{ get; set; }
        public bool vaccinated { get; set; }
        public int dosagesNum{ get; set; }


    }
}
