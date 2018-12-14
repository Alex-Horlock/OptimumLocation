using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using optimumLocation.Functions;

namespace optimumLocation
{
    public partial class MainForm : Form
    {

        // ====== GMAP Events ======

        private void myMap_OnMarkerEnter(GMapMarker item)
        {
            currentMarker = item;
        }

        private void myMap_OnMarkerLeave(GMapMarker item)
        {
            currentMarker = null;
        }

        private void myMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng currentMousePosition = myMap.FromLocalToLatLng(e.X, e.Y);
            commuteDistanceKmLabel.Text = string.Format("{0:F2}", (CommuteDistance.GetCommuteDistanceM(currentMousePosition,
                destinationOverlay.Markers.ToList()) / 1000));

            mouseCoordsLabel.Text = string.Format("Lat {0:F5}, Lng {1:F5}", currentMousePosition.Lat, currentMousePosition.Lng);
        }

    }
}
