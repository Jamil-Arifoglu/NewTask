using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class City
    {
        public string Name { get; set; }
        public long Population;
        

        public City(string name, long population)
        {
            Name = name;
            Population = population;
            
        }
    }
}
