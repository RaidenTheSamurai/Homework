using Homework__4.Part_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4.Part_3
{
    public class City
    {
        public int Population { get; set; }

        public City()
        {
            Random random = new Random();
            Population = random.Next(0, 1000000);
        }
        public City(int population)
        {
            Population = population;
        }
        public static City operator +(City city, int valueOfIncrese) { return new City { Population = city.Population + valueOfIncrese }; }
        public static City operator -(City city, int valueofDecrese) { return new City { Population = city.Population - valueofDecrese }; }
        public static bool operator <(City city1, City city2) { return city1.Population < city2.Population; }
        public static bool operator >(City city1, City city2) { return city1.Population > city2.Population; }
        public static bool operator ==(City city1, City city2) { return city1.Population == city2.Population; }
        public static bool operator !=(City city1, City city2) { return city2.Population != city2.Population; }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType != obj.GetType) return false;
            City city = (City)obj;
            return city.Population == Population;
        }
        public void Show() => Console.WriteLine($"Population: {Population}");
    }
}
