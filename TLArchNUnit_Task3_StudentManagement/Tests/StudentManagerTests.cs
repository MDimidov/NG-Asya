
using System;
using NUnit.Framework;
using TLArchNUnit_Task3_StudentManagement.Business;
using TLArchNUnit_Task3_StudentManagement.Data;

namespace TLArchNUnit_Task3_StudentManagement.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Представи си, че имаме система,
    // която записва оценките на студентите.
    //
    // Искаме да проверим дали:
    //
    // 1. Можем да добавим студент с валиден успех.
    // 2. Не можем да добавим студент с невалиден успех.
    // 3. Намираме студента с най-висок успех.
    // 4. Правилно филтрираме студентите по курс.
    //
    // Вместо всеки път ръчно да стартираме
    // програмата, NUnit проверява това вместо нас.
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
    public class StudentManagerTests
    {
        // Създаваме променлива за StudentManager.
        //
        // Ще я използваме във всички тестове.
        //
        // null! означава, че ще зададем стойност
        // на променливата малко по-късно.
        //
        // Това ще стане в метода Setup().

        private StudentManager manager = null!;

        // [SetUp] означава:
        //
        // "Изпълни този метод ПРЕДИ всеки тест."
        //
        // Защо?
        //
        // Ако първият тест добави 3 студенти,
        // вторият тест не трябва да започва
        // с тези 3 студенти.
        //
        // Затова изчистваме списъка преди
        // всеки тест.

        [SetUp]
        public void Setup()
        {
            // Clear() премахва всички студенти.

            StudentData.Students.Clear();

            // Създаваме нов StudentManager.

            manager = new StudentManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на валиден студент
        // ====================================

        // [Test] казва на NUnit:
        // "Това е тест, който трябва да изпълниш."

        [Test]
        public void AddStudent_ValidGrade_ShouldAddStudent()
        {
            // СТЪПКА 1: Подготвяме студент.
            //
            // Успехът му е 5.50.
            //
            // Това е валидна оценка,
            // защото е между 2.00 и 6.00.

            Student student = new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 5.50,
                Course = 2
            };

            // СТЪПКА 2: Добавяме студента.
            //
            // Очакваме методът да върне true.

            bool result = manager.AddStudent(student);

            // СТЪПКА 3: Проверяваме резултата.
            //
            // Assert.That() е команда на NUnit,
            // която проверява дали нещо е вярно.
            //
            // Is.True означава:
            // "Очаквам резултатът да бъде true."
            //
            // Ако е true -> тестът минава.
            // Ако е false -> тестът се проваля.

            Assert.That(result, Is.True);

            // Проверяваме дали списъкът
            // съдържа точно 1 студент.
            //
            // Is.EqualTo(1) означава:
            // "Очаквам резултатът да е равен на 1."

            Assert.That(StudentData.Students.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Успех под 2.00
        // ====================================

        [Test]
        public void AddStudent_GradeBelowTwo_ShouldNotAddStudent()
        {
            // Създаваме студент с успех 1.50.
            //
            // Това е невалидна оценка.
            //
            // Очакваме студентът да НЕ бъде добавен.

            Student student = new Student
            {
                FacultyNumber = 1002,
                FullName = "Мария Петрова",
                Grade = 1.50,
                Course = 1
            };

            bool result = manager.AddStudent(student);

            // Is.False означава:
            // "Очаквам резултатът да бъде false."

            Assert.That(result, Is.False);

            // Проверяваме дали списъкът
            // все още съдържа 0 студенти.

            Assert.That(StudentData.Students.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Успех над 6.00
        // ====================================

        [Test]
        public void AddStudent_GradeAboveSix_ShouldNotAddStudent()
        {
            // Създаваме студент с успех 6.50.
            //
            // Максималната оценка е 6.00.
            //
            // Следователно 6.50 е невалидна.
            //
            // Очакваме методът да върне false.

            Student student = new Student
            {
                FacultyNumber = 1003,
                FullName = "Георги Георгиев",
                Grade = 6.50,
                Course = 3
            };

            bool result = manager.AddStudent(student);

            // Проверяваме дали добавянето
            // е било неуспешно.

            Assert.That(result, Is.False);

            // Проверяваме дали няма
            // добавени студенти.

            Assert.That(StudentData.Students.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 4: Най-висок успех
        // ====================================

        [Test]
        public void GetTopStudent_ShouldReturnStudentWithHighestGrade()
        {
            // Добавяме три студенти.
            //
            // Иван   -> 4.50
            // Мария  -> 5.75
            // Георги -> 5.25
            //
            // Очакваме да намерим Мария,
            // защото има най-висок успех.

            manager.AddStudent(new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 4.50,
                Course = 2
            });

            manager.AddStudent(new Student
            {
                FacultyNumber = 1002,
                FullName = "Мария Петрова",
                Grade = 5.75,
                Course = 2
            });

            manager.AddStudent(new Student
            {
                FacultyNumber = 1003,
                FullName = "Георги Георгиев",
                Grade = 5.25,
                Course = 3
            });

            // Извикваме метода, който тестваме.

            Student? result = manager.GetTopStudent();

            // Проверяваме дали е намерен
            // студент, а не null.

            Assert.That(result, Is.Not.Null);

            // Проверяваме дали успехът е 5.75.
            //
            // ! след result казва на компилатора,
            // че тук очакваме да има обект.

            Assert.That(result!.Grade, Is.EqualTo(5.75));

            // Проверяваме и името.
            //
            // Очакваме Мария Петрова.

            Assert.That(result.FullName, Is.EqualTo("Мария Петрова"));
        }

        // ====================================
        // ТЕСТ 5: Празен списък със студенти
        // ====================================

        [Test]
        public void GetTopStudent_EmptyList_ShouldReturnNull()
        {
            // Не добавяме никакви студенти.
            //
            // Очакваме методът да върне null,
            // защото няма студент за намиране.

            Student? result = manager.GetTopStudent();

            // Is.Null означава:
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 6: Филтриране по курс и успех
        // ====================================

        [Test]
        public void GetExcellentStudentsByCourse_ShouldReturnMatchingStudents()
        {
            // Добавяме четири студенти.
            //
            // Иван   -> курс 2, успех 5.50
            // Мария  -> курс 2, успех 4.00
            // Георги -> курс 3, успех 6.00
            // Петър  -> курс 2, успех 5.00
            //
            // Търсим студенти от втори курс
            // с успех над 4.50.
            //
            // Очакваме да намерим:
            // Иван и Петър.
            //
            // Мария няма достатъчно висок успех.
            // Георги е в друг курс.

            manager.AddStudent(new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 5.50,
                Course = 2
            });

            manager.AddStudent(new Student
            {
                FacultyNumber = 1002,
                FullName = "Мария Петрова",
                Grade = 4.00,
                Course = 2
            });

            manager.AddStudent(new Student
            {
                FacultyNumber = 1003,
                FullName = "Георги Георгиев",
                Grade = 6.00,
                Course = 3
            });

            manager.AddStudent(new Student
            {
                FacultyNumber = 1004,
                FullName = "Петър Петров",
                Grade = 5.00,
                Course = 2
            });

            // Търсим студентите от втори курс.
            //
            // var означава, че C# сам определя
            // типа на променливата.
            //
            // Тук result е List<Student>,
            // защото методът връща списък.

            var result = manager.GetExcellentStudentsByCourse(2);

            // Очакваме да намерим 2 студенти.

            Assert.That(result.Count, Is.EqualTo(2));

            // Проверяваме дали всички
            // намерени студенти отговарят
            // на двете условия.

            foreach (Student student in result)
            {
                // Студентът трябва да е втори курс.

                Assert.That(student.Course, Is.EqualTo(2));

                // Успехът трябва да е над 4.50.
                //
                // Is.GreaterThan(4.50) означава:
                // "Очаквам число по-голямо от 4.50."

                Assert.That(student.Grade, Is.GreaterThan(4.50));
            }
        }

        // ====================================
        // ТЕСТ 7: Няма намерени студенти
        // ====================================

        [Test]
        public void GetExcellentStudentsByCourse_NoMatches_ShouldReturnEmptyList()
        {
            // Добавяме студент от първи курс.

            manager.AddStudent(new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 5.50,
                Course = 1
            });

            // Търсим студенти от четвърти курс.
            //
            // Но нямаме такива.
            //
            // Очакваме празен списък.

            var result = manager.GetExcellentStudentsByCourse(4);

            // Is.Empty означава:
            // "Очаквам списъкът да е празен."

            Assert.That(result, Is.Empty);
        }

        // ====================================
        // ТЕСТ 8: Успех точно 4.50
        // ====================================

        [Test]
        public void GetExcellentStudentsByCourse_GradeExactly450_ShouldNotIncludeStudent()
        {
            // Условието на задачата казва:
            // "Успех НАД 4.50".
            //
            // Това означава:
            //
            // 4.50 -> НЕ се включва
            // 4.51 -> включва се
            // 5.00 -> включва се
            //
            // Създаваме студент с успех 4.50.
            //
            // Очакваме да НЕ бъде намерен.

            manager.AddStudent(new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 4.50,
                Course = 2
            });

            var result = manager.GetExcellentStudentsByCourse(2);

            // Очакваме празен списък,
            // защото 4.50 не е над 4.50.

            Assert.That(result, Is.Empty);
        }

        // ====================================
        // ТЕСТ 9: Минимална валидна оценка
        // ====================================

        [Test]
        public void AddStudent_GradeExactlyTwo_ShouldAddStudent()
        {
            // Минималният допустим успех е 2.00.
            //
            // Следователно студент с успех 2.00
            // трябва да може да бъде добавен.

            Student student = new Student
            {
                FacultyNumber = 1001,
                FullName = "Иван Иванов",
                Grade = 2.00,
                Course = 1
            };

            bool result = manager.AddStudent(student);

            // Очакваме успешно добавяне.

            Assert.That(result, Is.True);

            // Проверяваме дали студентът
            // е записан в списъка.

            Assert.That(StudentData.Students.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 10: Максимална валидна оценка
        // ====================================

        [Test]
        public void AddStudent_GradeExactlySix_ShouldAddStudent()
        {
            // Максималният допустим успех е 6.00.
            //
            // Следователно студент с успех 6.00
            // също трябва да бъде добавен.

            Student student = new Student
            {
                FacultyNumber = 1001,
                FullName = "Мария Петрова",
                Grade = 6.00,
                Course = 3
            };

            bool result = manager.AddStudent(student);

            // Очакваме успешно добавяне.

            Assert.That(result, Is.True);

            // Очакваме един записан студент.

            Assert.That(StudentData.Students.Count, Is.EqualTo(1));
        }
    }
}
