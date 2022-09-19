using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("staff.csv", true, Encoding.Unicode))
            {
                char key = 'д';

                do
                {
                    string guide = string.Empty;
                    Console.Write("\nВведите ID сотрудника: ", 10);
                    guide += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Дата и время добавления записи {now} {time}", 20);
                    guide += $"{now} {time}\t";

                    Console.Write("Введите Ф.И.О. сотрудника: ", 25);
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите возраст сотрудника: ", 5);
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите рост сотрудника: ", 5);
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите дату рождения сотрудника: ", 15);
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите место рождения сотрудника: ", 25);
                    guide += $"{Console.ReadLine()}\t";
                    sw.WriteLine(guide);
                    Console.Write("Продолжить н/д"); key = Console.ReadKey(true).KeyChar;
                }
                while (char.ToLower(key) == 'д');
            }

            using (StreamReader sr = new StreamReader("staff.csv", Encoding.Unicode))
            {
                string line;
                Console.WriteLine();
            }

        }
    }
}
