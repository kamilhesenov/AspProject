using AspProject.Models.About;
using System.Collections.Generic;

namespace AspProject.Models.ViewModel
{
    public class AboutViewModel
    {
        public List<Models.HomeTeamTwoItem> HomeTeamTwoItems { get; set; }
        public List<AboutPromo> AboutPromos { get; set; }
        public Models.About.About Abouts { get; set; }
        public List<AboutItem> AboutItems { get; set; }
        public List<OurWorkProcess> OurWorkProcesses { get; set; }
        public List<AboutTestimonial> AboutTestimonials { get; set; }
        public List<Client> Clients { get; set; }
    }
}
