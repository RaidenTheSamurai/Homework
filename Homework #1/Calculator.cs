using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1
{
    public class Calculator
    {
        public double Add(double a, double b) { return a + b; }         //Додавання
        public double Sub(double a, double b) { return a - b; }         //Віднімання
        public double Mult(double a, double b) { return a * b; }       //Множення
        public double Div(double a, double b) { return a / b; }         //Ділення
        public double Perc(double a, double b) { return b / 100 * a; }      //Процент від числа. Знаходить процент "a" від числа "b"
        public double ToPower(double a, double b) { return Math.Pow(a, b); }    //Возведення у степінь. Число "а" у степінь "b"
    }
}
