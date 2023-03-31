using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Task_List
{
     class Generic_And_Non_Generic
    {
        public static void Main(String[] args)
        {
            List<int> mylist = new List<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3); // Can store data of same data type.

            Console.WriteLine("Start of List");
            foreach (int items in mylist)
            {
                Console.Write(items+" ");
            }
            Console.WriteLine();
            ArrayList arrayList = new ArrayList(); 
            arrayList.Add(1);                       //Can store data of different data types//
            arrayList.Add("Hello World");
            arrayList.Add(null);
            arrayList.Add(3);
            Console.WriteLine("Start of Array List");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
        }
    }

}