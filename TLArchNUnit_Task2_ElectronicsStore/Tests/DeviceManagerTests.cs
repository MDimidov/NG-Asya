
using System;
using NUnit.Framework;
using TLArchNUnit_Task2_ElectronicsStore.Business;
using TLArchNUnit_Task2_ElectronicsStore.Data;

namespace TLArchNUnit_Task2_ElectronicsStore.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Сега трябва да проверим дали
    // нашият магазин работи правилно.
    //
    // Вместо всеки път ръчно да добавяме
    // устройства и да проверяваме резултатите,
    // използваме NUnit.
    //
    // NUnit може автоматично да проверява
    // дали методите връщат правилни резултати.
    //
    // Всеки тест има три стъпки:
    //
    // 1. Подготвяме данните.
    // 2. Извикваме метода.
    // 3. Проверяваме резултата.
    //
    // [TestFixture] казва на NUnit:
    // "Този клас съдържа тестове."

    [TestFixture]
    public class DeviceManagerTests
    {
        // Тази променлива ще използваме,
        // за да извикваме методите
        // на DeviceManager.
        //
        // null! казва на компилатора,
        // че ще зададем стойност по-късно.
        //
        // С други думи казваме с null! 
        // Не ми показвай warning обещавам, че няма да е null
        //
        // Това ще стане в Setup().

        private DeviceManager manager = null!;

        // [SetUp] означава:
        //
        // "Изпълни този метод преди всеки тест."
        //
        // Защо?
        //
        // Представи си, че първият тест
        // добавя 3 устройства.
        //
        // Вторият тест трябва да започне
        // с празен магазин, а не с тези
        // 3 устройства.
        //
        // Затова преди всеки тест
        // изчистваме списъка.

        [SetUp]
        public void Setup()
        {
            // Clear() премахва всички устройства.

            StoreData.Devices.Clear();

            // Създаваме нов DeviceManager.

            manager = new DeviceManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на устройство
        // ====================================

        [Test]
        public void AddDevice_ValidDevice_ShouldAddDevice()
        {
            // СТЪПКА 1: Подготвяме устройство.

            Device device = new Device
            {
                Id = 1,
                Name = "Телевизор",
                Brand = "Samsung",
                PowerWatts = 150,
                Price = 1200
            };

            // СТЪПКА 2: Добавяме устройството.
            //
            // Очакваме методът да върне true.

            bool result = manager.AddDevice(device);

            // СТЪПКА 3: Проверяваме резултата.
            //
            // Assert.That() проверява
            // дали дадено условие е изпълнено.
            //
            // Is.True означава:
            // "Очаквам резултатът да е true."

            Assert.That(result, Is.True);

            // Проверяваме дали списъкът
            // съдържа точно 1 устройство.
            //
            // Is.EqualTo(1) означава:
            // "Очаквам стойността да е 1."

            Assert.That(StoreData.Devices.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Добавяне на null
        // ====================================

        [Test]
        public void AddDevice_NullDevice_ShouldNotAddDevice()
        {
            // Опитваме се да добавим null.
            //
            // null означава, че нямаме
            // истински обект Device.
            //
            // Очакваме методът да върне false.

            bool result = manager.AddDevice(null!);

            // Проверяваме дали добавянето
            // е било неуспешно.

            Assert.That(result, Is.False);

            // Проверяваме дали магазинът
            // все още е празен.

            Assert.That(StoreData.Devices.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Най-мощно устройство
        // ====================================

        [Test]
        public void GetMostPowerfulDevice_ShouldReturnMostPowerful()
        {
            // Добавяме три устройства.
            //
            // Телевизор -> 150 W
            // Сешоар    -> 2000 W
            // Лаптоп    -> 90 W
            //
            // Очакваме да намерим Сешоар,
            // защото има най-висока мощност.

            manager.AddDevice(new Device
            {
                Id = 1,
                Name = "Телевизор",
                Brand = "Samsung",
                PowerWatts = 150,
                Price = 1200
            });

            manager.AddDevice(new Device
            {
                Id = 2,
                Name = "Сешоар",
                Brand = "Philips",
                PowerWatts = 2000,
                Price = 100
            });

            manager.AddDevice(new Device
            {
                Id = 3,
                Name = "Лаптоп",
                Brand = "Lenovo",
                PowerWatts = 90,
                Price = 1500
            });

            // Извикваме метода, който тестваме.

            Device? result = manager.GetMostPowerfulDevice();

            // Проверяваме дали сме намерили
            // устройство, а не null.

            Assert.That(result, Is.Not.Null);

            // Проверяваме мощността.
            //
            // Очакваме 2000 W.

            Assert.That(result!.PowerWatts, Is.EqualTo(2000));

            // Проверяваме и името.

            Assert.That(result.Name, Is.EqualTo("Сешоар"));
        }

        // ====================================
        // ТЕСТ 4: Празен магазин
        // ====================================

        [Test]
        public void GetMostPowerfulDevice_EmptyStore_ShouldReturnNull()
        {
            // Не добавяме никакви устройства.
            //
            // Очакваме методът да върне null,
            // защото няма устройство за намиране.

            Device? result = manager.GetMostPowerfulDevice();

            // Is.Null означава:
            //
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 5: Средна цена по марка
        // ====================================

        [Test]
        public void GetAveragePriceByBrand_ShouldReturnAveragePrice()
        {
            // Добавяме три устройства.
            //
            // Samsung телевизор -> 1000 лв.
            // Samsung телефон   -> 500 лв.
            // Lenovo лаптоп     -> 1500 лв.
            //
            // Търсим средната цена за Samsung.
            //
            // Събираме:
            // 1000 + 500 = 1500
            //
            // Делим на броя устройства:
            // 1500 / 2 = 750
            //
            // Очакван резултат: 750

            manager.AddDevice(new Device
            {
                Id = 1,
                Name = "Телевизор",
                Brand = "Samsung",
                PowerWatts = 150,
                Price = 1000
            });

            manager.AddDevice(new Device
            {
                Id = 2,
                Name = "Телефон",
                Brand = "Samsung",
                PowerWatts = 25,
                Price = 500
            });

            manager.AddDevice(new Device
            {
                Id = 3,
                Name = "Лаптоп",
                Brand = "Lenovo",
                PowerWatts = 90,
                Price = 1500
            });

            // Търсим средната цена за Samsung.

            decimal result =
                manager.GetAveragePriceByBrand("Samsung");

            // Проверяваме дали резултатът е 750.
            //
            // Буквата m означава, че числото
            // е от тип decimal.
            // Ако числото беше double щеше да има буква d
            // или щеше да е 750.0

            Assert.That(result, Is.EqualTo(750m));
        }

        // ====================================
        // ТЕСТ 6: Марка без устройства
        // ====================================

        [Test]
        public void GetAveragePriceByBrand_UnknownBrand_ShouldReturnZero()
        {
            // Добавяме едно устройство.

            manager.AddDevice(new Device
            {
                Id = 1,
                Name = "Телевизор",
                Brand = "Samsung",
                PowerWatts = 150,
                Price = 1200
            });

            // Търсим средната цена за Sony.
            //
            // Но нямаме устройства от Sony.
            //
            // Очакваме методът да върне 0.

            decimal result = manager.GetAveragePriceByBrand("Sony");

            // Проверяваме дали резултатът е 0.

            Assert.That(result, Is.EqualTo(0m));
        }

        // ====================================
        // ТЕСТ 7: Само едно устройство
        // ====================================

        [Test]
        public void GetAveragePriceByBrand_OneDevice_ShouldReturnItsPrice()
        {
            // Добавяме едно устройство.
            //
            // Марка: Philips
            // Цена: 200 лв.
            //
            // Когато имаме само една цена,
            // средната цена е самата цена.
            //
            // 200 / 1 = 200

            manager.AddDevice(new Device
            {
                Id = 1,
                Name = "Сешоар",
                Brand = "Philips",
                PowerWatts = 2000,
                Price = 200
            });

            decimal result =
                manager.GetAveragePriceByBrand("Philips");

            // Очакваме резултат 200.

            Assert.That(result, Is.EqualTo(200m));
        }
    }
}
