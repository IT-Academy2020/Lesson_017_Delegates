using System;
using System.Text;

// Анонімні методи.

namespace Delegates
{
    // Створюємо делегат.
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Створюємо екземпляр делегата MyDelegate і зберігаємо посилання на анонімний метод.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

            myDelegate.Invoke(); // Викликаємо метод, на який посилається делегат. Спосіб 1.
            myDelegate(); // Викликаємо метод, на який посилається делегат. Спосіб 2.

            // Delay.
            Console.ReadKey();
        }
    }
}