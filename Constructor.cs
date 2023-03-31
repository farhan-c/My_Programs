using System;

    public class Program
{
    int i, j, add;
    public Program()
    {
        i = 1;
        j = 2;
    }
    public int My_method()
    {
        return add = i + j;
    }
}
class Constructor
{
    static void Main(string[] args)
    {
        var obj = new Program();
        Console.WriteLine(obj.My_method());
    }
}