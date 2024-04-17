using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Demo_Transportation.Transportations
{
    public class Car : Transportation
    {
        private string licensePlate;
        private Color color;

        public Car(int id, string licensePlate, Color color, int speed) : base(id, speed)
        {
            this.licensePlate = licensePlate;
            this.color = color;
        }

        public override string ToString()
        {
            string s = $"Car ({this.licensePlate}), the color is {this.color.ToString()}";
            s += $", the speed is {base.ToString()}";
            return s;
        }
    }
}
