using System;
using System.Text;

// Комбіновані (групові) делегати.

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        // Методи.
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            // Комбінуємо делегати.
            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            //myDelegate += myDelegate1;
            //myDelegate += myDelegate2;
            //myDelegate += myDelegate3;

            Console.WriteLine("Введіть число від 1 до 7");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        myDelegate1.Invoke();
                        break;
                    }
                case "2":
                    {
                        myDelegate2.Invoke();
                        break;
                    }
                case "3":
                    {
                        myDelegate3.Invoke();
                        break;
                    }
                case "4":
                    {
                        MyDelegate myDelegate4 = myDelegate - myDelegate1;
                        myDelegate4.Invoke();
                        break;
                    }
                case "5":
                    {
                        MyDelegate myDelegate5 = myDelegate - myDelegate2;
                        myDelegate5.Invoke();
                        break;
                    }
                case "6":
                    {
                        MyDelegate myDelegate6 = myDelegate - myDelegate3;
                        myDelegate6.Invoke();
                        break;
                    }
                case "7":
                    {
                        myDelegate.Invoke();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ви ввели недійсне значення.");
                        break;
                    }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}