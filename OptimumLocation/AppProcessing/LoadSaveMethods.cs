using optimumLocation.Structs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace optimumLocation
{
    public static class LoadSaveMethods
    {
        public static Commute LoadCommute()
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "XML Files (*.xml)|*.xml";

            Commute loadedCommute = null;

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer x = new XmlSerializer(typeof(Commute));
                StreamReader myReader = new StreamReader(loadFileDialog.FileName);

                loadedCommute = (Commute)x.Deserialize(myReader);            
            }

            return loadedCommute;
        }
    }
}
