using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Homework__4.Part_1;
using Homework__4.Part_2;
using Homework__4.Part_3;
using Homework__4.Part_4;

namespace Homework__4
{
    public class Test
    {
        
        public void RunWorker()
        {
            Worker worker1 = new Worker(250);
            Worker worker2 = new Worker(275.5f);
            Console.WriteLine($"First workers salsry: {worker1.Salary}");
            Console.WriteLine($"Second workers salsry: {worker2.Salary}");
            worker1 += 10f;
            Console.WriteLine($"First workers new salsry: {worker1.Salary}");
            Console.WriteLine($"Both workers salary are equal: {worker1.Equals(worker2)}");
        }
        public void RunMatrix()
        {
            Matrix matrix1 = new Matrix(3);
            Matrix matrix2 = matrix1;
            Matrix matrix3 = new Matrix(3);
            Matrix matrix4 = matrix1 + matrix3;
            Matrix matrix5 = matrix2 * matrix4;
            Matrix matrix6 = matrix4 - matrix5;
            Console.WriteLine("First matrix:\n");
            matrix1.Print();
            Console.WriteLine("\nSecond matrix:\n");
            matrix2.Print();
            Console.WriteLine("\nThird matrix:\n");
            matrix3.Print();
            Console.WriteLine($"\nFirst and second matrix are equal: {matrix1 == matrix2}" +
                                         $"\nFirst and third matrix are equal: {matrix1 == matrix3}" +
                                         $"\nSecond and third matrix are not equal: {matrix2 != matrix3}" +
                                         $"\nFirst and second matrix are equal: {matrix1.Equals(matrix2)}" +
                                         $"\nFirst and third matrix are equal: {matrix1.Equals(matrix3)} ");
            Console.WriteLine("\nMatrix number four. The result of adding matrix one and matrix three:\n");
            matrix4.Print();
            Console.WriteLine("\nMatrix number five. The result of multiplying matrix two by matrix four:\n");
            matrix5.Print();
            Console.WriteLine("\nMatrix number six. The result of subtracting matrix five from matrix four\n");
            matrix6.Print();
        }
        public void RunCity()
        {
            City city1 = new City(352189);
            City city2 = new City();
            Console.WriteLine($"---First city---");
            city1.Show();
            Console.WriteLine($"---Second city---");
            city2.Show();
            Console.WriteLine("\n-----------------------------------------------------------\n" +
                                          "First city after COVID");
            city1 -= 250000;
            city1.Show();
            Console.WriteLine("\n-----------------------------------------------------------\n" +
                                          "Second city after increased population");
            city2 += 200200;
            city2.Show();
            Console.WriteLine($"\nBoth cities population is equal: {city1 == city2}\n" +
                                         $"Both cities population is equal: {city1.Equals(city2)}\n" +
                                         $"Both cities population is not equal: {city1 == city2}\n" +
                                         $"Population of first city is larger than seconds one: {city1 > city2}\n" +
                                         $"Population of first city is smaller than seconds one: {city1 <city2}\n");
        }
        public void RunCreditCard()
        {
            Credit_Card card1 = new Credit_Card(257.25f);
            Credit_Card card2 = new Credit_Card(852, 257.25f);
            card1.Print();
            card2.Print();
            Console.WriteLine($"\nCVC code of both card are equal: {card1 == card2} \nCVC code of both card are not equal: {card1 != card2} \nNumbers of cards are equal: {card1.Equals(card2)}\n");
            card1 += 10;
            card2 -= 28;
            card1.Print();
            card2.Print();
            Console.WriteLine($"\nMoney on the account of the first card is more than on the account of the second: {card1 > card2} \nMoney on the account of the first card is less than on the account of the second: {card1 < card2}\n");

        }
    }
}
