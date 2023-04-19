using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessson5
{


    delegate string myDel(int _number);   //делегаты
    internal class Program
    {
        static string numName(int _num)
        {
            Console.WriteLine("numName");
            string result = string.Empty;
            switch (_num)
            {
                case 0: result = "нуль"; break;
                default:
                    break;
            }
            return result; 
        }


        static string test(int _num)
        {
            Console.WriteLine("test");
            return "test";
        }
        static void Main(string[] args)
        {
            //ReGex - глава про Dot Net
            // /Книга Регулярные выражения Дж. Фридл
            // 1.поиск и проверка интресубщих выражений в тексте
            // 2. замена интересующих совпаддений на орределенный текст
            // 3. подсчет количества совпадений
            // включаем Using RegularExpressions;

            //for (int i = (int)'0'; i <= (int)'9'; i++)
            //{
            //    Console.WriteLine($"Code of symbol {(char)i} = {i}");
            //}
            //\d+ плюс говорит что последовательность имеет 1 или более символов 
            string input = " bbbbbb ";
            if(args.Length > 0)
            {
                input = args[0];
            }
            Regex regex = new Regex(@"Игорь", RegexOptions.IgnoreCase);
            MatchCollection matchFind = regex.Matches(input);


                int counter = 1;

                foreach (var item in matchFind)
            {
                Console.WriteLine($"Совпадение номер {counter}{item} ");
                counter++;

            }

            //делегаты

            myDel print = numName;
            print += test;
            print(0);
            Console.WriteLine(print(0)); 

            Console.ReadLine();
        }
    }
}
