using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace optimumLocation
{
    static class CommuteTimeMap
    {
        public static Bitmap TestHeatMap()
        {
            Bitmap test = new Bitmap(100, 100);

            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    test.SetPixel(x, y, Color.FromArgb(150, x * 2, y * 2 ,0));
                }
            }
            return test;
        }

        public static Bitmap TestHeatMapTwo(List<PointLatLng> localPoints)
        {
            
            Bitmap test = new Bitmap(1000, 1000);

            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {

                    if (localPoints[0].Lat > 50.85)
                    {
                        test.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                    }
                    else
                    {
                        test.SetPixel(x, y, Color.FromArgb(255, 0, 0, 255));
                    }
                    
                }
            }
            return test;
        }


    }
}
