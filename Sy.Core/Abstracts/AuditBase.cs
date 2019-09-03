using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sy.Core.Abstracts
{
    public abstract class AuditBase
    {
       
        [StringLenght(50)]
        public string CreatedUSer { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLenght(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; } //null yapmak için soru işareti koyuyoruz


    }
}
