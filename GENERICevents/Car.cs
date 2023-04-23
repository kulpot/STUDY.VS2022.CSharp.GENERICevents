using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERICevents
{// Basic None Generic event pre define codes
    class Car
    {
        private int _topSpeed;
        //public delegate void TopSpeedChangedEventHandler(object sender, TopSpeedChangedEventArgs e);//can remove if event type is generic 
        //GENERIC Type
        public event EventHandler<TopSpeedChangedEventArgs> TopSpeedChanged;
        //public event TopSpeedChangedEventHandler TopSpeedChanged;//none generic

        protected virtual void OffTopSpeedChanged()// OnTopSpeedChanged the "On" prefix is just a convention you can change it to Off
        {
            if(TopSpeedChanged != null)
            {
                var e = new TopSpeedChangedEventArgs(300);//use var keywords for EventArgs types because its long
                //var e = new TopSpeedChangedEventArgs(_topSpeed);
                TopSpeedChanged(this, e);
            }
        }

        public int TopSpeed
        {
            get { return _topSpeed; }
            set
            {
                _topSpeed = value;
                OffTopSpeedChanged();
                //OnTopSpeedChanged();
            }
        }
    }

    class TopSpeedChangedEventArgs : EventArgs
    {
        public int TopSpeed { get; private set; }

        public TopSpeedChangedEventArgs(int topSpeed)
        {
            TopSpeed = topSpeed;
        }
    }
}
