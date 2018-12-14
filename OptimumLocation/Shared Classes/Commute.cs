using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace optimumLocation.Structs
{
    public class Commute
    {
        public List<Destination> destinations;

        public Commute()
        {
            destinations = new List<Destination>();
        }
    }

    public static class ExtensionMethods
    {
        public static string GetUniqueDestinationID(this List<Destination> destinations, string prefix)
        {
            int i = 1;
            bool uniqueIDFound = false;
            while (!uniqueIDFound)
            {
                foreach (string id in destinations.Select( x=> x.destinationUid))
                {
                    if (id == prefix + i)
                    {
                        i++;
                        break;
                    }
                }

                uniqueIDFound = true;

            }

            return prefix + i;
        }
    }

   
}
