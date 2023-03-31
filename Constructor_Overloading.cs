using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_list;
    class Program
    {
        public int i, j;
        public string h, k;
        public Program(int m,int n)
        {
            i = m;
            j = n;
        }
        public Program(string s,string w)
        {
            h = s;
            k = w;
        }
        public void My_method1()
        {
            Console.WriteLine(i + " "+ j);
        }
        public void My_method2()
        {
            Console.Write(h+" "+k);
        }
    }
    class Constructor_Overloading
    {
        static void Main(string[] args)
        {
            var obj2 = new Program(1, 5);
            var obj1 = new Program("Hello", "Many");
            obj2.My_method1();
            obj1.My_method2();
        }
    }
