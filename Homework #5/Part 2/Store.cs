using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__5
{
    public class Store : IDisposable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Type { get; set; }
        public Store(): this("Store")
        { }
        public Store(string name) : this(name, "Adress")
        { }
        public Store(string name, string adress) : this(name, adress, "Food")
        { }
        public Store(string name, string adress, string type) 
        {
            Name = name;
            Adress = adress;
            Type = type;
        }


        public void Dispose()
        {
            Console.WriteLine("Dispose worked");
        }
        ~Store()
        {
            Console.WriteLine("Destructor worked");
        }
    }
}
