﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Runner
    {
        public Runner()
        {

        }

        public void Run()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("This is line 2");
            Console.WriteLine("This is line 3");

            var calculator = new Calculator();
            int sum = calculator.Add(5, 7);
            Console.WriteLine(sum);

            Console.WriteLine($"The deffirence between 5 and 7 is {calculator.Substract(5, 7)}");
            Console.WriteLine($"The product of 5 and 7 is {calculator.Multiply(5, 7)}");
            Console.WriteLine($"The quotient of 20 and 4 is {calculator.Devision(20, 4)}");

            Console.ReadKey();
        }
    }
}
