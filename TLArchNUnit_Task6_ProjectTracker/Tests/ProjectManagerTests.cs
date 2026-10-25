
using System;
using NUnit.Framework;
using TLArchNUnit_Task6_ProjectTracker.Business;
using TLArchNUnit_Task6_ProjectTracker.Data;

namespace TLArchNUnit_Task6_ProjectTracker.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Представи си, че сме създали система,
    // която управлява проектите на една фирма.
    //
    // Искаме да проверим дали:
    //
    // 1. Добавяме проекти правилно.
    // 2. Не добавяме проекти с невалидни данни.
    // 3. Намираме активния проект
    //    с най-голям бюджет.
    // 4. Изчисляваме правилно средния
    //    брой хора в екипите.
    //
    // Вместо да проверяваме всичко ръчно,
    // използваме NUnit.
    //
    // NUnit изпълнява автоматични тестове
    // и проверява дали резултатите са верни.
    //
    // Всеки тест има три основни стъпки:
    //
    // 1. Подготвяме данните.
    // 2. Извикваме метода.
    // 3. Проверяваме резултата.
    //
    // [TestFixture] казва на NUnit:
    // "Този клас съдържа тестове."

    [TestFixture]
    public class ProjectManagerTests
    {
        // Създаваме променлива за ProjectManager.
        //
        // Ще я използваме във всички тестове.
        //
        // null! казва на компилатора,
        // че ще зададем стойност по-късно.
        //
        // Това ще стане в Setup().

        private ProjectManager manager = null!;

        // [SetUp] означава:
        //
        // "Изпълни този метод ПРЕДИ всеки тест."
        //
        // Защо?
        //
        // Ако първият тест добави 3 проекта,
        // вторият не трябва да започва
        // с тези 3 проекта.
        //
        // Затова изчистваме списъка
        // преди всеки тест.

        [SetUp]
        public void Setup()
        {
            // Clear() премахва всички проекти
            // от общия списък.

            ProjectData.Projects.Clear();

            // Създаваме нов ProjectManager.

            manager = new ProjectManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на валиден проект
        // ====================================

        // [Test] казва на NUnit:
        // "Изпълни този метод като тест."

        [Test]
        public void AddProject_ValidProject_ShouldAddProject()
        {
            // СТЪПКА 1: Подготвяме проект.
            //
            // Проектът има:
            // - име
            // - положителен бюджет
            // - екип от 5 души
            // - валиден статус Active

            Project project = new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 15000,
                TeamSize = 5,
                Status = "Active"
            };

            // СТЪПКА 2: Добавяме проекта.
            //
            // Очакваме методът да върне true.

            bool result = manager.AddProject(project);

            // СТЪПКА 3: Проверяваме резултата.
            //
            // Assert.That() е команда на NUnit,
            // с която правим проверка.
            //
            // Is.True означава:
            // "Очаквам резултатът да бъде true."
            //
            // Ако е true -> тестът минава.
            // Ако е false -> тестът се проваля.

            Assert.That(result, Is.True);

            // Проверяваме дали списъкът
            // съдържа точно един проект.
            //
            // Is.EqualTo(1) означава:
            // "Очаквам стойността да е 1."

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Добавяне на null
        // ====================================

        [Test]
        public void AddProject_NullProject_ShouldNotAddProject()
        {
            // Опитваме се да добавим null.
            //
            // null означава, че нямаме
            // създаден обект Project.
            //
            // Очакваме методът да върне false.
            //
            // ! потиска предупреждението
            // на компилатора за null.
            //
            // Не създава истински обект.

            bool result = manager.AddProject(null!);

            // Is.False означава:
            // "Очаквам резултатът да бъде false."

            Assert.That(result, Is.False);

            // Проверяваме дали списъкът
            // продължава да е празен.

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Отрицателен бюджет
        // ====================================

        [Test]
        public void AddProject_NegativeBudget_ShouldNotAddProject()
        {
            // Създаваме проект с бюджет -5000.
            //
            // Това е невалидно, защото
            // бюджетът не може да е отрицателен.
            //
            // Очакваме методът да върне false.

            Project project = new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = -5000,
                TeamSize = 4,
                Status = "Planned"
            };

            bool result = manager.AddProject(project);

            // Проверяваме дали проектът
            // е бил отхвърлен.

            Assert.That(result, Is.False);

            // Проверяваме дали списъкът
            // все още съдържа 0 проекта.

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 4: Невалиден статус
        // ====================================

        [Test]
        public void AddProject_InvalidStatus_ShouldNotAddProject()
        {
            // Създаваме проект със статус "Paused".
            //
            // Нашата система разрешава само:
            //
            // Planned
            // Active
            // Completed
            //
            // Следователно "Paused" е невалиден.
            //
            // Очакваме методът да върне false.

            Project project = new Project
            {
                Id = 3,
                Name = "Online Store",
                Budget = 20000,
                TeamSize = 6,
                Status = "Paused"
            };

            bool result = manager.AddProject(project);

            Assert.That(result, Is.False);

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 5: Отрицателен брой хора
        // ====================================

        [Test]
        public void AddProject_NegativeTeamSize_ShouldNotAddProject()
        {
            // Създаваме проект с -3 души.
            //
            // Това е невъзможно.
            //
            // Очакваме проектът да не бъде добавен.

            Project project = new Project
            {
                Id = 4,
                Name = "Game",
                Budget = 10000,
                TeamSize = -3,
                Status = "Active"
            };

            bool result = manager.AddProject(project);

            Assert.That(result, Is.False);

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 6: Активен проект с най-голям бюджет
        // ====================================

        [Test]
        public void GetHighestBudgetActiveProject_ShouldReturnCorrectProject()
        {
            // Добавяме четири проекта.
            //
            // Website      -> Active, 15000 лв.
            // Mobile App   -> Active, 30000 лв.
            // Online Store -> Completed, 50000 лв.
            // Game         -> Active, 20000 лв.
            //
            // Очакваме да намерим Mobile App.
            //
            // Защо?
            //
            // Online Store има най-голям бюджет,
            // но НЕ е активен проект.
            //
            // От активните проекти Mobile App
            // има най-голям бюджет.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 15000,
                TeamSize = 5,
                Status = "Active"
            });

            manager.AddProject(new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = 30000,
                TeamSize = 8,
                Status = "Active"
            });

            manager.AddProject(new Project
            {
                Id = 3,
                Name = "Online Store",
                Budget = 50000,
                TeamSize = 12,
                Status = "Completed"
            });

            manager.AddProject(new Project
            {
                Id = 4,
                Name = "Game",
                Budget = 20000,
                TeamSize = 6,
                Status = "Active"
            });

            // Извикваме метода за търсене.

            Project? result =
                manager.GetHighestBudgetActiveProject();

            // Is.Not.Null означава:
            // "Очаквам да е намерен обект."

            Assert.That(result, Is.Not.Null);

            // Проверяваме бюджета.
            //
            // Очакваме 30000.
            //
            // ! означава, че тук очакваме
            // result да съдържа обект.

            Assert.That(result!.Budget, Is.EqualTo(30000m));

            // Проверяваме името.

            Assert.That(result.Name, Is.EqualTo("Mobile App"));

            // Проверяваме дали проектът е активен.

            Assert.That(result.Status, Is.EqualTo("Active"));
        }

        // ====================================
        // ТЕСТ 7: Празен списък с проекти
        // ====================================

        [Test]
        public void GetHighestBudgetActiveProject_EmptyList_ShouldReturnNull()
        {
            // Не добавяме никакви проекти.
            //
            // Очакваме методът да върне null,
            // защото няма проект за намиране.

            Project? result =
                manager.GetHighestBudgetActiveProject();

            // Is.Null означава:
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 8: Няма активни проекти
        // ====================================

        [Test]
        public void GetHighestBudgetActiveProject_NoActiveProjects_ShouldReturnNull()
        {
            // Добавяме два проекта.
            //
            // Първият е Planned.
            // Вторият е Completed.
            //
            // Нито един не е Active.
            //
            // Следователно очакваме null.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 10000,
                TeamSize = 3,
                Status = "Planned"
            });

            manager.AddProject(new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = 20000,
                TeamSize = 5,
                Status = "Completed"
            });

            Project? result =
                manager.GetHighestBudgetActiveProject();

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 9: Среден брой хора в активни проекти
        // ====================================

        [Test]
        public void GetAverageTeamSizeByStatus_Active_ShouldReturnCorrectAverage()
        {
            // Добавяме четири проекта.
            //
            // Website      -> Active, 5 души
            // Mobile App   -> Active, 8 души
            // Online Store -> Completed, 12 души
            // Game         -> Active, 2 души
            //
            // Търсим статус Active.
            //
            // Събираме:
            //
            // 5 + 8 + 2 = 15
            //
            // Делим на броя активни проекти:
            //
            // 15 / 3 = 5
            //
            // Очакван резултат: 5
            //
            // Не включваме Online Store,
            // защото неговият статус е Completed.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 15000,
                TeamSize = 5,
                Status = "Active"
            });

            manager.AddProject(new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = 30000,
                TeamSize = 8,
                Status = "Active"
            });

            manager.AddProject(new Project
            {
                Id = 3,
                Name = "Online Store",
                Budget = 50000,
                TeamSize = 12,
                Status = "Completed"
            });

            manager.AddProject(new Project
            {
                Id = 4,
                Name = "Game",
                Budget = 20000,
                TeamSize = 2,
                Status = "Active"
            });

            // Извикваме метода, който тестваме.

            double result =
                manager.GetAverageTeamSizeByStatus("Active");

            // Проверяваме дали резултатът е 5.
            //
            // Is.EqualTo(5.0) означава:
            // "Очаквам стойността да е 5."

            Assert.That(result, Is.EqualTo(5.0));
        }

        // ====================================
        // ТЕСТ 10: Дробна средна стойност
        // ====================================

        [Test]
        public void GetAverageTeamSizeByStatus_FractionalAverage_ShouldReturnDecimalResult()
        {
            // Добавяме два активни проекта.
            //
            // Website    -> 2 души
            // Mobile App -> 3 души
            //
            // Сбор:
            // 2 + 3 = 5
            //
            // Брой проекти: 2
            //
            // Средно:
            // 5 / 2 = 2.5
            //
            // Този тест е много важен!
            //
            // Ако използвахме целочислено деление,
            // резултатът щеше да бъде 2.
            //
            // Но правилният резултат е 2.5.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 10000,
                TeamSize = 2,
                Status = "Active"
            });

            manager.AddProject(new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = 20000,
                TeamSize = 3,
                Status = "Active"
            });

            double result =
                manager.GetAverageTeamSizeByStatus("Active");

            // Очакваме точно 2.5.

            Assert.That(result, Is.EqualTo(2.5));
        }

        // ====================================
        // ТЕСТ 11: Статус без намерени проекти
        // ====================================

        [Test]
        public void GetAverageTeamSizeByStatus_NoMatches_ShouldReturnZero()
        {
            // Добавяме един активен проект.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 10000,
                TeamSize = 5,
                Status = "Active"
            });

            // Търсим средния брой хора
            // за завършени проекти.
            //
            // Но нямаме такива.
            //
            // Очакваме 0.

            double result =
                manager.GetAverageTeamSizeByStatus("Completed");

            Assert.That(result, Is.EqualTo(0.0));
        }

        // ====================================
        // ТЕСТ 12: Само един активен проект
        // ====================================

        [Test]
        public void GetHighestBudgetActiveProject_OneProject_ShouldReturnProject()
        {
            // Добавяме само един активен проект.
            //
            // Когато имаме един активен проект,
            // той автоматично е този
            // с най-голям бюджет.

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 15000,
                TeamSize = 5,
                Status = "Active"
            });

            Project? result =
                manager.GetHighestBudgetActiveProject();

            // Проверяваме дали има намерен проект.

            Assert.That(result, Is.Not.Null);

            // Проверяваме името.

            Assert.That(result!.Name, Is.EqualTo("Website"));

            // Проверяваме бюджета.

            Assert.That(result.Budget, Is.EqualTo(15000m));
        }

        // ====================================
        // ТЕСТ 13: Проект с нулев бюджет
        // ====================================

        [Test]
        public void AddProject_ZeroBudget_ShouldAddProject()
        {
            // Създаваме проект с бюджет 0.
            //
            // Това може да означава, че
            // проектът все още е в процес
            // на планиране.
            //
            // Следователно 0 е допустима стойност.

            Project project = new Project
            {
                Id = 1,
                Name = "Future Project",
                Budget = 0,
                TeamSize = 0,
                Status = "Planned"
            };

            bool result = manager.AddProject(project);

            // Очакваме успешно добавяне.

            Assert.That(result, Is.True);

            // Очакваме един записан проект.

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 14: Празно име на проект
        // ====================================

        [Test]
        public void AddProject_EmptyName_ShouldNotAddProject()
        {
            // Създаваме проект с празно име.
            //
            // Нашата система изисква
            // всеки проект да има име.
            //
            // Очакваме методът да върне false.

            Project project = new Project
            {
                Id = 1,
                Name = "",
                Budget = 10000,
                TeamSize = 5,
                Status = "Active"
            };

            bool result = manager.AddProject(project);

            Assert.That(result, Is.False);

            Assert.That(ProjectData.Projects.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 15: Среден екип на завършени проекти
        // ====================================

        [Test]
        public void GetAverageTeamSizeByStatus_Completed_ShouldReturnCorrectAverage()
        {
            // Добавяме три проекта.
            //
            // Website      -> Completed, 4 души
            // Mobile App   -> Completed, 6 души
            // Online Store -> Active, 10 души
            //
            // Търсим статус Completed.
            //
            // Събираме:
            // 4 + 6 = 10
            //
            // Делим на броя завършени проекти:
            // 10 / 2 = 5
            //
            // Очакван резултат: 5

            manager.AddProject(new Project
            {
                Id = 1,
                Name = "Website",
                Budget = 10000,
                TeamSize = 4,
                Status = "Completed"
            });

            manager.AddProject(new Project
            {
                Id = 2,
                Name = "Mobile App",
                Budget = 20000,
                TeamSize = 6,
                Status = "Completed"
            });

            manager.AddProject(new Project
            {
                Id = 3,
                Name = "Online Store",
                Budget = 30000,
                TeamSize = 10,
                Status = "Active"
            });

            double result =
                manager.GetAverageTeamSizeByStatus("Completed");

            // Очакваме среден брой 5.

            Assert.That(result, Is.EqualTo(5.0));
        }
    }
}
