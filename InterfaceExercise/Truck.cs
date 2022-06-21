using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public Truck(int numDoors, string color, bool electric, string name, string motto, int ecoRating, bool coveredBed, bool canTow)
        {
            PriceTag = numDoors;
            Color = color;
            Electric = electric;
            Name = name;
            Motto = motto;
            EcoRating = ecoRating;
            CoveredBed = coveredBed;
            CanTow = canTow;
        }

        public int PriceTag { get; set; }
        public string Color { get; set; }
        public bool Electric { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public int EcoRating { get; set; }
        public bool CoveredBed { get; set; }
        public bool CanTow { get; set; }
    }
}
