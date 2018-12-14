using optimumLocation.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optimumLocation
{
    public class DataStore
    {
        private Commute currentCommute;

        public event EventHandler<Commute> NewCommuteEvent;

        public DataStore()
        {
            currentCommute = new Commute();
        }

        public string UserName { get; set; }

        public Commute CurrentCommute
        {
            get { return currentCommute; }
            set { currentCommute = value; ThrowNewCommuteEvent(currentCommute); }
        }

        private void ThrowNewCommuteEvent(Commute commute)
        {
            NewCommuteEvent?.Invoke(this, commute);
        }

    }
}
