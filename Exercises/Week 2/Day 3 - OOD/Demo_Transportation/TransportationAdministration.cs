using Demo_Transportation.Transportations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Transportation
{
    public class TransportationAdministration
    {
		private List<Transportation> transportations;
		private List<Car> cars;
		private List<Bicycle> bicycles;
		private List<Boat> boats;

		public TransportationAdministration()
		{
			this.transportations = new List<Transportation>();
			this.cars = new List<Car>();
			this.bicycles = new List<Bicycle>();
			this.boats = new List<Boat>();
		}

		public void AddTransportation(Transportation t)
		{
			// Note that this if-statement is included for examplifying the advantage of polymorphis and does not take code duplication via a private method in consideration 
			if (this.GetTransportation(t.Id) == null && this.GetCar(t.Id) == null && this.GetBicycle(t.Id) == null && this.GetBoat(t.Id) == null)
			{ this.transportations.Add(t); }
		}

		public void AddCar(Car c)
		{
			// Note that this if-statement is included for examplifying the advantage of polymorphis and does not take code duplication via a private method in consideration 
			if (this.GetTransportation(c.Id) == null && this.GetCar(c.Id) == null && this.GetBicycle(c.Id) == null && this.GetBoat(c.Id) == null)
			{ this.cars.Add(c); }
		}

		public void AddBicycle(Bicycle b)
		{
			// Note that this if-statement is included for examplifying the advantage of polymorphis and does not take code duplication via a private method in consideration 
			if (this.GetTransportation(b.Id) == null && this.GetCar(b.Id) == null && this.GetBicycle(b.Id) == null && this.GetBoat(b.Id) == null)
			{ this.bicycles.Add(b); }
		}

		public void AddBoat(Boat b)
		{
			// Note that this if-statement is included for examplifying the advantage of polymorphis and does not take code duplication via a private method in consideration 
			if (this.GetTransportation(b.Id) == null && this.GetCar(b.Id) == null && this.GetBicycle(b.Id) == null && this.GetBoat(b.Id) == null)
			{ this.boats.Add(b); }
		}

		public Transportation GetTransportation(int id)
		{
            foreach (Transportation item in this.transportations)
            {
				if(id == item.Id)
				{ return item; }
            }
			return null;
		}

		public Car GetCar(int id)
		{
			foreach (Car item in this.cars)
			{
				if (id == item.Id)
				{ return item; }
			}
			return null;
		}

		public Bicycle GetBicycle(int id)
		{
			foreach (Bicycle item in this.bicycles)
			{
				if (id == item.Id)
				{ return item; }
			}
			return null;
		}

		public Boat GetBoat(int id)
		{
			foreach (Boat item in this.boats)
			{
				if (id == item.Id)
				{ return item; }
			}
			return null;
		}
	}
}
