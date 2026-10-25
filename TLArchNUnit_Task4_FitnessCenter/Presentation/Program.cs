
using System;
using TLArchNUnit_Task4_FitnessCenter.Business;
using TLArchNUnit_Task4_FitnessCenter.Data;

namespace TLArchNUnit_Task4_FitnessCenter.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме конзолно меню:
        //
        // 1. Добавяне на клиент
        // 2. Клиент с най-много оставащи дни
        // 3. Общи такси по тип абонамент
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект от FitnessManager.
            //
            // Чрез него ще извикваме методите
            // от Business Layer.

            FitnessManager manager = new FitnessManager();

            // while (true) повтаря менюто,
            // докато потребителят не избере 0.

            while (true)
            {
                Console.WriteLine("\n=== ФИТНЕС ЗАЛА ===");
                Console.WriteLine("1. Добави клиент");
                Console.WriteLine("2. Клиент с най-много оставащи дни");
                Console.WriteLine("3. Общи такси по тип абонамент");
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
                    // Създаваме нов клиент.
                    //
                    // След това попълваме
                    // неговите свойства.

                    Member member = new Member();

                    Console.Write("ID: ");
                    member.Id = int.Parse(Console.ReadLine()!);

                    Console.Write("Име: ");
                    member.Name = Console.ReadLine() ?? "";

                    Console.Write("Тип абонамент (Месечен/Годишен): ");
                    member.Type = Console.ReadLine() ?? "";

                    Console.Write("Оставащи дни: ");
                    member.DaysRemaining = int.Parse(Console.ReadLine()!);

                    Console.Write("Месечна такса: ");
                    member.MonthlyFee = decimal.Parse(Console.ReadLine()!);

                    // Извикваме метода AddMember().
                    //
                    // Той проверява въведените данни
                    // и добавя клиента, ако са валидни.

                    bool added = manager.AddMember(member);

                    if (added)
                    {
                        Console.WriteLine("Клиентът е добавен успешно!");
                    }
                    else
                    {
                        Console.WriteLine("Невалидни данни за клиента!");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим клиента с най-много
                    // оставащи дни от абонамента.
                    //
                    // Member? означава, че резултатът
                    // може да бъде клиент или null.

                    Member? member = manager.GetMemberWithMostDays();

                    if (member == null)
                    {
                        Console.WriteLine("Няма регистрирани клиенти.");
                    }
                    else
                    {
                        Console.WriteLine($"ID: {member.Id}");
                        Console.WriteLine($"Име: {member.Name}");
                        Console.WriteLine($"Абонамент: {member.Type}");
                        Console.WriteLine($"Оставащи дни: {member.DaysRemaining}");
                        Console.WriteLine($"Месечна такса: {member.MonthlyFee:F2} лв.");
                    }
                }
                else if (choice == "3")
                {
                    // Потребителят въвежда тип абонамент.
                    //
                    // Например: "Месечен"
                    //
                    // Методът ще събере таксите
                    // само на клиентите с този тип.

                    Console.Write("Тип абонамент: ");
                    string type = Console.ReadLine() ?? "";

                    decimal totalRevenue =
                        manager.GetTotalRevenueByType(type);

                    // :F2 показва числото
                    // с два знака след десетичния
                    // разделител.
                    //
                    // Например: 130.00

                    Console.WriteLine(
                        $"Общи месечни такси за {type}: {totalRevenue:F2} лв.");
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
