using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace whereToLive.Structs
{
    public struct Commute
    {
        public Destination[] destinations;
        //public GMapMarker[] destinations;
    }

    public struct Destination
    {
        public PointLatLng location;
        public double visitsPerWeek;
    }
}
