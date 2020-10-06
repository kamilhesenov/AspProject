using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public class Setting : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }

        [Required, MaxLength(50)]
        public string Phone { get; set; }

        [Required, MaxLength(100)]
        public string Facebook { get; set; }

        [Required, MaxLength(100)]
        public string Twitter { get; set; }

        [Required, MaxLength(100)]
        public string Linkedin { get; set; }

        [Required, MaxLength(100)]
        public string Dribbble { get; set; }

    }
}
