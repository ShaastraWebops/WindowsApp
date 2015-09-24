using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace Shaastra
{
    public class positionData
    {
        public int alt { get; set; }
        public double lati { get; set; }
        public double longi { get; set; }
    }
    public class locationData
    {        
        public string Name { get; set; }
        public string Serial { get; set; }
        public int alt { get; set; }
        public double lati { get; set; }
        public double longi { get; set; }
        public Geopoint Point { get; set; }
    }
    public class locations
    {
        public List<locationData> Items { get; set; }
        public locations()
        {
            this.Items = new List<locationData>();
        }
        public void setPoints()
        {
            foreach(locationData ldt in this.Items)
            {
                BasicGeoposition tmp = new BasicGeoposition();
                tmp.Altitude = ldt.alt;
                tmp.Latitude = ldt.lati;
                tmp.Longitude = ldt.longi;
                ldt.Point = new Geopoint(tmp);
            }
        }
            
    }
}
