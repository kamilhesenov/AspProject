using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class AboutUs : BaseEntity
    {
        

        [Required, MaxLength(100)]
        public string Photo { get; set; }
        
    }
}
