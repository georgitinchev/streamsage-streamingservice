using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Transportation.Transportations
{
    public class Transportation
    {
        private int id;
        private int speedKMH;

        public int Id { get { return this.id; } }
        public int SpeedKMH { 
            get { return this.speedKMH; } 
            protected set 
            {
                if(value < 0)
                { this.speedKMH = 0; }
                else
                { this.speedKMH = value; }

            } 
        }

        public Transportation(int id, int speed)
        {
            this.speedKMH = speed;

        }

        public virtual double CalculateHoursTillDestination(int km)
        {
            return (double)km / this.speedKMH;
        }

        public override string ToString()
        {
            return this.speedKMH + "KM/H";
        }

    }
}
