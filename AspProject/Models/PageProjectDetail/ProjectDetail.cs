using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.PageProjectDetail
{
    public class ProjectDetail
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Photo { get; set; }
    }
}
