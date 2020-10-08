using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.About
{
    public class AboutItem
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Heading { get; set; }

        [Required, MaxLength(50)]
        public string Subject { get; set; }
        
        [Required]
        public int Count { get; set; }

        [Required, MaxLength(50)]
        public string Label { get; set; }
    }
}
