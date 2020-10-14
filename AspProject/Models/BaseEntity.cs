using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title boş ola bilməz!"), MaxLength(150,ErrorMessage = "Maksimum 150 xarakter olmalıdır")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content boş ola bilməz!"), MaxLength(500, ErrorMessage = "Maksimum 500 xarakter olmalıdır")]
        public string Content { get; set; }
    }
}
