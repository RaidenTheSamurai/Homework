using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2
{
    public class Money
    {
        public int IntPart {get; set;}      //Ціла частина
        public int FracPart { get; set;}   //Дробова частина
        public double fullValue;              //Загальна сума

        public Money() { }
        public Money (double fullValue)         //Конструктор, який присвоює значання загальній сумі і разподіляє її на цілу і дробову чатстини
        {
            this.fullValue = fullValue;
            this.IntPart = (int)Math.Floor(fullValue);
            this.FracPart = (int)((fullValue - Math.Floor(fullValue)) * 100);
        }
        public Money(int intPart, int fracPart)     //Конструктор, який присвоює значення цілій і дробовій частинам, а також сумує їх в загальну суму
        {
            
                this.IntPart = intPart;
                this.FracPart = fracPart;
                this.fullValue = intPart + fracPart * 0.01;
            
        }

        public double Sum(Money secondValue)
        {
            return this.fullValue + secondValue.fullValue;
        }

        public void Print() { Console.WriteLine($"{IntPart} dollar(s) and {FracPart} cent(s)"); }
    }
}
