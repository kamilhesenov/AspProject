using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.BlogSidebar
{
    public class BlogSidebarBlogItem
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(200)]
        public string Subject { get; set; }

        [Column(TypeName ="date")]
        public DateTime Date { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        [Column(TypeName = "date")]
        public DateTime AddedDate { get; set; }
    }
}
