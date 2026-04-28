using System.Text;
using System;
using System.Linq;

public static class ArrayUtils
{
    public static int[] ChooseInputMethod()
    {
        int textchoice;
        int[] arr = null;
        do
        {
            Console.WriteLine("Чудово! Для початку оберіть метод введення масиву:");
            Console.WriteLine("1. Ввести масив самотужки");
            Console.WriteLine("2. Ввести масив рандомно");
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
    public static int[] NonRanInput()
    {
        Console.WriteLine("Введіть масив");
        string[] str = Console.ReadLine().Trim().Split();
        int [] arr = new int[str.Length];
        for (int j = 0; j < str.Length; j++)
        {
            arr[j] = Convert.ToInt32(str[j]);
        }
        return arr;
    }
    public static int[] RanInput()
    {
        Console.WriteLine("Ваша кількість значень випадкова чи введена власноруч?");
        Console.WriteLine("Введіть 1 та кількість якщо власноруч");
        Console.WriteLine("Введіть 2 та межі можливих значень (мінімальне та макcимальне) якщо випадкове");
        Random rndGen = new Random();
        int[] userinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k=0;
        if (userinput[0] == 1)
            k = userinput[1];
        else
        {
            k = rndGen.Next(userinput[1], userinput[2] + 1);
            Console.WriteLine($"Випадково згенерована кількість значень у рядку дорівнює: {k}");
        }
        int[] arr = new int[k];

        Console.WriteLine("Введіть межі можливих випадкових значень");
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int j = 0; j < k; j++)
            arr[j] = rndGen.Next(num[0], num[1] + 1);

        return arr;
    }
    public static void WriteArr(int[] arr)
    {
        if (a == null || a.Length == 0)
            {
                Console.WriteLine("Масив порожній.");
                return;
            }
        Console.WriteLine("Ваш масив:");
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write($"\t {arr[j]}");
        }
        Console.WriteLine();
    }

}
