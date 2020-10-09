using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.Service
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad bos ola bilmez"),MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-poct bos ola bilmez"), MaxLength(100, ErrorMessage = "Maksimum 100 xarakter olmalidir")]
        
        public string Email { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }
    }
}
