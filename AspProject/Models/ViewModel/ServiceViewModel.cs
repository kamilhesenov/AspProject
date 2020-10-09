using AspProject.Models.About;
using AspProject.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.Models.ViewModel
{
    public class ServiceViewModel
    {
        public List<HomeServiceItem> HomeServiceItems { get; set; }
        public List<Client> Clients { get; set; }
        public Setting Setting { get; set; }
        public List<ServicePromo> ServicePromos { get; set; }
        public List<Counter> Counters { get; set; }
        public Message Message { get; set; }
        public CounterPhoto CounterPhoto { get; set; }
    }
}
