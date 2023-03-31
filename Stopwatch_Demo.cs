using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class Stopwatch_Demo
{
    public static void Main()
    {
        var sw = Stopwatch.StartNew();
        long ticks = sw.ElapsedTicks;
        Console.WriteLine(sw.Elapsed);
    }
}