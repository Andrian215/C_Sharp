﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("N=");
            int N = Convert.ToInt32(Console.ReadLine());

            {
                if (A == C & A == N)
                {
                    Console.WriteLine(A + C + N);
                }
                else if (A < C & C == N)
                {
                    Console.WriteLine(A * C * N);
                }
                else if (A < C & C < N)
                {
                    Console.WriteLine((A + C) * N);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

            Console.ReadLine();
        }


    }
}
