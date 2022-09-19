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
                    Console.Write("\nВведите ID сотрудника: ");
                    guide += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Дата и время добавления записи {now} {time}");
                    guide += $"{now} {time}\t";

                    Console.Write("Введите Ф.И.О. сотрудника: ");
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите возраст сотрудника: ");
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите рост сотрудника: ");
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите дату рождения сотрудника: ");
                    guide += $"{Console.ReadLine()}\t";

                    Console.Write("Введите место рождения сотрудника: ");
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

                while ((line = sr.ReadLine()) != null)
                {
                    string[] staff = line.Split('\t');
                    Console.WriteLine($"{staff[0], 8} {staff[1], 15} {staff[2], 30} {staff[3], 5} {staff[4], 5} {staff[5], 15} {staff[6], 25}");
                }
            }

        }
    }
}
