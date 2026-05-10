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
            Console.WriteLine("1. Вручну.");
            Console.WriteLine("2. Рандомно.");
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
        int[] arr = null;
        if (str[0] == "")
        {
            return arr;
        }
        arr = new int[str.Length];
            
        for (int j = 0; j < str.Length; j++)
        {
            arr[j] = Convert.ToInt32(str[j]);
        }
        return arr;
    }
    public static int[] RanInput()
    {
        Console.WriteLine("Ваша кількість елементів випадкова чи введена власноруч?");
        Console.WriteLine("1. Власноруч.");
        Console.WriteLine("2. Випадкове.");
        Random rndGen = new Random();
        int isRandomAmo=0;
        int[] userinput = { -1};
        do
        {
            if (isRandomAmo!=1&&isRandomAmo!=2)
            isRandomAmo = int.Parse(Console.ReadLine());
            switch (isRandomAmo)
            {
                case 1:
                    Console.WriteLine("Введіть кількість елементів:");
                    userinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    break;
                case 2:
                    Console.WriteLine("Введіть межі можливої кількості елементів (мінімальне та макcимальне):");
                    userinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    userinput[0] = rndGen.Next(Math.Min(userinput[0], userinput[1]), Math.Max(userinput[0], userinput[1])+1);
                    Console.WriteLine("Згенерована кількість елементів: " + userinput[0]);
                    break;
                default:
                    Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2.", isRandomAmo);
                    break;
            }
            if (userinput[0] < 0)
                Console.WriteLine("Помилка: Отримана кількість не задовольняє умову. Спробуйте знову");
        } while (userinput[0] < 0); //|| isRandomAmo != 1 || isRandomAmo != 2
        //цикл повторюється без останніх двох умов (у випадку дефолт) через початкове значення <0

        int[] arr = new int[userinput[0]];

        Console.WriteLine("Введіть межі можливих випадкових значень (мінімальне та макcимальне)");
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int j = 0; j < userinput[0]; j++)
            arr[j] = rndGen.Next(Math.Min(num[0], num[1]), Math.Max(num[0], num[1]) + 1);

        return arr;
    }
    public static void WriteArr(int[] arr)
    {
        if (arr == null || arr.Length == 0)
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
