using System.Text;
using System;
using System.Linq;
public static class ValeriaVar
{
    public static int[][] DoBlock_1(int[][] arr)
    {
        Console.WriteLine("Знищити всі елементи з парними індексами");
        int[] halves = new int[arr.Length];
        for (int i = 0; i < halves.Length; i++)
            halves[i] = arr[i].Length - (arr[i].Length / 2);
        int[][] arres = new int[arr.Length][];
        for (int i = 0; i < arres.Length; i++)
        {
            arres[i] = new int[halves[i]];
            for (int j = 0; j < halves[i]; j++)
            {
                arres[i][j] = arr[i][j * 2];
            }
        }

        return arres;

    }
    public static int[][] DoBlock_2(int[][] arr)
    {
        Console.WriteLine("Додати рядок перед рядком, що містить мінімальний елемент (якщо у різних місцях є кілька елементів\nз однаковим мінімальним значенням, то брати перший з них)");
        int[] min = { 0, 0 };
        for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr[i].Length; j++)
                if (arr[i][j] < arr[min[0]][min[1]])
                {
                    min[0] = i;
                    min[1] = j;
                }

        Array.Resize(ref arr, arr.Length + 1);

        for (int i = arr.Length - 1; i > min[0]; i--)
            arr[i] = arr[i - 1];

        Console.WriteLine("Введіть межі можливої кількості значень у одному рядку");
        int[] kilk = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Введіть межі можливих випадкових значень");
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Random rndGen = new Random();

        int k = rndGen.Next(kilk[0], kilk[1]);
        arr[min[0]] = new int[k];
        for (int j = 0; j < k; j++)
            arr[min[0]][j] = rndGen.Next(num[0], num[1] + 1);
        return arr;
    }
    
}