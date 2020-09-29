using System;
using System.Text;

// Лямбда вираз і лямбда оператор.

namespace Delegates
{
    public delegate int MyDelegate(int a);

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyDelegate myDelegate;

            myDelegate = delegate (int x) { return x * 2; }; // Анонімний метод

            myDelegate = (x) => {
                Console.WriteLine("Складний Лямбда-Вираз");
                return x * 2; 
            }; // Лямбда-Вираз.

            myDelegate = x => x * 2; // Лямбда-Вираз.

            int result = myDelegate(4);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}