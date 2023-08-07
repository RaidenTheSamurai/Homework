using Homework__4.Part_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4.Part_4
{
    public class Credit_Card
    {
        public string Number { get; set; }
        public int CVCcode { get; set; }
        public float Account { get; set; }
        public Credit_Card()
        {
            Number = "";
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                if (i == 4 || i == 8 || i == 12) Number += " ";
                Number += rnd.Next(0, 10);
            }
            Account = rnd.Next(0, 1000000);
            CVCcode = rnd.Next(100, 999);
        }
        public Credit_Card(float account)
        {
            Number = "";
            this.Account = account;
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                if (i == 4 || i == 8 || i == 12) Number += " ";
                Number += rnd.Next(0, 10);
            }
            CVCcode = rnd.Next(100, 999);
        }
        public Credit_Card(int cVCcode, float account)
        {
            CVCcode = cVCcode;
            Account = account;
            Number = "";
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                if (i == 4 || i == 8 || i == 12) Number += " ";
                Number += rnd.Next(0, 10);
            }
        }
        public Credit_Card(string number, int cVCcode, float account)
        {
            Number = number;
            CVCcode = cVCcode;
            Account = account;
        }

        public static Credit_Card operator +(Credit_Card card, float valueOfIncrese) { return new Credit_Card { Account = card.Account + valueOfIncrese, Number = card.Number }; }
        public static Credit_Card operator -(Credit_Card card, float valueofDecrese) { return new Credit_Card { Account = card.Account - valueofDecrese, Number = card.Number }; }
        public static bool operator <(Credit_Card card1, Credit_Card card2) { return card1.Account < card2.Account; }
        public static bool operator >(Credit_Card card1, Credit_Card card2) { return card1.Account > card2.Account; }
        public static bool operator ==(Credit_Card card1, Credit_Card card2) { return card1.CVCcode == card2.CVCcode; }
        public static bool operator !=(Credit_Card card1, Credit_Card card2) { return card1.CVCcode != card2.CVCcode; }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType != obj.GetType) return false;
            Credit_Card card = (Credit_Card)obj;
            return card.Number == Number;
        }

        public void Print() => Console.WriteLine($"Number: {Number}\nCVC code: {CVCcode}\nCredit card account: {Account}");

        
    }
}
