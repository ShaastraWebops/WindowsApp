using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaastra
{
    public class eventData
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Venue { get; set; }
        public string Reg { get; set; }
        public string ImgSource { get; set; }
        public string About { get; set; }
        public string Event { get; set; }
    }
    class eventDetails
    {
        public List<eventData> Items { get; set; }
        public eventDetails()
        {
            this.Items = new List<eventData>();
        }
    }
}
