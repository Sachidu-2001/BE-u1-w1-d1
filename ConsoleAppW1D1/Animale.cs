using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D1
{
    public class Animale
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Ownername { get; set; }


        public Animale(string name, int age, string species, string ownername)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
            this.Ownername = ownername;
        }
    }
}
