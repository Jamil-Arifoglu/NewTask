using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class Country
    {
        public string Name;
        public long TotalPopulation;


       public List<City> cities=new List<City>();

        public Country(string name, long totalPopulation)
        {
            Name = name;
            TotalPopulation = totalPopulation;
        }


           public void FindAllPopulation()
        {
            string data1 =Console.ReadLine();
            string data2 = Console.ReadLine();
            double min=Convert.ToDouble(data1);
            double max = Convert.ToDouble(data2);



            List<City> list = new List<City>();
            foreach (var item in cities)
            {
                if (item.Population > min && item.Population < max)
                {
                    list.Add(item);
                    Console.WriteLine($"{item.Name}-{item.Population}");
                }

            }
            if(list.Count == 0)
            {
                Console.WriteLine($" {Name}-{TotalPopulation}");
            }
        }
        
    }
}
