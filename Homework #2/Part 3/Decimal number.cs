using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2.Part_3
{
    public struct Decimal_number
    {

        public int value;
        public Decimal_number() { }

        public string BinnarySystem()
        {
            string result = " ";
            int i = value;
            while (true)
            {    
                int remainder = 0;
                remainder = i % 2;
                i = (i - remainder) / 2;
                result = remainder + result;
                if (i == 0) { break; }
            }
            
            return result; 
        }
        public string OctalSystem()
        {
            string result = " ";
            int i = value;
            while (true)
            {
                int remainder = 0;
                remainder = i % 8;
                i = (i - remainder) / 8;
                result = remainder + result;
                if (i == 0) { break; }
            }

            return result;
        }
        public string HexadecimalSystem()
        { 
            string result = " ";
            string hexnumbers = "0123456789ABCDEF";
            int i = value;
            while (true)
            {
                char reaminder = ' ';
                reaminder = hexnumbers[i % 16];
                i = ((i - (i % 16)) / 16);
                result = reaminder + result;
                if (i == 0) { break; }
            }
            return result;
        }
    }
}
