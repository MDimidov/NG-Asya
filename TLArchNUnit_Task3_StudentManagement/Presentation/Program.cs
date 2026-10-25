
using System;
using System.Collections.Generic;
using TLArchNUnit_Task3_StudentManagement.Business;
using TLArchNUnit_Task3_StudentManagement.Data;

namespace TLArchNUnit_Task3_StudentManagement.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме конзолно меню:
        //
        // 1. Добавяне на студент
        // 2. Студент с най-висок успех
        // 3. Студенти от курс с успех над 4.50
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект от StudentManager.
            //
            // Чрез него ще използваме методите
            // от Business Layer.

            StudentManager manager = new StudentManager();

            // while (true) повтаря менюто,
            // докато потребителят не избере 0.

            while (true)
            {
                Console.WriteLine("\n=== СИСТЕМА ЗА СТУДЕНТСКИ УСПЕХ ===");
                Console.WriteLine("1. Добави студент");
                Console.WriteLine("2. Студент с най-висок успех");
                Console.WriteLine("3. Студенти от курс с успех над 4.50");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");

                // Прочитаме избора на потребителя.
                //
                // Console.ReadLine() връща текста,
                // който е написан в конзолата.

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    // Създаваме нов студент.
                    //
                    // След това попълваме
                    // неговите свойства.

                    Student student = new Student();

                    Console.Write("Факултетен номер: ");
                    student.FacultyNumber = int.Parse(Console.ReadLine()!);

                    Console.Write("Име на студента: ");
                    student.FullName = Console.ReadLine() ?? "";

                    Console.Write("Успех: ");
                    student.Grade = double.Parse(Console.ReadLine()!);

                    Console.Write("Курс: ");
                    student.Course = int.Parse(Console.ReadLine()!);

                    // Извикваме AddStudent().
                    //
                    // Методът проверява дали успехът
                    // е между 2.00 и 6.00.
                    //
                    // Ако е валиден, студентът
                    // се добавя в списъка.

                    bool added = manager.AddStudent(student);

                    if (added)
                    {
                        Console.WriteLine("Студентът е добавен успешно!");
                    }
                    else
                    {
                        Console.WriteLine("Невалиден успех! Трябва да е от 2.00 до 6.00.");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим студента с най-висок успех.
                    //
                    // Student? означава, че резултатът
                    // може да бъде студент или null.
                    //
                    // null ще получим, когато
                    // няма регистрирани студенти.

                    Student? student = manager.GetTopStudent();

                    if (student == null)
                    {
                        Console.WriteLine("Няма регистрирани студенти.");
                    }
                    else
                    {
                        Console.WriteLine($"Факултетен номер: {student.FacultyNumber}");
                        Console.WriteLine($"Име: {student.FullName}");
                        Console.WriteLine($"Успех: {student.Grade:F2}");
                        Console.WriteLine($"Курс: {student.Course}");
                    }
                }
                else if (choice == "3")
                {
                    // Потребителят въвежда курс.
                    //
                    // Например: 2
                    //
                    // Търсим всички студенти
                    // от този курс с успех над 4.50.

                    Console.Write("Въведи курс: ");
                    int course = int.Parse(Console.ReadLine()!);

                    // Получаваме списък с резултатите.

                    List<Student> students =
                        manager.GetExcellentStudentsByCourse(course);

                    // Проверяваме дали списъкът е празен.

                    if (students.Count == 0)
                    {
                        Console.WriteLine("Няма намерени студенти.");
                    }
                    else
                    {
                        Console.WriteLine("\nНамерени студенти:");

                        // foreach обхожда всеки
                        // намерен студент.
                        //
                        // :F2 означава, че успехът
                        // ще се показва с 2 цифри
                        // след десетичния разделител.
                        //
                        // Например: 5.50

                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{student.FullName} - Успех: {student.Grade:F2}");
                        }
                    }
                }
                else if (choice == "0")
                {
                    // break прекратява цикъла.
                    //
                    // Така приключва програмата.

                    break;
                }
                else
                {
                    Console.WriteLine("Невалиден избор!");
                }
            }
        }
    }
}
