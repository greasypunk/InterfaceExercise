using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public SUV(int numDoors, string color, bool electric, string name, string motto, int ecoRating, int numPassengers, bool offRoadCapable)
        {
            PriceTag = numDoors;
            Color = color;
            Electric = electric;
            Name = name;
            Motto = motto;
            EcoRating = ecoRating;
            NumPassengers = numPassengers;
            OffRoadCapable = offRoadCapable;
        }

        public int PriceTag { get; set; }
        public string Color { get; set; }
        public bool Electric { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public int EcoRating { get; set; }

        public int NumPassengers { get; set; }
        public bool OffRoadCapable { get; set; }
    }
}
