using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int PriceTag { get; set; }
        public string Color { get; set; }
        public bool Electric { get; set; }
    }
}
