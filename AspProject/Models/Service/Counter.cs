using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.Service
{
    public class Counter
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        public int Count { get; set; }

        [Required, MaxLength(50)]
        public string Heading { get; set; }

    }
}
