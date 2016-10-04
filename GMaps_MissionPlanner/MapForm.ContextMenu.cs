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
using whereToLive.Functions;

namespace whereToLive
{
    public partial class MapForm : Form
    {
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMarker.Overlay == destinationOverlay)
            {
                destinationOverlay.Markers.Remove(currentMarker);
                currentMarker = null;
            }
        }

    }
}
