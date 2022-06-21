using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        

        public Car()
        {
        }

        public Car(int numDoors, string color, bool electric, string name, string motto, int ecoRating, bool hatchback, bool hasSunroof)
        {
            PriceTag = numDoors;
            Color = color;
            Electric = electric;
            Name = name;
            Motto = motto;
            EcoRating = ecoRating;
            Hatchback = hatchback;
            HasSunroof = hasSunroof;
        }

        public int PriceTag { get; set; }
        public string Color { get; set; }
        public bool Electric { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public int EcoRating { get; set; }
        public bool Hatchback { get; set; }
        public bool HasSunroof { get; set; }
    }
}
