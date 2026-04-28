using System.Text;
using System;
using System.Linq;
public static class ValeriaVar
{
    public static int[] DoBlock_1(int[] arr)
    {
        Console.WriteLine("Знищити всі елементи з парними індексами");
        int halves = arr.Length - (arr.Length / 2);
        int[] arres = new int[halves];
        for (int i = 0; i < halves; i++)
            arres[i] = arr[i * 2];
        return arres;
    }
}
