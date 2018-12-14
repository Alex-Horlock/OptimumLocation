using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace optimumLocation
{
    class HeatMapPolygonMK2 : GMapPolygon
    {
        public Bitmap test;
        double currentZoom  = -1; 

        public HeatMapPolygonMK2(List<PointLatLng> points, string name):
            base(points, name)
        {

            this.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
            this.Stroke = new Pen(Color.Red);
        }

        public override void OnRender(Graphics g)
        {
            //Get the screen dimensions of bitmap

            int topLeftX = Convert.ToInt32(base.LocalPoints[0].X);
            int topLeftY = Convert.ToInt32(base.LocalPoints[0].Y);

            if (base.Overlay.Control.Zoom != currentZoom)
            {
                currentZoom = base.Overlay.Control.Zoom;

                GPoint center = base.Overlay.Control.FromLatLngToLocal(base.Overlay.Control.Position);
                int centerX = (int)center.X;
                int centerY = (int)center.Y;
                
                int width = Convert.ToInt32(base.LocalPoints[1].X - base.LocalPoints[0].X);
                int height = Convert.ToInt32(base.LocalPoints[3].Y - base.LocalPoints[0].Y);
                if (width > base.Overlay.Control.Width)
                {
                    width = base.Overlay.Control.Width;
                }

                if (height > base.Overlay.Control.Height)
                {
                    height = base.Overlay.Control.Height;
                }

                //Populate the bitmap given a rule
                test = new Bitmap(width, height);

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        PointLatLng divide = base.Overlay.Control.FromLocalToLatLng(centerX + topLeftX + x, centerY + topLeftY + y);
                        if (divide.Lat > 50.8)
                        {
                            if (divide.Lng < -1.15)
                            {
                                test.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                            }
                            else
                            {
                                test.SetPixel(x, y, Color.FromArgb(255, 255, 255, 0));
                            }
                        }
                        else
                        {
                            test.SetPixel(x, y, Color.FromArgb(255, 0, 0, 255));
                        }
                    }
                }

            }

            g.DrawImage(test, topLeftX, topLeftY);

            base.OnRender(g);
        }
    }
}
