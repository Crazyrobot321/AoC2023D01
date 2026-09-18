using AdventOfCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2023D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Path.Combine(AppContext.BaseDirectory, "input.txt");
            var file = File.ReadAllLines(input);
            foreach(var line in file)
            {
                Console.WriteLine(line);
            }
        }
    }
}
