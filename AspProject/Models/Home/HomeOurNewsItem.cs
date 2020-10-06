using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class HomeOurNewsItem : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Photo { get; set; }
        
        [Required, MaxLength(50)]
        public string Label { get; set; }

        [Required, MaxLength(150)]
        public string Heading { get; set; }
    }
}
