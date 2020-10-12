using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.About
{
    public class AboutTestimonial
    {
        public int Id { get; set; }

        [Required, MaxLength(500)]
        public string Text { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(50)]
        public string Position { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        public byte Star { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
