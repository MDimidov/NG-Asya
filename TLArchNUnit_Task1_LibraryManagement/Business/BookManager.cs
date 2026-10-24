using System;
using System.Collections.Generic;
using System.Text;
using TLArchNUnit_Task1_LibraryManagement.Data;

namespace TLArchNUnit_Task1_LibraryManagement.Business
{
    // BUSINESS LAYER (Слой за логика)
    //
    // Тук пишем правилата на нашата библиотека.
    //
    // Този клас отговаря за:
    // 1. Добавяне на книги.
    // 2. Намиране на книгата с най-много страници.
    // 3. Намиране на книги от определен автор.

    public class BookManager
    {
        // МЕТОД 1: AddBook()
        //
        // Получава книга и проверява дали
        // броят на страниците е положителен.
        //
        // bool означава, че методът връща:
        // true  -> успешно добавяне
        // false -> неуспешно добавяне

        public bool AddBook(Book book)
        {
            // Ако книгата не съществува
            // или страниците са 0 или отрицателни,
            // не я добавяме.

            if (book == null || book.Pages <= 0)
            {
                return false;
            }

            // Add() добавя книгата в списъка.

            BookData.Books.Add(book);

            return true;
        }

        // МЕТОД 2: GetThickestBook()
        //
        // Търсим книгата с най-много страници.
        //
        // Например:
        // Книга A -> 100 страници
        // Книга B -> 500 страници
        // Книга C -> 250 страници
        //
        // Резултат: Книга B

        public Book GetThickestBook()
        {
            // Ако няма книги, връщаме null.
            // null означава, че няма обект.

            if (BookData.Books.Count == 0)
            {
                return null;
            }

            // Приемаме първата книга за най-дебела.

            Book thickestBook = BookData.Books[0];

            // Обхождаме всички книги една по една.

            foreach (Book book in BookData.Books)
            {
                // Ако намерим книга с повече страници,
                // запомняме нея.

                if (book.Pages > thickestBook.Pages)
                {
                    thickestBook = book;
                }
            }

            return thickestBook;
        }

        // МЕТОД 3: GetBooksByAuthor()
        //
        // Получава име на автор.
        //
        // Например: "Иван Вазов"
        //
        // Връща всички книги от този автор.

        public List<Book> GetBooksByAuthor(string author)
        {
            // Създаваме празен списък за резултатите.

            List<Book> result = new List<Book>();

            // Проверяваме всяка книга.

            foreach (Book book in BookData.Books)
            {
                // == сравнява две стойности.
                //
                // Ако авторът съвпада,
                // добавяме книгата в резултата.

                if (book.Author == author)
                {
                    result.Add(book);
                }
            }

            return result;
        }
    }
}
