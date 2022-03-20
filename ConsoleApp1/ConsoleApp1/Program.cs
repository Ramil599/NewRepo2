using System;

namespace ConsoleApp1
{
    
    public delegate void OneKeyPressedHandler<TEventArgs>(char Sign);
    public class Test
    {
        
        public event OneKeyPressedHandler<char> OneKeyPressed;

        public char Run()
        {
            char Sign = Convert.ToChar(Console.ReadLine());
            while (Sign!='c')
            {
                 Sign = Convert.ToChar(Console.ReadLine());
            }
            return Sign;
            OneKeyPressed(Sign);
        }
       
    }
       
    class Program
    {
        static void Main(string[] args)
        {

            Test obj = new Test();
            Console.WriteLine(obj.Run());
            Console.ReadKey();
        }
        //static int Square(int number) => number * number;
    }
}
