using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class List_and_its_Methods
{
    public static void Main(string[] args)
    {
        List<int> num = new List<int>(); // Declaring a List.
        num.Add(21);
        num.Add(42);
        num.Add(53);
        num.Add(44);
        num.Add(96);
        num.Add(78);
        Console.WriteLine(num.Count); // Counting number of Elements i.e 6.
        num.Insert(3, 100);  // Inserting an element to a list.
        num.RemoveAt(2);    // Removing at a Specific Index.
        Console.WriteLine("List Before Sorting");
        foreach (int i in num)
        {
            Console.Write(i+" ");
        }
        num.Sort(); // Sorting in ascending order
        Console.WriteLine("List After Sorting in ascending order");
        foreach(int j in num) 
        { 
            Console.Write(j+" "); 
        
        } 
        Console.WriteLine("List After Sorting in descending order");
        num.Reverse();
        foreach (int j in num) 
        { 
            Console.Write(j+" "); 
        }
    }
}       