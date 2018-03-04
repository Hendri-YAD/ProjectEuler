﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int n = 1000;        
            int sum = 0;

            for(int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine(sum);            
        }
    }
}
