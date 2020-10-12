using AspProject.Models.BlogSidebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class BlogSidebarViewModel
    {
        public List<BlogSidebarBlog> BlogSidebarBlogs { get; set; }
        public List<BlogSidebarBlogItem> BlogSidebarBlogItems { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
