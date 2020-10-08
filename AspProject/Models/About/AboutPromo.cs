using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.About
{
    public class AboutPromo : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Icon { get; set; }
    }
}
