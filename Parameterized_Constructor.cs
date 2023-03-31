using System;
namespace Task_List
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        public Car(string Name, string Color, int Year)
        {
            model = Name;
            color = Color;
            year = Year;
        }
        class Parameterized_Constructor
        {
            static void Main(string[] args)
            {
                Car Ford = new Car("Mercedes", "Red", 2001);
                Console.WriteLine($"{Ford.color} {Ford.year} {Ford.model}");
            }
        }
    }
}
