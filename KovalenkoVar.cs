using System;

public class KovalenkoVar
{
   
    static void RemoveByValue(ref int[] a, int key)
    {
        

        int pos = -1;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == key)
            {
                pos = i;
                break;
            }
        }

        if (pos == -1)
        {
            Console.WriteLine("Такого елемента нема");
            return;
        }

        int[] b = new int[a.Length - 1];

        for (int i = 0; i < pos; i++)
            b[i] = a[i];

        for (int i = pos + 1; i < a.Length; i++)
            b[i - 1] = a[i];

        a = b;
    }

    static public int[] DoBlock_1(int[] arr)
    {
        Console.WriteLine("Знищити елемент із заданим ключем (значенням); якщо таких нема, масив незмінний, якщо багато —\nвилучається лише перший");
        Console.WriteLine("Введіть ключ:");
        int key = int.Parse(Console.ReadLine());
        RemoveByValue(ref arr, key);
        return arr;
    }
}

