using System;
using System.Text;

// Делегати. (Припущення делегата)

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Привіт це Метод, на який буде посилатись делегат.");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // MyDelegate myDelegate = new MyDelegate (MyClass.Method);

            MyDelegate myDelegate = MyClass.Method; // Припущення делегата.
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}