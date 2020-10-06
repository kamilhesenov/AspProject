using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class Hero : BaseEntity
    {
        [Required,MaxLength(50)]
        public string Heading { get; set; }

        [Required, MaxLength(100)]
        public string Photo { get; set; }
        
    }
}
