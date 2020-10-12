using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class BlogDefaultViewModel
    {
        public List<HomeOurNewsItem> HomeOurNewsItems { get; set; }
        public PagingList<HomeOurNewsItem> PagingList { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
