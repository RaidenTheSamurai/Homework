using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework__5.Part_1;
using static System.Formats.Asn1.AsnWriter;

namespace Homework__5
{
    public class Test
    {
        public void PlayShow()
        {
            Play somePlay = new Play();
            somePlay.Show();
        }
        public void StoreShow()
        {
            Store store = null;
            try
            {
                store = new Store();
                Console.WriteLine($"Store name: {store.Name}");
                Console.WriteLine($"Store adress: {store.Adress}");
                Console.WriteLine($"Store type: {store.Type}");
            }
            finally
            {
                store?.Dispose();
            }
        }
        public void StoreShow2()
        {
            Store store = new Store();
            Console.WriteLine($"Store name: {store.Name}");
            Console.WriteLine($"Store adress: {store.Adress}");
            Console.WriteLine($"Store type: {store.Type}");
        }

    }
}
