using System.Text;
using System;
using System.Linq;
public static class MargaritaVar
{
	public static int [] DoBlock_1(int [] arr)
	{
        Console.WriteLine("Вставити в початок масиву мінімум з усіх значень масиву, а в кінець — максимум");
        int[] input = arr;
            int min = input[0];
            int max = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
            int[] input_2 = new int[input.Length + 2];
            for (int i = 0; i < input.Length; i++)
            {
                input_2[i + 1] = input[i];
            }
            input_2[0] = min;
            input_2[input_2.Length - 1] = max;
            input = input_2;
            return input;

    }
}
