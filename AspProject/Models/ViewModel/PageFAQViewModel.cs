using AspProject.Models.PageFAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class PageFAQViewModel
    {
        public List<PageFaqPromo> PageFaqPromos { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
