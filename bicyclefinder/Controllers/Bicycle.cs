using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bicyclefinder.Controllers
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string FrameNumber { get; set; }
        public string KindOfBicycle { get; set; }
        public string Brand { get; set; }
        public string Colors { get; set; }
        public string Place { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }

        public string LostFound { get; set; }

        public override string ToString()
        {
            return Brand + " " + Place;
        }
    }
}
