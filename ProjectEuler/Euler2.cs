using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Euler2 : Euler
    {
        public int limit = 4000000;
        public void euler2()
        {
            int i = 1;
            int j = 2;
            while (j < limit)
            {
                int k;
                k = i + j;
                i = j;
                j = k;
                if (k % 2 == 0)
                {
                    answer += k;
                }
            }
        }
    }
}
