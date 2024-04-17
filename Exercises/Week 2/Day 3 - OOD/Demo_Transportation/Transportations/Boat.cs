using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Transportation.Transportations
{
    public class Boat : Transportation
    {
        private string company;
        private int weight;

        public Boat(int id, string company, int weight, int speed) : base(id, speed)
        {
            this.company = company;
            this.weight = weight;
        }

        public override double CalculateHoursTillDestination(int km)
        {
            // Required time doubles per 5000KG of weight (for demo purpose)
            return base.CalculateHoursTillDestination(km) * (1 + this.weight / 5000);
        }

        public override string ToString()
        {
            string s = $"Boat owned by {this.company} (weight: {this.weight})";
            s += $" with a speed of {base.ToString()}";
            return s;
        }
    }
}
