using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D1
{
    internal class Veicolo
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Veicolo(string brand, string model, int year)
        {

            this.Brand = brand;
            this.Model = model;
            this.Year = year;

        }

    }
}
