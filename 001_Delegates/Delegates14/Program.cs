using System;

// Рекурсія в лямбда виразах.

namespace Delegates
{
    delegate void MyDelegate(int argument);

    class Program
    {
        static void Main()
        {
            MyDelegate my = null; // Потрібно обов'язково присвоїти null.

            // Потрібно окреме присвоїти посилання на лямбда вираз,
            // в місці створення змінної, неприпустимо відразу створювати лямбда вираз.

            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);

                if (i > 0)
                {
                    my(i);
                }

                Console.WriteLine("End {0}", i);
            };

            my(3);

            // Delay.
            Console.ReadKey();
        }
    }
}