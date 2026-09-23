using System;
using System.Net.NetworkInformation;

class program
{
    static void Main()
    {
        string fio = "Истомин Максим";
        string  group = "исп - 243";
        Console.WriteLine("Здравствуйте");
        Console.WriteLine("Время: " + DateTime.Now);
        Console.WriteLine("Меню:");
        Console.WriteLine("1 — Показать ФИО");
        Console.WriteLine("2 — Показать группу");
        Console.WriteLine("3 — Показать дату");
        Console.WriteLine("4 — Выход");
        Console.Write("Выберите пункт: ");
        string cho = Console.ReadLine()!;
        if (cho == "1")
        {
            Console.WriteLine("Фио: " + fio);
        }
        else if (cho == "2")
        {
            Console.WriteLine("Группа: " + group);
        }
        else if (cho == "3")
        {
            Console.WriteLine("Дата и время: " + DateTime.Now);
        }
        else if (cho == "4")
        {
            Console.WriteLine("Выход из проги. Пока");
        }
        else
        {
            Console.WriteLine("Абшибка, попробуй еще раз");

        }

        }
    }

