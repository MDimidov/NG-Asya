using System;
using System.Collections.Generic;
using System.Text;
using TLArchNUnit_Task1_LibraryManagement.Business;
using TLArchNUnit_Task1_LibraryManagement.Data;
using NUnit.Framework;

namespace TLArchNUnit_Task1_LibraryManagement.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Представи си, че си написал калкулатор.
    //
    // Искаш да провериш дали:
    // 2 + 3 = 5
    //
    // Вместо всеки път да стартираш програмата
    // и сам да проверяваш резултата,
    // NUnit може да направи това вместо теб.
    //
    // NUnit е инструмент, който проверява
    // дали методите ни работят правилно.
    //
    // Всеки тест има три основни стъпки:
    //
    // 1. Подготвяме данните.
    // 2. Извикваме метода.
    // 3. Проверяваме резултата.

    // [TestFixture] казва на NUnit:
    // "Този клас съдържа тестове."

    [TestFixture]
    public class BookManagerTests
    {
        // Създаваме променлива за BookManager.
        // Ще я използваме във всички тестове.

        private BookManager manager;

        // [SetUp] означава:
        // "Изпълни този метод ПРЕДИ всеки тест."
        //
        // Защо?
        //
        // Ако първият тест добави 3 книги,
        // вторият тест не трябва да започва
        // с тези 3 книги.
        //
        // Затова изчистваме списъка преди
        // всеки тест.

        [SetUp]
        public void Setup()
        {
            BookData.Books.Clear();

            manager = new BookManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на валидна книга
        // ====================================

        // [Test] казва на NUnit:
        // "Това е тест, който трябва да изпълниш."

        [Test]
        public void AddBook_ValidBook_ShouldAddBook()
        {
            // СТЪПКА 1: Подготвяме книга.

            Book book = new Book
            {
                Id = 1,
                Title = "Под игото",
                Author = "Иван Вазов",
                Pages = 400,
                Price = 20
            };

            // СТЪПКА 2: Добавяме книгата.
            //
            // Очакваме методът да върне true.

            bool result = manager.AddBook(book);

            // СТЪПКА 3: Проверяваме резултата.
            //
            // Assert.That() е команда на NUnit,
            // с която проверяваме дали нещо е вярно.
            //
            // Is.True означава:
            // "Очаквам резултатът да бъде true."
            //
            // Ако е true -> тестът минава.
            // Ако е false -> тестът се проваля.

            Assert.That(result, Is.True);

            // Проверяваме дали списъкът
            // съдържа точно 1 книга.

            Assert.That(BookData.Books.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Невалиден брой страници
        // ====================================

        [Test]
        public void AddBook_InvalidPages_ShouldNotAddBook()
        {
            // Създаваме книга с 0 страници.
            //
            // Това е невалидно, защото
            // страниците трябва да са положителни.

            Book book = new Book
            {
                Id = 2,
                Title = "Тестова книга",
                Author = "Автор",
                Pages = 0,
                Price = 10
            };

            bool result = manager.AddBook(book);

            // Is.False означава:
            // "Очаквам резултатът да бъде false."

            Assert.That(result, Is.False);

            // Is.EqualTo(0) означава:
            // "Очаквам в списъка да има 0 книги."
            //
            // Ако книгата е добавена,
            // тестът ще се провали.

            Assert.That(BookData.Books.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Книга с най-много страници
        // ====================================

        [Test]
        public void GetThickestBook_ShouldReturnBookWithMostPages()
        {
            // Добавяме три книги.
            //
            // Първа  -> 100 страници
            // Втора  -> 500 страници
            // Трета  -> 250 страници
            //
            // Очакваме да намерим втората.

            manager.AddBook(new Book
            {
                Id = 1,
                Title = "Книга A",
                Pages = 100
            });

            manager.AddBook(new Book
            {
                Id = 2,
                Title = "Книга B",
                Pages = 500
            });

            manager.AddBook(new Book
            {
                Id = 3,
                Title = "Книга C",
                Pages = 250
            });

            // Извикваме метода, който тестваме.

            Book result = manager.GetThickestBook();

            // Проверяваме дали намерената книга
            // има точно 500 страници.

            Assert.That(result.Pages, Is.EqualTo(500));

            // Проверяваме и заглавието.

            Assert.That(result.Title, Is.EqualTo("Книга B"));
        }

        // ====================================
        // ТЕСТ 4: Празна библиотека
        // ====================================

        [Test]
        public void GetThickestBook_EmptyLibrary_ShouldReturnNull()
        {
            // Не добавяме никакви книги.
            //
            // Очакваме методът да върне null,
            // защото няма книга за намиране.

            Book result = manager.GetThickestBook();

            // Is.Null означава:
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 5: Търсене по автор
        // ====================================

        [Test]
        public void GetBooksByAuthor_ShouldReturnMatchingBooks()
        {
            // Добавяме три книги.
            //
            // Две са от Иван Вазов.
            // Една е от Елин Пелин.
            //
            // Очакваме да намерим точно 2 книги.

            manager.AddBook(new Book
            {
                Id = 1,
                Title = "Под игото",
                Author = "Иван Вазов",
                Pages = 400
            });

            manager.AddBook(new Book
            {
                Id = 2,
                Title = "Немили-недраги",
                Author = "Иван Вазов",
                Pages = 150
            });

            manager.AddBook(new Book
            {
                Id = 3,
                Title = "Гераците",
                Author = "Елин Пелин",
                Pages = 120
            });

            // Търсим книгите на Иван Вазов.
            //
            // var означава, че C# сам определя
            // типа на променливата.
            //
            // Тук result е List<Book>,
            // защото методът връща списък от книги.

            var result = manager.GetBooksByAuthor("Иван Вазов");

            // Очакваме да намерим 2 книги.

            Assert.That(result.Count, Is.EqualTo(2));

            // Проверяваме дали и двете намерени
            // книги са от Иван Вазов.
            //
            // foreach обхожда книгите една по една.

            foreach (Book book in result)
            {
                Assert.That(book.Author, Is.EqualTo("Иван Вазов"));
            }
        }

        // ====================================
        // ТЕСТ 6: Автор без намерени книги
        // ====================================

        [Test]
        public void GetBooksByAuthor_UnknownAuthor_ShouldReturnEmptyList()
        {
            // Добавяме една книга.

            manager.AddBook(new Book
            {
                Id = 1,
                Title = "Под игото",
                Author = "Иван Вазов",
                Pages = 400
            });

            // Търсим автор, който няма книги
            // в нашата библиотека.

            var result = manager.GetBooksByAuthor("Петър Петров");

            // Очакваме празен списък.
            //
            // Is.Empty означава:
            // "Очаквам колекцията да е празна."

            Assert.That(result, Is.Empty);
        }
    }
}
