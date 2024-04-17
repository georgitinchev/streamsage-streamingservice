using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Transportation.Transportations
{
    public class Bicycle : Transportation
    {
        private bool hasLuggageCarrier;

        public Bicycle(int id, bool hasLuggageCarrier, int speed) : base(id, speed)
        {
            this.hasLuggageCarrier = hasLuggageCarrier;
        }

        public override string ToString()
        {
            string s = "Bicycle,";
            if (hasLuggageCarrier)
            { s += " has a luggage carrier, "; }
            s += $" the speed is {base.ToString()}";
            return s;
        }
    }
}
