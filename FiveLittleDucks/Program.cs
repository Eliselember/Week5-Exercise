﻿using System;

namespace FiveLittleDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Five Litlle Ducks");
            string ducks;
            for(int i = 5; i > 0; i--)
            {
                if (i > 1)
                {
                    ducks = "ducks";
                }
                else
                {
                   ducks = "duck";
                }

                Console.WriteLine($"{i} little {ducks} went out one day");
                Console.WriteLine("Over the hill and far away");
                Console.WriteLine("Mother duck said,\"Quack, quack, quack, quack\''");

                if (1 == 2)
                {
                    ducks = "duck";
                }

                if(1 == 1)
                Console.WriteLine($"But only {i - 1} little {ducks} came back.");




                Console.WriteLine();
            }
            


        }
    }
}
