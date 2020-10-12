using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.About
{
    public class About : BaseEntity
    {
        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }


    }
}
