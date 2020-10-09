using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.PageFAQ
{
    public class PageFaqPromo : BaseEntity
    {
        [Required,MaxLength(100)]
        public string Icon { get; set; }
    }
}
