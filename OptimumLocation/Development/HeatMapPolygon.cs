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
    class HeatMapPolygon : GMapPolygon
    {
        public Bitmap bitmap;
        public HeatMapPolygon(List<PointLatLng> points, string name):
            base(points, name)
        {

            this.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));

            this.Stroke = new Pen(Color.Red);
        }

        public override void OnRender(Graphics g)
        {
            bitmap = CommuteTimeMap.TestHeatMapTwo(Points);

            int width = Convert.ToInt32(base.LocalPoints[1].X - base.LocalPoints[0].X);
            int height = Convert.ToInt32(base.LocalPoints[3].Y - base.LocalPoints[0].Y);
            //if (width > base.Overlay.Control.Width)
            //{
            //    width = base.Overlay.Control.Width;
            //}

            //if (height > base.Overlay.Control.Height)
            //{
            //    height = base.Overlay.Control.Height;
            //}
            bitmap = new Bitmap(bitmap, new Size(width, height));
            g.DrawImage(bitmap, base.LocalPoints[0].X, base.LocalPoints[0].Y);

            base.OnRender(g);
        }
    }
}
