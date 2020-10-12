using AspProject.Models.About;
using AspProject.Models.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class ProjectViewModel
    {
        public List<AboutTestimonial> AboutTestimonials { get; set; }
        public List<HomePortfolioItem> HomePortfolioItems { get; set; }
        public List<Client> Clients { get; set; }
        public ProjectCounter ProjectCounter { get; set; }
        public List<ProjectPricing> ProjectPricings { get; set; }
        public List<ProjectPricingItem> ProjectPricingItems { get; set; }
        public HeaderViewModel HeaderViewModel { get; set; }
    }
}
