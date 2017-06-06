using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Euler3 : Euler
    {
        public long number = 600851;

        public void euler3()
        {
            bool go = true;
            long contender = number / 2 ;
            while (go)
            {
                if (number % contender == 0)
                {
                    if (!isPrime(contender))
                    {
                        go = false;
                        answer = (int)contender;
                    } 
                }
                if (contender < 2)
                {
                    go = false;
                    answer = (int)contender;
                }
                contender -= 2;
            }
        }

        public bool isPrime(long a)
        {
            for (long i = a/2; i > 2; i--)
            {
                if (a%i==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
