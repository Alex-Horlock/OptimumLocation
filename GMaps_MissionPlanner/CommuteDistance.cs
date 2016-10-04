using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace whereToLive.Functions
{
    public static class CommuteDistance
    {
        public static double GetCommuteDistanceM(PointLatLng home, List<GMapMarker> destinationList)
        {
            double dist = 0;

            foreach (GMapMarker destination in destinationList)
            {
                dist += destination.Position.getDistanceToPointLatLng(home) * Convert.ToDouble(destination.Tag);
            }
            return dist;
        }


        private static double getDistanceToPointLatLng(this PointLatLng p1, PointLatLng p2)
        {
            double rEarthM = 6371000;
            double deltaY = ((p1.Lat - p2.Lat) / 360) * 2 * Math.PI * rEarthM;
            double rEarthMLatAdjustedM = Math.Cos(((p1.Lat + p2.Lat) / 2) * (Math.PI / 180)) * rEarthM;
            double deltaX = ((p1.Lng - p2.Lng) / 360) * 2 * Math.PI * rEarthMLatAdjustedM;
            double dist = Math.Sqrt(Math.Pow((deltaY), 2) + Math.Pow((deltaX), 2));

            return dist;
        }
    }
}
