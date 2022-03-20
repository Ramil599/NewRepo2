using System;

namespace ConsoleApp1
{

    public class OneKeyPressedEventArgs : System.EventArgs
    {
        public readonly char LastSign;
        public readonly char NewSign;
        public OneKeyPressedEventArgs(char lastSign, char newSign)
        {
            LastSign = lastSign; NewSign = newSign;
        }
        
    }
    public class Test
    {
        char Sign;
    
        public char Run()
        {
             Sign = Convert.ToChar(Console.ReadLine());
            while (Sign!='c')
            {
                 Sign = Convert.ToChar(Console.ReadLine());
                return Sign;
            }

            return Sign;

        }

        public event EventHandler <char>  OneKeyPressed;
        protected virtual void OnOneKeyPressed(char OldSign, char Sign)
        {
            OneKeyPressed?.Invoke(this,Sign);
        }
        public char sign
        {
            get { return Sign; }
            set
            {
                if (Sign == value) return;
                char OldSign = Sign;
                Sign = value;
                OnOneKeyPressed(OldSign,Sign);
            }
        }

    }
    
    
       
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //Вот эта штука отказывается работать
          //  test.OneKeyPressed += test_OneKeyPressed;
            test.sign = test.Run();
        }
        static void test_OneKeyPressed(object sender, OneKeyPressedEventArgs e)
        {
            if (e.LastSign != e.NewSign)
            {
                Console.WriteLine($"Вы ввели новый символ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.ReadLine();
            }
        }


    }
}
