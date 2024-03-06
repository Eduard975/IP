using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimLib
{
    public class Prim
    {
        public static bool IsPrime(int number) 
        { 
            if (number < 2) { return false; }
            if (number == 2) { return true; }

            for (int i = 2; i <= number/2; ++i)
            { 
                if(number % i == 0) { return false; }
            }
            return true;
        }

        public static int NumaraPrime(int number)
        {
            int sum = 0;
            for (int i = 2; i <= number; ++i)
            {
                if (IsPrime(i)) {
                    sum++; 
                }
            }
            return sum;
        }
    }
}
