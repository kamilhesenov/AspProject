using AspProject.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class HomeViewModel
    {
        public Hero Hero { get; set; }
        public List<Promo> Promos { get; set; }
        public AboutUs AboutUs { get; set; }
        public List<AboutUsItem> AboutUsItems { get; set; }
        public List<HomeServiceItem> HomeServiceItems { get; set; }
        public List<HomePortfolioItem> HomePortfolioItems { get; set; }
        public List<HomeOurNewsItem> HomeOurNewsItems { get; set; }
        public Testimonial Testimonial { get; set; }
        public List<TestemonialItem> TestemonialItems { get; set; }
        public List<HomeTeamTwoItem> HomeTeamTwoItems { get; set; }
        public Setting Setting { get; set; }
        public SocialLink SocialLink { get; set; }
    }
}
