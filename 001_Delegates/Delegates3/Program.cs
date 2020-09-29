using System;
using System.Text;

// Делегати.

namespace Delegates
{
    // Клас, на метод якого буде посилатись делегат.
    class MyClass
    {
        // Створюємо метод, на який буде посилатись делегат.
        public string Method(string name)
        {
            return "Hello" + name;
        }
    }

    // На 21-му рядку створюємо делегат з іменем MyDelegate,
    // що буде містити посилання на метод, який
    // буде приймати один аргумент типу string і повертати значення типу string.

    public delegate string MyDelegate(string name); // Створюємо делегат. (1)

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Створюємо екземпляр делегата. Спосіб 1. (2)
            //MyDelegate myDelegate = instance.Method; // Створюємо екземпляр делегата. Спосіб 2. (2')

            string greeting = myDelegate.Invoke("Jeffrey Richter"); // Викликаємо метод, на який посилається делегат. Спосіб 1. (3)

            Console.WriteLine(greeting);

            greeting = myDelegate("Grady Booch"); // Викликаємо метод, на який посилається делегат. Спосіб 2. (3')

            Console.WriteLine(greeting);

            // Delay.
            Console.ReadKey();
        }
    }
}