using System;
using System.Text;

// Делегати.

namespace Delegates
{
    // Клас, на метод якого буде посилатись делегат.
    static class MyClass
    {
        // Створюємо статичний метод, на який буде посилатись делегат.
        public static void Method()
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

            MyDelegate myDelegate = new MyDelegate(MyClass.Method); // Створюємо екземпляр делегата. Спосіб 1. (2)
            //MyDelegate myDelegate = MyClass.Method; // Створюємо екземпляр делегата. Спосіб 2. (2')

            MyClass.Method(); // Простий виклик метода.

            myDelegate.Invoke(); // Викликаємо метод, на який посилається делегат. Спосіб 1. (3)
            myDelegate(); // Викликаємо метод, на який посилається делегат. Спосіб 2. (3')

            // Delay.
            Console.ReadKey();
        }
    }
}