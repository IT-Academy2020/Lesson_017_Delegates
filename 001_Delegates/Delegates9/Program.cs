using System;

// Лямбда вираз і лямбда оператор.

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); }; // Анонімний метод

            myDelegate += () => { Console.WriteLine("Hello 2"); }; // Лямбда-Вираз.

            myDelegate += () => Console.WriteLine("Hello 3"); // Лямбда-Вираз.

            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}