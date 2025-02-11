using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D1
{
    internal class Dipendente
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Dipendente(string name, string surName, string email, int salary)
        {
            this.Name = name;
            this.SurName = surName;
            this.Email = email;
            this.Salary = salary;

        }
    }
}
