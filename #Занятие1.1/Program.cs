using System;

namespace _Занятие1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            Console.WriteLine("Введите имя: ");
            people.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            people.lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            people.surName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: 00/00/0000 ");
            Console.WriteLine("День: ");
            people.day = Console.ReadLine();
            Console.WriteLine("Месяц: ");
            people.month = Console.ReadLine();
            Console.WriteLine("Год: ");
            people.year = Console.ReadLine();
            Console.WriteLine($"Ваши данные: {people.lastName} {people.firstName} {people.surName}, дата рождения {people.day}.{people.month}.{people.year}");
            Console.ReadKey();
        }
    }
}
