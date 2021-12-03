using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Advent of Code!");
            Console.WriteLine("------------------\n");

            var appRunner = new AppFactory();

            while (true)
            {
                Console.WriteLine("Enter the DAY number");
                var _ = int.TryParse(Console.ReadLine(), out int dayNumber);

                try
                {
                    var (first, second) = appRunner.Run(dayNumber);
                    Console.WriteLine($"Day {dayNumber}. results:\n1st part: {first}\n2nd part: {second}");
                    return;
                }
                catch (Exception e) when (
                        e is DirectoryNotFoundException
                        || e is FileNotFoundException)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
