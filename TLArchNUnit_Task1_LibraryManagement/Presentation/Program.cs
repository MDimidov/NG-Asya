using TLArchNUnit_Task1_LibraryManagement.Business;
using TLArchNUnit_Task1_LibraryManagement.Data;

namespace TLArchNUnit_Task1_LibraryManagement.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме меню с 4 възможности:
        // 1. Добавяне на книга
        // 2. Най-дебела книга
        // 3. Търсене по автор
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект, чрез който
            // ще използваме методите на BookManager.

            BookManager manager = new BookManager();

            // while (true) повтаря менюто,
            // докато не изберем изход.

            while (true)
            {
                Console.WriteLine("\n=== БИБЛИОТЕКА ===");
                Console.WriteLine("1. Добави книга");
                Console.WriteLine("2. Най-дебела книга");
                Console.WriteLine("3. Търсене по автор");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Създаваме нова книга.

                    Book book = new Book();

                    Console.Write("ID: ");
                    book.Id = int.Parse(Console.ReadLine());

                    Console.Write("Заглавие: ");
                    book.Title = Console.ReadLine();

                    Console.Write("Автор: ");
                    book.Author = Console.ReadLine();

                    Console.Write("Страници: ");
                    book.Pages = int.Parse(Console.ReadLine());

                    Console.Write("Цена: ");
                    book.Price = decimal.Parse(Console.ReadLine());

                    // Извикваме метода за добавяне.
                    // Той проверява дали страниците са валидни.

                    bool added = manager.AddBook(book);

                    if (added)
                    {
                        Console.WriteLine("Книгата е добавена!");
                    }
                    else
                    {
                        Console.WriteLine("Невалиден брой страници!");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим книгата с най-много страници.

                    Book book = manager.GetThickestBook();

                    if (book == null)
                    {
                        Console.WriteLine("Няма добавени книги.");
                    }
                    else
                    {
                        Console.WriteLine($"Заглавие: {book.Title}");
                        Console.WriteLine($"Автор: {book.Author}");
                        Console.WriteLine($"Страници: {book.Pages}");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Въведи автор: ");
                    string author = Console.ReadLine();

                    // Получаваме списък с намерените книги.

                    List<Book> books = manager.GetBooksByAuthor(author);

                    if (books.Count == 0)
                    {
                        Console.WriteLine("Няма намерени книги.");
                    }
                    else
                    {
                        // Отпечатваме всяка намерена книга.

                        foreach (Book book in books)
                        {
                            Console.WriteLine($"{book.Title} - {book.Pages} страници");
                        }
                    }
                }
                else if (choice == "0")
                {
                    // break прекратява цикъла.
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
