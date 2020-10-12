using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class HomeOurNewsItem : BaseEntity
    {
        [MaxLength(100)]
        public string Photo { get; set; }
        
        [Required, MaxLength(50)]
        public string Label { get; set; }

        [Required, MaxLength(150)]
        public string Heading { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        [Column(TypeName = "date")]
        public DateTime AddedDate { get; set; }
    }
}
