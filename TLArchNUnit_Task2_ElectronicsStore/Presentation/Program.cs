
using System;
using TLArchNUnit_Task2_ElectronicsStore.Business;
using TLArchNUnit_Task2_ElectronicsStore.Data;

namespace TLArchNUnit_Task2_ElectronicsStore.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме конзолно меню:
        //
        // 1. Добавяне на устройство
        // 2. Най-мощно устройство
        // 3. Средна цена по марка
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект от DeviceManager.
            //
            // Чрез него ще извикваме методите
            // от Business Layer.

            DeviceManager manager = new DeviceManager();

            // while (true) означава,
            // че менюто ще се повтаря,
            // докато потребителят не избере 0.

            while (true)
            {
                Console.WriteLine("\n=== МАГАЗИН ЗА ЕЛЕКТРОНИКА ===");
                Console.WriteLine("1. Добави устройство");
                Console.WriteLine("2. Най-мощно устройство");
                Console.WriteLine("3. Средна цена по марка");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");

                // Console.ReadLine() прочита
                // написаното от потребителя.

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Създаваме ново устройство.
                    //
                    // След това попълваме
                    // неговите свойства.

                    Device device = new Device();

                    Console.Write("ID: ");
                    device.Id = int.Parse(Console.ReadLine()!);

                    Console.Write("Име: ");
                    device.Name = Console.ReadLine() ?? "";

                    Console.Write("Марка: ");
                    device.Brand = Console.ReadLine() ?? "";

                    Console.Write("Мощност (W): ");
                    device.PowerWatts = int.Parse(Console.ReadLine()!);

                    Console.Write("Цена: ");
                    device.Price = decimal.Parse(Console.ReadLine()!);

                    // Извикваме метода AddDevice().
                    //
                    // Той добавя устройството
                    // в списъка StoreData.Devices.

                    bool added = manager.AddDevice(device);

                    if (added)
                    {
                        Console.WriteLine("Устройството е добавено!");
                    }
                    else
                    {
                        Console.WriteLine("Невалидно устройство!");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим най-мощното устройство.
                    //
                    // ? след Device означава,
                    // че променливата може да е null.
                    //
                    // Това се случва, когато
                    // магазинът няма устройства.

                    Device? device = manager.GetMostPowerfulDevice();

                    if (device == null)
                    {
                        Console.WriteLine("Няма добавени устройства.");
                    }
                    else
                    {
                        Console.WriteLine($"Име: {device.Name}");
                        Console.WriteLine($"Марка: {device.Brand}");
                        Console.WriteLine($"Мощност: {device.PowerWatts} W");
                        Console.WriteLine($"Цена: {device.Price} лв.");
                    }
                }
                else if (choice == "3")
                {
                    // Потребителят въвежда марка.
                    //
                    // Например: Samsung

                    Console.Write("Въведи марка: ");
                    string brand = Console.ReadLine() ?? "";

                    // Извикваме метода за средна цена.
                    //
                    // Той събира цените само
                    // на устройствата от тази марка
                    // и ги разделя на техния брой.

                    decimal averagePrice = manager.GetAveragePriceByBrand(brand);

                    // Показваме резултата.
                    //
                    // :F2 означава да покажем
                    // числото с 2 знака след запетаята.
                    //
                    // Например: 600.00

                    Console.WriteLine($"Средна цена за {brand}: {averagePrice:F2} лв.");
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
