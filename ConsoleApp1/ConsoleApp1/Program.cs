using System;

namespace ConsoleApp1
{
    delegate int ttt(int number);
   
     class Test
    {
      

    }
    class Program
    {
        static void Main(string[] args)
        {
            ttt Test = Square;
            int res = Test(4);
            Console.WriteLine(res);
        }
        static int Square(int number) => number * number;
    }
}
