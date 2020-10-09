using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class MessageViewModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required(), MaxLength(100)]
        public string Email { get; set; }
        public string Text { get; set; }
    }
}
