using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class HomeServiceItem : BaseEntity
    {
        [Required, MaxLength(200)]
        public string Info { get; set; }

        [Required, MaxLength(100)]
        public string Icon { get; set; }
    }
}
