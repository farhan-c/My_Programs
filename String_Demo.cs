using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

public class String_Demo
{
    static void Main()
    {
        string s = "Hello World"; // Declaring string
        Console.WriteLine(s.Length); // Printing Length of String
        Console.WriteLine(s.ToUpper()); // Changing the whole string to Uppercase
        Console.WriteLine(s.ToLower()); // Changing the whole string to Lowercase
        // Concatenating two strings
        string s1 = "Many";
        Console.WriteLine(s1+" "+s);
        Console.WriteLine(s[0]); // accessing first character of string s.
        Console.WriteLine(s.IndexOf('e')); // Gets the index of a particular character.
        string first_name = "Salman Khan";
        // The following substring function helps to extract characters from the specified index position.
        int i = first_name.IndexOf('K');
        Console.WriteLine("Last name is: "+ first_name.Substring(i)); // substring method used to return a string from an index specified
        string s2 = string.Copy(first_name); // Creates a copy of the string 
        Console.WriteLine("Cloned string is: "+ s2);
    }
}