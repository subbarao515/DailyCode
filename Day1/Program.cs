﻿using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input number");
            int n= Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=n;i++)
            {
                if(i%3==0 && i%5==0)
                 Console.Write("FizzBuzz,");
                 else if(i%3==0)
                    Console.Write("Fizz,");
                 else if(i%5==0)
                    Console.Write("Buzz,");
                 else 
                    Console.Write(i+",");
            }
            Console.ReadLine();
        }
    }
    
}
