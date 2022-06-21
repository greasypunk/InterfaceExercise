using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Name { get; set; }
        public string Motto { get; set; }
        public int EcoRating { get; set; }
    }
}
