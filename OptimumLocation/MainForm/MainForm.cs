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
using optimumLocation.Functions;
using optimumLocation.Structs;
using System.IO;
using System.Threading;

namespace optimumLocation
{
    public partial class MainForm : Form
    {
        private DataStore data;
        private GMapOverlay destinationOverlay;
        private GMapOverlay commuteOverlay;
        private GMapMarker currentMarker;

        private Thread splashScreenThread;

        private int idColumn = 0;
        private int frequencyColumn = 1;

        public MainForm()
        {          
            InitializeComponent();
            this.Hide();

            data = new DataStore();
            data.NewCommuteEvent += Data_NewCommuteEvent;

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.LoginComplete += SplashScreen_LoginComplete;
            splashScreenThread = new Thread(() => Application.Run(splashScreen));   
            splashScreenThread.Start();

            myMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            bingToolStripMenuItem.Checked = true;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            myMap.SetPositionByKeywords("Southampton, UK");
            myMap.Zoom = 10;
            myMap.DragButton = MouseButtons.Left;

            destinationOverlay = new GMapOverlay("Destinations");
            commuteOverlay = new GMapOverlay("Commute");
            myMap.Overlays.Add(destinationOverlay);
            myMap.Overlays.Add(commuteOverlay);

            destinationIDTextBox.Text = data.CurrentCommute.destinations.GetUniqueDestinationID("Destination ");
        }

        private void SplashScreen_LoginComplete(object sender, string e)
        {
            this.BeginInvoke(new Action(() => { this.Show(); this.WindowState = FormWindowState.Maximized; }));
        }

        private void Data_NewCommuteEvent(object sender, Commute e)
        {
            this.BeginInvoke(new Action(() => UpdateDestinationsPanel()));
            this.BeginInvoke(new Action(() => SetNewUniqueDestinationID()));
            this.BeginInvoke(new Action(() => UpdateGMapMarkers()));
        }

        private void UpdateDestinationsPanel()
        {
            if (!destinationDataGridView.IsCurrentCellInEditMode)
            {
                destinationDataGridView.Rows.Clear();

                foreach (Destination d in data.CurrentCommute?.destinations)
                {
                    int n = destinationDataGridView.Rows.Add();

                    destinationDataGridView.Rows[n].Cells[0].Value = d.destinationUid;
                    destinationDataGridView.Rows[n].Cells[1].Value = d.visitsPerWeek;
                }
            } 
        }

        private void SetNewUniqueDestinationID()
        {
            destinationIDTextBox.Text = data.CurrentCommute.destinations.GetUniqueDestinationID("Destination ");
        }


        //====== Control Panel Events ======

        private void addDestionationButton_Click(object sender, EventArgs e)
        {
            AddDestinationFromUI();
        }

        private void destinationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == idColumn)
            {
                foreach (GMapMarker marker in destinationOverlay.Markers)
                {
                    //requires bespoke marker class :(
                }
            }
            else if (e.ColumnIndex == frequencyColumn)
            {

            }
        }

        private void entryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addDestionationButton_Click(null, EventArgs.Empty);
            }
        }

        private void AddDestinationFromUI()
        {
            double visits;
            double.TryParse(visitsPerWeekMaskedTextBox.Text, out visits);

            Destination destination = new Destination();
            destination.destinationUid = destinationIDTextBox.Text;
            destination.location = myMap.Position;
            destination.visitsPerWeek = Convert.ToDouble(visitsPerWeekMaskedTextBox.Text);

            Commute currentCommute = new Commute();
            currentCommute.destinations = data.CurrentCommute.destinations;
            currentCommute.destinations.Add(destination);
            data.CurrentCommute = currentCommute;
        }

        // ====== Functions ======

        private void UpdateGMapMarkers()
        {
            destinationOverlay.Markers.Clear();

            foreach (Destination d in data.CurrentCommute.destinations)
            {
                DestinationMarker marker = new DestinationMarker(d.location, GMarkerGoogleType.black_small);
                marker.VisitsPerWeek = d.visitsPerWeek;
                marker.destinationUid = d.destinationUid;

                marker.ToolTipText = "ID: " + d.destinationUid + "\n" + "Freq: " + d.visitsPerWeek;
                destinationOverlay.Markers.Add(marker);
            }

            myMap.ZoomAndCenterMarkers(destinationOverlay.Id);
            
        }           

        //====== Menu Events ======

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.CurrentCommute = LoadSaveMethods.LoadCommute();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commute currentCommute = data.CurrentCommute;

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

        private void blankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myMap.MapProvider = GMap.NET.MapProviders.EmptyProvider.Instance;
            blankToolStripMenuItem.Checked = true;
            googleToolStripMenuItem.Checked = false;
            bingToolStripMenuItem.Checked = false;

        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            googleToolStripMenuItem.Checked = true;
            blankToolStripMenuItem.Checked = false;
            bingToolStripMenuItem.Checked = false;
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            googleToolStripMenuItem.Checked = false;
            bingToolStripMenuItem.Checked = true;
            blankToolStripMenuItem.Checked = false;
        }

        private void calculateToolStripButton_Click(object sender, EventArgs e)
        {
            Commute currentCommute = data.CurrentCommute;
            PointLatLng p = CommuteDistance.FindWeightedCenterOfCommute(currentCommute);

            GMapMarker home = new GMarkerGoogle(p, GMarkerGoogleType.red);
            commuteOverlay.Markers.Add(home);
        }

        private void mapContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (currentMarker == null)
            {
                e.Cancel = true;
            }
        }


        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myMap.SetPositionByKeywords(searchTextBox.Text);
            }
        }
    }
}
