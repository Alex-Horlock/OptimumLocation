using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace optimumLocation
{
    public class DrawPolygons
    {
        public DrawPolygons()
        {

        }

        private void DrawTestPolygon(GMapOverlay commuteOverlay)
        {
            commuteOverlay.Polygons.Clear();
            PointLatLng p0 = new PointLatLng(51.8, -1.2);
            GMapMarker test0 = new GMarkerGoogle(p0, GMarkerGoogleType.red);
            PointLatLng p1 = new PointLatLng(51.8, -1.1);
            GMapMarker test1 = new GMarkerGoogle(p1, GMarkerGoogleType.red);
            PointLatLng p2 = new PointLatLng(51.7, -1.1);
            GMapMarker test2 = new GMarkerGoogle(p2, GMarkerGoogleType.red);
            PointLatLng p3 = new PointLatLng(51.7, -1.2);
            GMapMarker tes3t = new GMarkerGoogle(p3, GMarkerGoogleType.red);


            GMapPolygon polygon;
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(p0);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            polygon = new GMapPolygon(points, "mypolygon");
            //GMapImage image = new GMapImage();
            //Bitmap bmp = new Bitmap("C:\\Users\\Alex\\Documents\\Visual Studio 2015\\Projects\\OptimumLocation\\OptimumLocation\\home-button.png");
            Bitmap bmp = CommuteTimeMap.TestHeatMap();
            //polygon.Fill = new TextureBrush(bmp);
            Brush b = new TextureBrush(bmp, System.Drawing.Drawing2D.WrapMode.Clamp);
            Brush c = new TextureBrush(bmp);

            polygon.Fill = b;

            //polygon.Stroke = new Pen(Color.Red, 1);
            GMapOverlay polyOverlay = new GMapOverlay("polygons");

            commuteOverlay.Polygons.Add(polygon);
        }

        private void DrawTestPolygonTwo(GMapOverlay commuteOverlay)
        {
            PointLatLng p0 = new PointLatLng(50.9, -1.2);
            GMapMarker test0 = new GMarkerGoogle(p0, GMarkerGoogleType.red);
            PointLatLng p1 = new PointLatLng(50.9, -1.1);
            GMapMarker test1 = new GMarkerGoogle(p1, GMarkerGoogleType.red);
            PointLatLng p2 = new PointLatLng(50.7, -1.1);
            GMapMarker test2 = new GMarkerGoogle(p2, GMarkerGoogleType.red);
            PointLatLng p3 = new PointLatLng(50.7, -1.2);
            GMapMarker tes3t = new GMarkerGoogle(p3, GMarkerGoogleType.red);

            GMapPolygon polygon;
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(p0);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);

            polygon = new HeatMapPolygonMK2(points, "alex");

            GMapOverlay polyOverlay = new GMapOverlay("polygons");

            commuteOverlay.Polygons.Add(polygon);
        }

    }

}
