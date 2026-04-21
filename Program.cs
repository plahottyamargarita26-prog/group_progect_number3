using System.Text;
using System;
using System.Linq;
class Program
{
    static int[][] arr = null;
    static void Main(string[] args)
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("======================МЕНЮ========================");
            Console.WriteLine("1. Варіант 6 (Батир)");
            Console.WriteLine("2. Варіант 4 (Тестовий варіант для перевірки)");
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
                    arr = ValeriaVar.DoBlock_1(arr); //не воїд щоб можна було взяти змінений масив. якщо воїд то масив в мейні не зміниться (можна реф звісно але все одно присвоюємо значення одного масива іншому то не знаю)
                    ArrayUtils.WriteArr(arr);
                    break;
                case 2:
                    if (arr== null)
                    {
                        arr = ArrayUtils.ChooseInputMethod();
                        ArrayUtils.WriteArr(arr);
                    }
                    arr = ValeriaVar.DoBlock_2(arr);
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