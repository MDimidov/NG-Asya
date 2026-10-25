
using System;
using NUnit.Framework;
using TLArchNUnit_Task4_FitnessCenter.Business;
using TLArchNUnit_Task4_FitnessCenter.Data;

namespace TLArchNUnit_Task4_FitnessCenter.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Представи си, че сме направили програма
    // за управление на фитнес зала.
    //
    // Искаме да проверим дали:
    //
    // 1. Добавяме клиентите правилно.
    // 2. Отхвърляме невалидните данни.
    // 3. Намираме клиента с най-много дни.
    // 4. Изчисляваме правилно общите такси.
    //
    // NUnit извършва тези проверки автоматично.
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
    public class FitnessManagerTests
    {
        // Създаваме променлива за FitnessManager.
        //
        // Ще я използваме във всички тестове.
        //
        // null! означава, че ще зададем
        // стойност малко по-късно.
        //
        // Това се случва в Setup().

        private FitnessManager manager = null!;

        // [SetUp] означава:
        //
        // "Изпълни този метод преди всеки тест."
        //
        // Защо?
        //
        // Ако първият тест добави 3 клиента,
        // вторият трябва да започне
        // с празен списък.
        //
        // Така тестовете не си пречат.

        [SetUp]
        public void Setup()
        {
            // Clear() премахва всички клиенти.

            FitnessData.Members.Clear();

            // Създаваме нов FitnessManager.

            manager = new FitnessManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на валиден клиент
        // ====================================

        [Test]
        public void AddMember_ValidMember_ShouldAddMember()
        {
            // СТЪПКА 1: Подготвяме клиент.
            //
            // Клиентът има месечен абонамент
            // и 25 оставащи дни.

            Member member = new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 25,
                MonthlyFee = 60
            };

            // СТЪПКА 2: Добавяме клиента.

            bool result = manager.AddMember(member);

            // СТЪПКА 3: Проверяваме резултата.
            //
            // Assert.That() е команда на NUnit,
            // с която правим проверка.
            //
            // Is.True означава:
            // "Очаквам резултатът да е true."
            //
            // Ако е true -> тестът минава.
            // Ако е false -> тестът се проваля.

            Assert.That(result, Is.True);

            // Проверяваме дали списъкът
            // съдържа точно един клиент.
            //
            // Is.EqualTo(1) означава:
            // "Очаквам стойността да е 1."

            Assert.That(FitnessData.Members.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Добавяне на null
        // ====================================

        [Test]
        public void AddMember_NullMember_ShouldNotAddMember()
        {
            // Опитваме се да добавим null.
            //
            // null означава, че няма
            // създаден обект Member.
            //
            // Очакваме методът да върне false.

            bool result = manager.AddMember(null!);

            // Is.False означава:
            // "Очаквам резултатът да е false."

            Assert.That(result, Is.False);

            // Проверяваме дали списъкът
            // продължава да е празен.

            Assert.That(FitnessData.Members.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Невалиден тип абонамент
        // ====================================

        [Test]
        public void AddMember_InvalidType_ShouldNotAddMember()
        {
            // Създаваме клиент с абонамент
            // "Седмичен".
            //
            // Нашата система разрешава само:
            //
            // "Месечен"
            // "Годишен"
            //
            // Следователно очакваме false.

            Member member = new Member
            {
                Id = 2,
                Name = "Мария Петрова",
                Type = "Седмичен",
                DaysRemaining = 7,
                MonthlyFee = 20
            };

            bool result = manager.AddMember(member);

            Assert.That(result, Is.False);

            // Невалидният клиент не трябва
            // да бъде добавен в списъка.

            Assert.That(FitnessData.Members.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 4: Отрицателни оставащи дни
        // ====================================

        [Test]
        public void AddMember_NegativeDays_ShouldNotAddMember()
        {
            // Създаваме клиент с -5 оставащи дни.
            //
            // Това е невалидно.
            //
            // Очакваме методът да върне false.

            Member member = new Member
            {
                Id = 3,
                Name = "Георги Георгиев",
                Type = "Месечен",
                DaysRemaining = -5,
                MonthlyFee = 60
            };

            bool result = manager.AddMember(member);

            Assert.That(result, Is.False);

            Assert.That(FitnessData.Members.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 5: Отрицателна такса
        // ====================================

        [Test]
        public void AddMember_NegativeFee_ShouldNotAddMember()
        {
            // Създаваме клиент с такса -50 лв.
            //
            // Отрицателната цена е невалидна.
            //
            // Очакваме клиентът да не бъде добавен.

            Member member = new Member
            {
                Id = 4,
                Name = "Петър Петров",
                Type = "Годишен",
                DaysRemaining = 300,
                MonthlyFee = -50
            };

            bool result = manager.AddMember(member);

            Assert.That(result, Is.False);

            Assert.That(FitnessData.Members.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 6: Клиент с най-много дни
        // ====================================

        [Test]
        public void GetMemberWithMostDays_ShouldReturnCorrectMember()
        {
            // Добавяме трима клиенти.
            //
            // Иван   -> 25 дни
            // Мария  -> 300 дни
            // Георги -> 120 дни
            //
            // Очакваме да намерим Мария,
            // защото има най-много оставащи дни.

            manager.AddMember(new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 25,
                MonthlyFee = 60
            });

            manager.AddMember(new Member
            {
                Id = 2,
                Name = "Мария Петрова",
                Type = "Годишен",
                DaysRemaining = 300,
                MonthlyFee = 45
            });

            manager.AddMember(new Member
            {
                Id = 3,
                Name = "Георги Георгиев",
                Type = "Годишен",
                DaysRemaining = 120,
                MonthlyFee = 45
            });

            // Извикваме метода за търсене.

            Member? result = manager.GetMemberWithMostDays();

            // Is.Not.Null означава:
            // "Очаквам да е намерен обект."

            Assert.That(result, Is.Not.Null);

            // ! казва на компилатора,
            // че тук очакваме обект, а не null.
            //
            // Очакваме 300 дни.

            Assert.That(result!.DaysRemaining, Is.EqualTo(300));

            // Проверяваме и името на клиента.

            Assert.That(result.Name, Is.EqualTo("Мария Петрова"));
        }

        // ====================================
        // ТЕСТ 7: Празен списък с клиенти
        // ====================================

        [Test]
        public void GetMemberWithMostDays_EmptyList_ShouldReturnNull()
        {
            // Не добавяме никакви клиенти.
            //
            // Очакваме методът да върне null,
            // защото няма клиент за намиране.

            Member? result = manager.GetMemberWithMostDays();

            // Is.Null означава:
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 8: Общи такси за месечен абонамент
        // ====================================

        [Test]
        public void GetTotalRevenueByType_Monthly_ShouldReturnCorrectSum()
        {
            // Добавяме трима клиенти.
            //
            // Иван   -> Месечен -> 60 лв.
            // Мария  -> Годишен -> 45 лв.
            // Георги -> Месечен -> 70 лв.
            //
            // Търсим общите такси за "Месечен".
            //
            // Очакван резултат:
            //
            // 60 + 70 = 130 лв.

            manager.AddMember(new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 25,
                MonthlyFee = 60
            });

            manager.AddMember(new Member
            {
                Id = 2,
                Name = "Мария Петрова",
                Type = "Годишен",
                DaysRemaining = 300,
                MonthlyFee = 45
            });

            manager.AddMember(new Member
            {
                Id = 3,
                Name = "Георги Георгиев",
                Type = "Месечен",
                DaysRemaining = 15,
                MonthlyFee = 70
            });

            // Извикваме метода, който тестваме.

            decimal result = manager.GetTotalRevenueByType("Месечен");

            // Проверяваме дали сумата е 130.
            //
            // Буквата m означава,
            // че числото е от тип decimal.

            Assert.That(result, Is.EqualTo(130m));
        }

        // ====================================
        // ТЕСТ 9: Общи такси за годишен абонамент
        // ====================================

        [Test]
        public void GetTotalRevenueByType_Yearly_ShouldReturnCorrectSum()
        {
            // Добавяме трима клиенти.
            //
            // Иван   -> Месечен -> 60 лв.
            // Мария  -> Годишен -> 40 лв.
            // Петър  -> Годишен -> 50 лв.
            //
            // Търсим общите месечни такси
            // за годишните абонаменти.
            //
            // Очакван резултат:
            //
            // 40 + 50 = 90 лв.

            manager.AddMember(new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 25,
                MonthlyFee = 60
            });

            manager.AddMember(new Member
            {
                Id = 2,
                Name = "Мария Петрова",
                Type = "Годишен",
                DaysRemaining = 300,
                MonthlyFee = 40
            });

            manager.AddMember(new Member
            {
                Id = 3,
                Name = "Петър Петров",
                Type = "Годишен",
                DaysRemaining = 200,
                MonthlyFee = 50
            });

            decimal result = manager.GetTotalRevenueByType("Годишен");

            Assert.That(result, Is.EqualTo(90m));
        }

        // ====================================
        // ТЕСТ 10: Тип без намерени абонаменти
        // ====================================

        [Test]
        public void GetTotalRevenueByType_NoMatches_ShouldReturnZero()
        {
            // Добавяме един клиент с месечен абонамент.

            manager.AddMember(new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 25,
                MonthlyFee = 60
            });

            // Търсим такси за годишен абонамент.
            //
            // Но нямаме такива клиенти.
            //
            // Очакваме резултат 0.

            decimal result = manager.GetTotalRevenueByType("Годишен");

            Assert.That(result, Is.EqualTo(0m));
        }

        // ====================================
        // ТЕСТ 11: Един клиент
        // ====================================

        [Test]
        public void GetMemberWithMostDays_OneMember_ShouldReturnMember()
        {
            // Добавяме само един клиент.
            //
            // Когато има само един клиент,
            // той автоматично е този
            // с най-много оставащи дни.

            manager.AddMember(new Member
            {
                Id = 1,
                Name = "Иван Иванов",
                Type = "Месечен",
                DaysRemaining = 20,
                MonthlyFee = 60
            });

            Member? result = manager.GetMemberWithMostDays();

            // Очакваме да намерим клиент.

            Assert.That(result, Is.Not.Null);

            // Очакваме името да е Иван Иванов.

            Assert.That(result!.Name, Is.EqualTo("Иван Иванов"));

            // Очакваме 20 оставащи дни.

            Assert.That(result.DaysRemaining, Is.EqualTo(20));
        }

        // ====================================
        // ТЕСТ 12: Изтекъл абонамент
        // ====================================

        [Test]
        public void AddMember_ZeroDays_ShouldAddMember()
        {
            // Създаваме клиент с 0 оставащи дни.
            //
            // Това означава, че абонаментът
            // му вече е изтекъл.
            //
            // Но клиентът все още може
            // да присъства в нашата система.
            //
            // Следователно 0 е допустима стойност.

            Member member = new Member
            {
                Id = 1,
                Name = "Мария Петрова",
                Type = "Месечен",
                DaysRemaining = 0,
                MonthlyFee = 60
            };

            bool result = manager.AddMember(member);

            Assert.That(result, Is.True);

            Assert.That(FitnessData.Members.Count, Is.EqualTo(1));
        }
    }
}
