using System;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool exit = false;

            do
            {
                Console.WriteLine("\n1 - Блок 1 (Одновимірний масив: видалення)");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunFirstBlock();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Помилка: такого пункту немає. Натисніть Enter...");
                        Console.ReadLine();
                        break;
                }

            } while (!exit);
        }

        static void RunFirstBlock()
        {
            Console.WriteLine("ВИКОНАННЯ БЛОКУ 1");

            int[] array1D = Choose();

            Console.Write("Введіть індекс K (з якого видаляти): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість T (скільки видалити): ");
            int t = int.Parse(Console.ReadLine());

            Execute(ref array1D, k, t);

            Console.WriteLine("Результат:");
            Show(array1D);

            Console.WriteLine("Натисніть Enter...");
            Console.ReadLine();
        }

        public static int[] Choose()
        {
            Console.WriteLine("Оберіть спосіб заповнення: 1 - Вручну, 2 - Рандом:");
            string c = Console.ReadLine();
            if (c == "1")
            {
                return Manual();
            }
            else
            {
                return RandomArray(); 
            }
        }

        public static int[] Manual()
        {
            Console.Write("Кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        public static int[] RandomArray()
        {
            Random r = new Random();
            Console.Write("Кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 101);
            }
            return a;
        }

        public static void Execute(ref int[] a, int k, int t)
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

        public static void Show(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Масив порожній.");
                return;
            }
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}