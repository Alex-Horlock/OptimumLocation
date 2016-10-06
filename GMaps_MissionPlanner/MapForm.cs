using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using whereToLive.Functions;
using whereToLive.Structs;
using System.IO;

namespace whereToLive
{
    public partial class MapForm : Form
    {
        GMapOverlay destinationOverlay;
        GMapOverlay commuteOverlay;
        GMapMarker currentMarker;

        public MapForm()
        {
            InitializeComponent();

            myMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            myMap.SetPositionByKeywords("Southampton, UK");
            myMap.Zoom = 10;
            myMap.DragButton = MouseButtons.Left;

            destinationOverlay = new GMapOverlay("Destinations");
            commuteOverlay = new GMapOverlay("Commute");
            myMap.Overlays.Add(destinationOverlay);
            myMap.Overlays.Add(commuteOverlay);

        }

        private void addDestionationButton_Click(object sender, EventArgs e)
        {
            AddDestinationMarker(myMap.Position, visitsPerWeekMaskedTextBox.Text);

            int n = destinationDataGridView.Rows.Add();

            destinationDataGridView.Rows[n].Cells[0].Value = destinationIDTextBox.Text;
            destinationDataGridView.Rows[n].Cells[1].Value = visitsPerWeekMaskedTextBox.Text;
        }

        private void myMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng currentMousePosition = myMap.FromLocalToLatLng(e.X, e.Y);
            commuteDistanceKmLabel.Text = string.Format("{0:F2}", (CommuteDistance.GetCommuteDistanceM(currentMousePosition, destinationOverlay.Markers.ToList()) / 1000));
        }   

        // ====== GMAP Events ======

        private void myMap_OnMarkerEnter(GMapMarker item)
        {
            currentMarker = item;
        }

        private void myMap_OnMarkerLeave(GMapMarker item)
        {
            currentMarker = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commute currentCommute = GetCurrentCommute();    

            XmlSerializer x = new XmlSerializer(typeof(Commute));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";

            string saveFileName = "My Commute";
            saveFileDialog.FileName = saveFileName;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myWriter = new StreamWriter(saveFileDialog.FileName);
                x.Serialize(myWriter, currentCommute);
                myWriter.Close();
            }  
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer x = new XmlSerializer(typeof(Commute));
                StreamReader myReader = new StreamReader(loadFileDialog.FileName);
                
                Commute loadedCommute = (Commute)x.Deserialize(myReader);

                foreach( Destination destination in loadedCommute.destinations)
                {
                    AddDestinationMarker(destination.location, string.Format("{0:F0}", destination.visitsPerWeek));
                }
            }
        }

        private void AddDestinationMarker(PointLatLng p, string visits)
        {
            GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.black_small);
            marker.ToolTipText = "ID: " + destinationIDTextBox.Text + "\n" + "Freq: " + visits;
            marker.Tag = visits;
            destinationOverlay.Markers.Add(marker);
        }

        private void calculateToolStripButton_Click(object sender, EventArgs e)
        {
            Commute currentCommute = GetCurrentCommute();
            PointLatLng p = CommuteDistance.FindWeightedCenterOfCommute(currentCommute);

            GMapMarker home = new GMarkerGoogle(p, GMarkerGoogleType.red);
            commuteOverlay.Markers.Add(home);
        }

        private Commute GetCurrentCommute()
        {
            Commute currentCommute = new Commute();
            currentCommute.destinations = new Destination[destinationOverlay.Markers.Count];

            for (int i = 0; i < destinationOverlay.Markers.Count; i++)
            {
                currentCommute.destinations[i].location = destinationOverlay.Markers[i].Position;
                currentCommute.destinations[i].visitsPerWeek = Convert.ToDouble(destinationOverlay.Markers[i].Tag);
            }

            return currentCommute;
        }
    }
}
