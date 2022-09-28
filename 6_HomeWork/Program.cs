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
            Console.Write("Вывести данные на экран - введите 1; \nЗаполнить данные - введите 2: "); // Начальное окно
            int action = int.Parse(Console.ReadLine());

            void Note() // Метод для заполнения данных
            {
                using (StreamWriter file = new StreamWriter("staff.csv", true, Encoding.Unicode)) // Создание файла
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
                        file.WriteLine(guide);
                        Console.Write("Продолжить н/д"); key = Console.ReadKey(true).KeyChar;
                    }
                    while (char.ToLower(key) == 'д');
                }
            }
            void Reading() // Метод для чтения файла
            {
                try // Чтение файла, если он создан
                {
                    using (StreamReader openFile = new StreamReader("staff.csv", Encoding.Unicode)) // Чтение файла
                    {
                        string line;
                        Console.WriteLine();

                        while ((line = openFile.ReadLine()) != null)
                        {
                            string[] staff = line.Split('\t');
                            Console.WriteLine($"{staff[0],8} {staff[1],15} {staff[2],30} {staff[3],5} {staff[4],5} {staff[5],15} {staff[6],25}");
                        }
                    }
                }
                catch // Создание нового файла, при его отсутствии. Выполнение метода Note
                {
                    Note();
                }
            }

            // Использование методов создания и чтения файлов, при условии ввода с клавиатуры 
            if (action == 2)
            {
                Note();
            }
            else if (action == 1)
            {
                Reading();
            }
            else Console.WriteLine("Некорректные данные. Перезапустите программу.");
            
        }
    }
}
