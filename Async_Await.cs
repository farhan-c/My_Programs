using System;
namespace Task_List
{
    class Async_Await
    {
        static void Main(string[] args)
        {
            My_method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
        public static async void My_method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
       
    }
}
