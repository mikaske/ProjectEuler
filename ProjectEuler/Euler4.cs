using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Euler4 : Euler
    {
        public void euler4()
        {
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    int number = i * j;
                    if (number > answer && IsPalindrome(number))
                    {
                        answer = number;
                        Console.WriteLine("1 - {0}, 2 - {1}", i, j);
                    }
                }
            }
        }

        public bool IsPalindrome(int number)
        {
            string contender = Convert.ToString(number);
            int length = contender.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (contender[i] != contender[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
