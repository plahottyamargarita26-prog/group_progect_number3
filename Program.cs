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
            Console.WriteLine("1. Варіант 6 (Батир Валерія)");
            Console.WriteLine("2. Варіант 1 (Коваленко Дар'я)");
            Console.WriteLine("3. Варіант 2 (Науменко Анастасія)");
            Console.WriteLine("4. Варіант 3 (Плахоття Маргарита)");
            Console.WriteLine("0. Вихід");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (arr == null)
                    {
                        arr = ArrayUtils.ChooseInputMethod();
                        ArrayUtils.WriteArr(arr);
                    }
                    arr = ValeriaVar.DoBlock_1(arr);
                    ArrayUtils.WriteArr(arr);
                    break;
                case 2:
                    if (arr == null)
                    {
                        arr = ArrayUtils.ChooseInputMethod();
                        ArrayUtils.WriteArr(arr);
                    }
                    arr = Naumenko_blok1(ref arr); 
                    ArrayUtils.WriteArr(arr);
                    break;
                     case 3:
                    if (arr == null)
                    {
                        arr = ArrayUtils.ChooseInputMethod();
                        ArrayUtils.WriteArr(arr);
                    }
                    arr = Naumenko_blok1(ref arr); 
                    ArrayUtils.WriteArr(arr);
                    break;
                    case 4:
                     if (arr == null)
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
                    Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2, 0.", choice);
                    break;
            }
        } while (choice != 0);
    }
}
