using System;
using System.Text;

// Делегати.

namespace Delegates
{
    // Клас, на метод якого буде посилатись делегат.
    class MyClass
    {
        // Створюємо метод, на який буде посилатись делегат.
        public void Method()
        {
            Console.WriteLine("Привіт це Метод, на який буде посилатись делегат.");
        }
    }

    // На 21-му рядку створюємо делегат з іменем MyDelegate,
    // що буде містити посилання на метод, який
    // не буде нічого приймати і не буде нічого повертати.

    public delegate void MyDelegate(); // Створюємо делегат. (1)

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Створюємо екземпляр делегата. Спосіб 1. (2)
            //MyDelegate myDelegate = instance.Method; // Створюємо екземпляр делегата. Спосіб 2. (2')

            myDelegate.Invoke(); // Викликаємо метод, на який посилається делегат. Спосіб 1. (3)
            myDelegate(); // Викликаємо метод, на який посилається делегат. Спосіб 2. (3')

            // Delay.
            Console.ReadKey();
        }
    }
}