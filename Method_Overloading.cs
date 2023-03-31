using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
    class Program
    {
        public int My_method(int i,int j)
        {
            return i + j;
        }
        public int My_method(int j,int k,int l)
        {
            return (j*k)+l;
        }
    }
    class Method_Overloading
    {
        static void Main(string[] args)
        {
            var obj = new Program();
            Console.WriteLine(obj.My_method(1,5));
            Console.WriteLine(obj.My_method(2,5,7));
        }
    }
}
