using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D1
{
    internal class Atleta
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string Sport { get; set; }

        public Atleta()
        {

        }

        public Atleta(string name, string surName, int age, string height, string sport)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
            this.Height = height;
            this.Sport = sport;
        }
    }
}
}
