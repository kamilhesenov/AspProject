using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class HomeViewModel
    {
        public AboutUs AboutUs { get; set; }
        public DownloadApp DownloadApp { get; set; }
        public DownloadAppStor DownloadAppStor { get; set; }
        public Hero Hero { get; set; }
        public HomeCallToAction HomeCallToAction { get; set; }
        public HomeOurNew HomeOurNew { get; set; }
        public HomeOurNewsItem HomeOurNewsItem { get; set; }
        public HomePortfolio HomePortfolio { get; set; }
        public HomePortfolioItem HomePortfolioItem { get; set; }
        public HomeService HomeService { get; set; }
        public HomeServiceItem HomeServiceItem { get; set; }
        public HomeTeamTwo HomeTeamTwo { get; set; }
        public HomeTeamTwoItem HomeTeamTwoItem { get; set; }
        public Promo Promo { get; set; }
        public Setting Setting { get; set; }
        public Testimonial Testimonial { get; set; }
        public TestemonialItem TestemonialItem { get; set; }

    }
}
