using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2
{
    public class Product : Money
    {
        public Product(double fullValue)         //Конструктор, який присвоює значання загальній сумі і разподіляє її на цілу і дробову чатстини
        {
            this.fullValue = fullValue;
            this.IntPart = (int)Math.Floor(fullValue);
            this.FracPart = (int)((fullValue - Math.Floor(fullValue)) * 100);
        }

        public Product(int intPart, int fracPart)       //Конструктор, який присвоює значення цілій і дробовій частинам, а також сумує їх в загальну суму
        {
            this.IntPart = intPart;
            this.FracPart = fracPart;
            this.fullValue = intPart + fracPart * 0.01;
        }
        

        public void addDiscount(double discount)   //Знижка виражена числом
        {
            this.fullValue -= discount;
            this.IntPart = (int)Math.Floor(fullValue);
            this.FracPart = (int)((fullValue - Math.Floor(fullValue)) * 100);
        }
        public void addDiscount(int percents, bool percent)         //Знижка виражена процентами
        {
            if (percent == false) { addDiscount(percents); }
            else
            {
                this.fullValue -= fullValue / 100 * percents;
                this.IntPart = (int)Math.Floor(fullValue);
                this.FracPart = (int)((fullValue - Math.Floor(fullValue)) * 100);
            }
        }

    }
}
