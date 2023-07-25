namespace Homework__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            double a, b, c = 0;
            string oper;

            Console.WriteLine("Enter first value");
            a = double.Parse(Console.ReadLine());

            while (true)    //Цикл який дозволяє користатись калькулятором на кшталт настільних електрониих калькуляторів, тобто можна продовжувати безкінечний ланцюжок операцій
            {
                Console.WriteLine("Enter operation");
                oper = Console.ReadLine();
                if (oper == "=")
                {
                    break;                      //Зупиняє цикл і надає можливість побачити результат
                }
                Console.WriteLine("Enter next value");
                if (c != 0) a = c;
                b = double.Parse(Console.ReadLine());
                if (oper == "+")
                {
                   c =  calc.Add(a, b);
                }
                else if (oper == "-")
                {
                    c = calc.Sub(a, b);
                }
                else if (oper == "*")
                {
                    c = calc.Mult(a, b);
                }
                else if (oper == "/")
                {
                    c = calc.Div(a, b);
                }
                else if (oper == "%")
                {
                    c = calc.Perc(a, b);
                }
                else if (oper == "**")
                {
                    c = calc.ToPower(a, b);
                }
                else
                {
                    Console.WriteLine("Wrong operation symbol");
                    break;
                }
            }
            Console.WriteLine("Result  is " + c);
        }
    }

}