using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.Project
{
    public class ProjectPricing
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        public int Price { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
