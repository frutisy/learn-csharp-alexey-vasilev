using System;

namespace ConsoleApp
{
    class Student
    {
        public Guid id;
        public string firstname;
        public string lastname;
        public string middlename;
        public byte age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Фамилия: {lastname}");
            Console.WriteLine($"Имя: {firstname}");
            Console.WriteLine($"Отчество: {middlename}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }

        public string GetFullName()
        {
            return $"{lastname} {firstname} {middlename}";
        }
    }
}
