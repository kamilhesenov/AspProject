using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.PageProjectDetail
{
    public class ProjectDetailItem
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Heading { get; set; }

        [Required, MaxLength(50)]
        public string Subject { get; set; }
    }
}
