using System.Text;
using System;
using System.Linq;

public static class ArrayUtils
{
    public static int[][] ChooseInputMethod()
    {
        int textchoice;
        int[][] arr = null;
        do
        {
            Console.WriteLine("Чудово! Для початку оберіть метод введення масиву:");
            Console.WriteLine("Для введення зубчастого масиву самотужки введіть 1");
            Console.WriteLine("Для введення зубчастого масиву за допомогою випадково згенерованих значень введіть 2");
            textchoice = int.Parse(Console.ReadLine());
            switch (textchoice)
            {
                case 1:
                    Console.WriteLine("Вводимо значення власноруч");
                    arr = NonRanInput();
                    break;
                case 2:
                    Console.WriteLine("Вводимо випадково згенеровані значення");
                    arr = RanInput();
                    break;
                default:
                    Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2.", textchoice);
                    break;
            }
        } while (textchoice != 1 && textchoice != 2);
        return arr;
    }
    public static int[][] NonRanInput()
    {
        Console.WriteLine("Вкажіть кількість рядків зубчастого масиву:");
        int n = int.Parse(Console.ReadLine());
        int[][] arr = new int[n][];
        Console.WriteLine("Введіть елементи зубчастого масиву.");
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Trim().Split();
            arr[i] = new int[str.Length];
            for (int j = 0; j < str.Length; j++)
            {
                arr[i][j] = Convert.ToInt32(str[j]);
            }
        }
        return arr;
    }
    public static int[][] RanInput()
    {
        Console.WriteLine("Ваша кількість рядків випадкова чи введена власноруч?");
        Console.WriteLine("Введіть 1 та кількість рядків якщо власноруч");
        Console.WriteLine("Введіть 2 та межі можливих значень (мінімальне та макcимальне) якщо випадкове");
        Random rndGen = new Random();
        int[] userinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n;
        if (userinput[0] == 1)
            n = userinput[1];
        else
        {
            n = rndGen.Next(userinput[1], userinput[2] + 1);
            Console.WriteLine($"Випадково згенерована кількість рядків дорівнює: {n}");
        }
        int[][] arr = new int[n][];
        Console.WriteLine("Введіть межі можливої кількості значень у одному рядку");
        int[] kilk = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Введіть межі можливих випадкових значень");
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            int k = rndGen.Next(kilk[0], kilk[1] + 1);
            arr[i] = new int[k];
            for (int j = 0; j < k; j++)
                arr[i][j] = rndGen.Next(num[0], num[1] + 1);
        }

        return arr;
    }
    public static void WriteArr(int[][] arr)
    {
        Console.WriteLine("Ваш масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write($"\t {arr[i][j]}");
            }
            Console.WriteLine("\n");

        }
    }



}
