
using System;
using TLArchNUnit_Task6_ProjectTracker.Business;
using TLArchNUnit_Task6_ProjectTracker.Data;

namespace TLArchNUnit_Task6_ProjectTracker.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме конзолно меню:
        //
        // 1. Добавяне на проект
        // 2. Активен проект с най-голям бюджет
        // 3. Среден брой хора по статус
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект от ProjectManager.
            //
            // Чрез него ще извикваме методите,
            // написани в Business Layer.

            ProjectManager manager = new ProjectManager();

            // while (true) повтаря менюто,
            // докато потребителят не избере 0.

            while (true)
            {
                Console.WriteLine("\n=== УПРАВЛЕНИЕ НА ПРОЕКТИ ===");
                Console.WriteLine("1. Добави проект");
                Console.WriteLine("2. Активен проект с най-голям бюджет");
                Console.WriteLine("3. Среден брой хора по статус");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");

                // Console.ReadLine() прочита
                // въведения от потребителя текст.
                //
                // ?? "" означава:
                // Ако получим null,
                // използвай празен текст.

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    // Създаваме нов проект.
                    //
                    // След това попълваме
                    // неговите свойства.

                    Project project = new Project();

                    Console.Write("ID: ");
                    project.Id = int.Parse(Console.ReadLine()!);

                    Console.Write("Име на проекта: ");
                    project.Name = Console.ReadLine() ?? "";

                    Console.Write("Бюджет: ");
                    project.Budget = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Брой хора в екипа: ");
                    project.TeamSize = int.Parse(Console.ReadLine()!);

                    Console.Write("Статус (Planned/Active/Completed): ");
                    project.Status = Console.ReadLine() ?? "";

                    // Извикваме метода AddProject().
                    //
                    // Методът проверява дали:
                    // - името е валидно
                    // - бюджетът не е отрицателен
                    // - броят хора не е отрицателен
                    // - статусът е валиден
                    //
                    // Ако всичко е правилно,
                    // проектът се добавя.

                    bool added = manager.AddProject(project);

                    if (added)
                    {
                        Console.WriteLine("Проектът е добавен успешно!");
                    }
                    else
                    {
                        Console.WriteLine("Невалидни данни за проекта!");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим активния проект
                    // с най-голям бюджет.
                    //
                    // Project? означава,
                    // че резултатът може да бъде
                    // обект Project или null.
                    //
                    // null ще получим,
                    // ако няма активни проекти.

                    Project? project =
                        manager.GetHighestBudgetActiveProject();

                    if (project == null)
                    {
                        Console.WriteLine("Няма активни проекти.");
                    }
                    else
                    {
                        Console.WriteLine($"ID: {project.Id}");
                        Console.WriteLine($"Име: {project.Name}");
                        Console.WriteLine($"Бюджет: {project.Budget:F2} лв.");
                        Console.WriteLine($"Брой хора: {project.TeamSize}");
                        Console.WriteLine($"Статус: {project.Status}");
                    }
                }
                else if (choice == "3")
                {
                    // Потребителят въвежда статус.
                    //
                    // Например: Active
                    //
                    // Методът ще намери всички
                    // проекти с този статус.
                    //
                    // Ще събере броя хора
                    // в техните екипи и ще раздели
                    // сбора на броя проекти.

                    Console.Write("Въведи статус (Planned/Active/Completed): ");
                    string status = Console.ReadLine() ?? "";

                    // Извикваме метода
                    // GetAverageTeamSizeByStatus().
                    //
                    // Той връща число от тип double.

                    double averageTeamSize =
                        manager.GetAverageTeamSizeByStatus(status);

                    // :F2 показва числото с два
                    // знака след десетичния разделител.
                    //
                    // Например:
                    // 5 -> 5.00
                    // 2.5 -> 2.50

                    Console.WriteLine(
                        $"Среден брой хора за {status}: {averageTeamSize:F2}");
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
