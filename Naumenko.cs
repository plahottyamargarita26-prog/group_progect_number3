using System;

namespace ArrayApp
{
    class Program
    {

        public static void Naumenko_blok1(ref int[] a, int k, int t)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ВИКОНАННЯ БЛОКУ 1(Науменко)");

            int[] array1D = Choose();

            Console.Write("Введіть індекс K (з якого видаляти): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість T (скільки видалити): ");
            int t = int.Parse(Console.ReadLine());

            Console.ReadLine();
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


        }
    }
