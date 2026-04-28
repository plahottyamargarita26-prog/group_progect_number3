using System;

namespace ArrayApp
{
    class Program
    {

        static void RunFirstBlock()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ВИКОНАННЯ БЛОКУ 1(Науменко)");

            int[] array1D = Choose();

            Console.Write("Введіть індекс K (з якого видаляти): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість T (скільки видалити): ");
            int t = int.Parse(Console.ReadLine());

             Naumenko_blok1(ref array1D, k, t);

            Console.WriteLine("Результат:");
            Show(array1D);

            Console.WriteLine("Натисніть Enter...");
            Console.ReadLine();
        }


   
        public static void Naumenko_blok1(ref int[] a, int k, int t)
        {
            if (a == null || k < 0 || t < 0 || k + t > a.Length)
            {
                Console.WriteLine("Помилка: некоректні параметри видалення.");
                return;
            }

            for (int i = k; i < a.Length - t; i++)
            {
                a[i] = a[i + t];
            }

            Array.Resize(ref a, a.Length - t);
        }

      
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Масив порожній.");
                return;
            }

        }
    }
