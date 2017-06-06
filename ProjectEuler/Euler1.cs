using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Euler1 : Euler
    {
        public int firstNumber = 3;
        public int secondNumber = 5;
        public int limit = 1000;

        public void euler1()
        {
            for (int i = firstNumber; i < limit; i++)
            {
                if (i % firstNumber == 0 || i % secondNumber == 0)
                {
                    answer += i;
                }
            }
        }
    }
}
