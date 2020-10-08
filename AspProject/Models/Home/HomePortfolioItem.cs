using AspProject.Models.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class HomePortfolioItem : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(50)]
        public string Category { get; set; }

        
    }
}
