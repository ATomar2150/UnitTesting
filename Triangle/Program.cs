﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Triangle Analyzer");
            string inputString;
            long choice, firstSide, secondSide, thirdSide;
            string fSide, sSide, tSide;
            //Displaying menu to user. Using try parse to force the user to enter either choise 1 or choice 2
            do
            {
                Console.WriteLine("1. Enter triangle dimensions.\n2. Exit");
                inputString = Console.ReadLine();
            } while (!(long.TryParse(inputString, out choice) && (choice == 1 || choice == 2)));

            //Once User has given Choice 1 as input for first time, the program keep asking the user enter dimensions for new triangle after servicing the user.
            //This while also make sure that User can only exit the program either by choosing 2 or closing the window.
            while (choice == 1)
            {
                //Enforing length of each triangle to be only Interger and between range of 1-2147483647
                do
                {
                    Console.Write("Enter length of First Side of Triangle(1-2147483647): ");
                    fSide = Console.ReadLine();
                } while (!(long.TryParse(fSide, out firstSide) && (firstSide >= 1 && firstSide <= 2147483647)));

                do
                {
                    Console.Write("Enter length of Second Side of Triangle(1-2147483647): ");
                    sSide = Console.ReadLine();
                } while (!(long.TryParse(sSide, out secondSide) && (secondSide >= 1 && secondSide <= 2147483647)));

                do
                {
                    Console.Write("Enter length of Third Side of Triangle(1-2147483647): ");
                    tSide = Console.ReadLine();
                } while (!(long.TryParse(tSide, out thirdSide) && (thirdSide >= 1 && thirdSide <= 2147483647)));


                //Passing all three sides to TriangleSolver.Analyze();
                string output = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

                Console.WriteLine(output);
                System.Threading.Thread.Sleep(1000);
                do
                {
                    Console.WriteLine("1. Enter triangle dimensions.\n2. Exit");
                    inputString = Console.ReadLine();
                } while (!(long.TryParse(inputString, out choice) && (choice == 1 || choice == 2)));
            }

            if (choice == 2)
            {
                Console.WriteLine("BBYE!");
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(1);
            }
        }
    }
}
