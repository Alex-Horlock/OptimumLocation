using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace optimumLocation
{
    public class DestinationMarker : GMarkerGoogle
    {
        public double VisitsPerWeek;
        public string destinationUid;

        public DestinationMarker(PointLatLng p, GMarkerGoogleType type)
            : base(p, type)
        {
           
        }
    }
}
