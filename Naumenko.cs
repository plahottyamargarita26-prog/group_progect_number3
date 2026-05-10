using System;

namespace ArrayApp
{
    class Program
    {
        public static int[] Naumenko_blok1(ref int[] a)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ВИКОНАННЯ БЛОКУ 1(Науменко)");
            Console.WriteLine("Знищити T елементів, починаючи з номеру К (лише якщо всі такі елементи фактично є в масиві)");

            int[] array1D = a;

            Console.Write("Введіть індекс K (з якого видаляти): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість T (скільки видалити): ");
            int t = int.Parse(Console.ReadLine());


            if (a == null || k < 0 || t < 0 || k + t > a.Length)
            {
                Console.WriteLine("Помилка: некоректні параметри видалення.");
                return a;
            }

            for (int i = k; i < a.Length - t; i++)
            {
                a[i] = a[i + t];
            }

            Array.Resize(ref a, a.Length - t);
            return a;
        }
    }

}
