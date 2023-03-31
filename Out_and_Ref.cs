using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
    class Out_and_Ref
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(My_method(ref i)); /*Value is passed by reference, so when
                                                   a becomes 2 i also becomes 2*/
           
            Console.WriteLine(My_method2(out i)); // Value of i passed gets discarded and new value
                                                  //assigned to i through b gets printed
        }
        public static int My_method(ref int a)
        {
            a = a + 1;
            return a; 
        }
        public static int My_method2(out int b)
        {
            b = 2;
            b = b + 5;
            return b; 
        }
    }
}
