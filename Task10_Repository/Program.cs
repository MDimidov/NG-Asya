using System;
using System.Collections.Generic;

namespace Task10_Repository
{
    /*
     Задача 10: Клас Repository<T> с шаблонен метод Find<U>(U key)
     Съхранявайте обекти и ги намирайте по ключ от различен тип.
     В учебния пример търсим ученици по int ID или string име.
    */
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            // ToString определя как се показва обектът чрез Console.WriteLine.
            return $"{Id} - {Name}";
        }
    }

    class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Find<U>(U key)
        {
            foreach (T item in items)
            {
                // Тук демонстрираме търсене само за обекти Student.
                if (item is Student student)
                {
                    // Ако ключът е цяло число, сравняваме го с Id.
                    if (key is int id && student.Id == id)
                    {
                        Console.WriteLine(student);
                    }
                    // Ако ключът е текст, сравняваме го с Name.
                    else if (key is string name && student.Name == name)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Student> students = new Repository<Student>();
            students.Add(new Student(1, "Ivan"));
            students.Add(new Student(2, "Maria"));
            students.Add(new Student(3, "Peter"));

            Console.WriteLine("Търсене по ID:");
            students.Find<int>(2);
            Console.WriteLine("Търсене по име:");
            students.Find<string>("Peter");
        }
    }
}
