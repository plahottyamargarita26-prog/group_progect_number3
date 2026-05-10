using System.Text;
using System;
using System.Linq;

    class Program
    {
        static int[] arr = null;
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("\n======================МЕНЮ========================");
                Console.WriteLine("1. Варіант 6");
                Console.WriteLine("2. Варіант 3");
                Console.WriteLine("3. Варіант 4");
                Console.WriteLine("4. Варіант 11");
                Console.WriteLine("0. Вихід");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        while (arr == null || arr.Length == 0)
                        {
                            arr = ArrayUtils.ChooseInputMethod();
                            ArrayUtils.WriteArr(arr);
                        }
                        arr = ValeriaVar.DoBlock_1(arr);
                        ArrayUtils.WriteArr(arr);
                        break;
                    case 2:
                        while (arr == null || arr.Length == 0)
                        {
                            arr = ArrayUtils.ChooseInputMethod();
                            ArrayUtils.WriteArr(arr);
                        }
                        arr = KovalenkoVar.DoBlock_1(arr);
                        ArrayUtils.WriteArr(arr);
                        break;
                    case 3:
                        while (arr == null || arr.Length == 0)
                        {
                            arr = ArrayUtils.ChooseInputMethod();
                            ArrayUtils.WriteArr(arr);
                        }
                        arr = Naumenko.Naumenko_blok1(ref arr);
                        ArrayUtils.WriteArr(arr);
                        break;
                    case 4:
                        while (arr == null || arr.Length == 0)
                        {
                            arr = ArrayUtils.ChooseInputMethod();
                            ArrayUtils.WriteArr(arr);
                        }

                        arr = MargaritaVar.DoBlock_1(arr);
                        ArrayUtils.WriteArr(arr);
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2, 3, 4, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }


