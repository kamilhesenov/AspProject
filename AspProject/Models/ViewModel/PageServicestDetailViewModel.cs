using AspProject.Models.PageServicesDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class PageServicestDetailViewModel
    {
        public ServicesDetail ServicesDetail { get; set; }
        public List<ServicesDetailItem> ServicesDetailItems { get; set; }
        public Setting Setting { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
