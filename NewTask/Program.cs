using System.Diagnostics.Metrics;

namespace NewTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country countrys = new Country("Azerbaycan",10000000);

            countrys.cities.Add(new City("Baku",2000000));
            countrys.cities.Add(new City("Gence", 1000000));
            countrys.cities.Add(new City("Tovuz", 200000));
            countrys.cities.Add(new City("Qusar", 300000));
            countrys.cities.Add(new City("Cebrayil", 100000));

            countrys.FindAllPopulation();


        }
       
    }
}