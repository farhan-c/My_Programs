using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class Lambda_Expressions
{
    static void Main(string[] args)
    {
        Func<int, int> square = c => c * c;
        Console.WriteLine(square(5));
    }
}