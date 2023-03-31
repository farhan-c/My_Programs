using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class Var_vs_Dynamic_vs_Object
{
    public static void Main()
    {
        My_method();
        object s = "Hello World";
        string s1 = s.ToString();    /* Need to explicitly convert to its type before assigning it
                                     to another variable*/
        Console.WriteLine(s1);
        var s2 = "Hello";          
        string s3 = s2;             /* We don't need to explicitly convert to its type before 
                                     * assigning it to another variable*/
        Console.WriteLine(s3);
    }
    public static dynamic My_method()      // Can't use var as return type for returning an element.
    {
        return 2 + 2;
    }
}