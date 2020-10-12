using AspProject.Models.Home;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class HomePortfolioItem : BaseEntity
    {
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(50)]
        public string Category { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }


    }
}
