using AspProject.Models.PageProjectDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class PageProjectDetailViewModel
    {
        public ProjectDetail ProjectDetail { get; set; }
        public List<ProjectDetailItem> ProjectDetailItems { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
