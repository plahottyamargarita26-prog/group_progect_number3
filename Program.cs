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
            Console.WriteLine("\n======================ÌÅÍÞ========================");
            Console.WriteLine("1. Âàð³àíò 6 (Áàòèð Âàëåð³ÿ)");
            Console.WriteLine("2. Âàð³àíò 1 (Êîâàëåíêî Äàð'ÿ)");
            Console.WriteLine("3. Âàð³àíò 2 (Íàóìåíêî Àíàñòàñ³ÿ)");
            Console.WriteLine("4. Âàð³àíò 3 (Ïëàõîòòÿ Ìàðãàðèòà)");
            Console.WriteLine("0. Âèõ³ä");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (arr == null)
                    {
                        arr = ArrayUtils.ChooseInputMethod();
                        ArrayUtils.WriteArr(arr);
                    }
                    arr = ValeriaVar.DoBlock_1(arr); //íå âî¿ä ùîá ìîæíà áóëî âçÿòè çì³íåíèé ìàñèâ. ÿêùî âî¿ä òî ìàñèâ â ìåéí³ íå çì³íèòüñÿ (ìîæíà ðåô çâ³ñíî àëå âñå îäíî ïðèñâîþºìî çíà÷åííÿ îäíîãî ìàñèâà ³íøîìó òî íå çíàþ)
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
                    Console.WriteLine("Çàðàç çàâåðøèìî, ò³ëüêè íàòèñí³òü áóäü ëàñêà ùå ðàç Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Êîìàíäà ``{0}'' íå ðîçï³çíàíà. Çðîá³òü, áóäü ëàñêà, âèá³ð ³ç 1, 2, 0.", choice);
                    break;
            }
        } while (choice != 0);
    }
}
