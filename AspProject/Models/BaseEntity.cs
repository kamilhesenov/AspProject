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

        [Column(TypeName ="date")]
        public DateTime? AddedDate { get; set; }
       
        [Required,MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(500)]
        public string Content { get; set; }
    }
}
