using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class Numerable_vs_Numerator
{
    public static void Main(string[] args)
    {
        List<int> years = new List<int>();
        years.Add(1);
        years.Add(2);
        years.Add(3);
        years.Add(4);
        years.Add(5);
        years.Add(6);

        IEnumerable<int> num = (IEnumerable<int>)years;

        Console.WriteLine("List using IEnumerable:");
        foreach (int i in num)
        {
            Console.Write(i+" "); // Printing List using IEnumerable
        }
        Console.WriteLine();
        IEnumerator<int> iter = years.GetEnumerator();
        Console.WriteLine("List using IEnumerator:");
        while (iter.MoveNext())
        {
            Console.Write(iter.Current.ToString()+" "); //Printing List using IEnumerator
        }
    }
}