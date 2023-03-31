using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class String_Builder
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World");
        sb.Append(" Not so many");
        Console.WriteLine("Appended string: " + sb);
        sb.Insert(6, "Inserted ");  // Insertion happens with index starting from 6.
        Console.WriteLine("Inserted string: " + sb);
        sb.Replace("Hello", "John");
        Console.WriteLine("Replaced String: " + sb); // "Hello" gets replaced with "John".
        sb.Remove(5,8);
        Console.WriteLine("Removed Inserted From string: " +sb);
    }
}