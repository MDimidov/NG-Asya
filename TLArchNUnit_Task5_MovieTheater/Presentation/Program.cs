
using System;
using System.Collections.Generic;
using TLArchNUnit_Task5_MovieTheater.Business;
using TLArchNUnit_Task5_MovieTheater.Data;

namespace TLArchNUnit_Task5_MovieTheater.Presentation
{
    internal class Program
    {
        // PRESENTATION LAYER
        //
        // Това е частта, която потребителят вижда.
        //
        // Създаваме конзолно меню:
        //
        // 1. Добавяне на филм
        // 2. Филм с най-висок рейтинг
        // 3. Търсене на кратки филми по жанр
        // 0. Изход

        static void Main(string[] args)
        {
            // Създаваме обект от MovieManager.
            //
            // Чрез него ще използваме методите,
            // написани в Business Layer.

            MovieManager manager = new MovieManager();

            // while (true) повтаря менюто,
            // докато потребителят не избере 0.

            while (true)
            {
                Console.WriteLine("\n=== КИНОСАЛОН ===");
                Console.WriteLine("1. Добави филм");
                Console.WriteLine("2. Филм с най-висок рейтинг");
                Console.WriteLine("3. Търси кратки филми по жанр");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");

                // Console.ReadLine() прочита
                // въведеното от потребителя.
                //
                // ?? "" означава:
                // Ако получим null,
                // използвай празен текст.

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    // Създаваме нов филм.
                    //
                    // След това попълваме
                    // неговите свойства.

                    Movie movie = new Movie();

                    Console.Write("ID: ");
                    movie.Id = int.Parse(Console.ReadLine()!);

                    Console.Write("Заглавие: ");
                    movie.Title = Console.ReadLine() ?? "";

                    Console.Write("Жанр: ");
                    movie.Genre = Console.ReadLine() ?? "";

                    Console.Write("Продължителност (минути): ");
                    movie.DurationMinutes =
                        int.Parse(Console.ReadLine()!);

                    Console.Write("Рейтинг (1-10): ");
                    movie.Rating =
                        double.Parse(Console.ReadLine()!);

                    // Извикваме метода AddMovie().
                    //
                    // Той проверява дали данните
                    // са валидни и добавя филма.

                    bool added = manager.AddMovie(movie);

                    if (added)
                    {
                        Console.WriteLine("Филмът е добавен успешно!");
                    }
                    else
                    {
                        Console.WriteLine("Невалидни данни за филма!");
                    }
                }
                else if (choice == "2")
                {
                    // Търсим филма с най-висок рейтинг.
                    //
                    // Movie? означава, че резултатът
                    // може да бъде филм или null.
                    //
                    // null означава, че няма
                    // намерен филм.

                    Movie? movie = manager.GetTopRatedMovie();

                    if (movie == null)
                    {
                        Console.WriteLine("Няма добавени филми.");
                    }
                    else
                    {
                        Console.WriteLine($"Заглавие: {movie.Title}");
                        Console.WriteLine($"Жанр: {movie.Genre}");
                        Console.WriteLine($"Продължителност: {movie.DurationMinutes} мин.");
                        Console.WriteLine($"Рейтинг: {movie.Rating:F1}");
                    }
                }
                else if (choice == "3")
                {
                    // Потребителят въвежда жанр
                    // и максимална продължителност.
                    //
                    // Например:
                    //
                    // Жанр: Comedy
                    // Минути: 100
                    //
                    // Програмата ще намери
                    // комедии под 100 минути.

                    Console.Write("Въведи жанр: ");
                    string genre = Console.ReadLine() ?? "";

                    Console.Write("Продължителност под колко минути: ");
                    int maxMinutes =
                        int.Parse(Console.ReadLine()!);

                    // Извикваме метода за търсене.
                    //
                    // Той връща списък с филми,
                    // които отговарят на условията.

                    List<Movie> movies =
                        manager.GetShortMoviesByGenre(
                            genre, maxMinutes);

                    // Проверяваме дали има резултати.

                    if (movies.Count == 0)
                    {
                        Console.WriteLine("Няма намерени филми.");
                    }
                    else
                    {
                        Console.WriteLine("\nНамерени филми:");

                        // foreach обхожда всеки
                        // намерен филм един по един.
                        //
                        // Отпечатваме заглавието,
                        // времетраенето и рейтинга.

                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine(
                                $"{movie.Title} - " +
                                $"{movie.DurationMinutes} мин. - " +
                                $"Рейтинг: {movie.Rating:F1}");
                        }
                    }
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
