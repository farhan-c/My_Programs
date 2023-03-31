using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class String_InterPolation
{
    public static void Main(string[] args)
    {
        int a = 10, b = 15;
        Console.WriteLine($"Addition of {a} and {b} is {a+b}");
        Console.WriteLine($"Multiplication of {a} and {b} is {a*b}");
    }
}