using System;

namespace Lessons_Interf
{
    class Program
    {
        static void Main(string[] args)
        {
            var iron = new Iron();

            //Console.WriteLine(iron.Degree(4));
            iron.PourWater(50);
            iron.Vapor(true);
            Console.WriteLine($"Воды в резервуаре: {iron.CountWater}");
            iron.PourWater(50);
            Console.WriteLine(iron.CheckWater());
            Console.WriteLine($"Воды в резервуаре: {iron.CountWater}");
            Console.WriteLine(iron.Degree(5));


            Console.ReadKey();
        }
    }
}
