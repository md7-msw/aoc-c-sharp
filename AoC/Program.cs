﻿using System;
using System.Runtime.CompilerServices;
using System.Linq;


[assembly: InternalsVisibleTo("AoC.Tests")]
namespace AoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = args.Any() ? Int32.Parse(args[0]) : 0;

            Console.WriteLine("Day{0}:", day);

            IDay dayClass = null;
            switch (day)
            {
                case 1:
                    dayClass = new Day1.Day1();
                    break;
                case 2:
                    dayClass = new Day2.Day2();
                    break;
                case 3:
                    dayClass = new Day3.Day3();
                    break;
                case 4:
                    dayClass = new Day4.Day4();
                    break;
                case 5:
                    dayClass = new Day5.Day5();
                    break;
                case 6:
                    dayClass = new Day6.Day6();
                    break;
                case 7:
                    dayClass = new Day7.Day7();
                    break;
                default:
                    return;
            }

            dayClass.Main();

        }
    }
}
