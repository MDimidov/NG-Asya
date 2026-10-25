
using System;
using NUnit.Framework;
using TLArchNUnit_Task5_MovieTheater.Business;
using TLArchNUnit_Task5_MovieTheater.Data;

namespace TLArchNUnit_Task5_MovieTheater.Tests
{
    // NUNIT - АВТОМАТИЧНО ТЕСТВАНЕ
    //
    // Представи си, че сме създали програма
    // за управление на киносалон.
    //
    // Искаме да проверим дали:
    //
    // 1. Добавяме филмите правилно.
    // 2. Не добавяме невалидни филми.
    // 3. Намираме филма с най-висок рейтинг.
    // 4. Търсим правилно филми по жанр
    //    и продължителност.
    //
    // Вместо всеки път ръчно да стартираме
    // програмата, използваме NUnit.
    //
    // NUnit изпълнява тестове автоматично
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
    public class MovieManagerTests
    {
        // Създаваме променлива за MovieManager.
        //
        // Ще я използваме във всички тестове.
        //
        // null! означава, че ще зададем
        // стойност малко по-късно.
        //
        // Това се случва в Setup().

        private MovieManager manager = null!;

        // [SetUp] означава:
        //
        // "Изпълни този метод ПРЕДИ всеки тест."
        //
        // Ако първият тест добави 3 филма,
        // вторият трябва да започне
        // с празен списък.
        //
        // Затова преди всеки тест
        // изчистваме списъка с филми.

        [SetUp]
        public void Setup()
        {
            // Clear() премахва всички филми
            // от общия списък.

            MovieData.Movies.Clear();

            // Създаваме нов MovieManager.

            manager = new MovieManager();
        }

        // ====================================
        // ТЕСТ 1: Добавяне на валиден филм
        // ====================================

        [Test]
        public void AddMovie_ValidMovie_ShouldAddMovie()
        {
            // СТЪПКА 1: Подготвяме филм.
            //
            // Той има заглавие, жанр,
            // положителна продължителност
            // и рейтинг между 1 и 10.

            Movie movie = new Movie
            {
                Id = 1,
                Title = "Avatar",
                Genre = "Sci-Fi",
                DurationMinutes = 162,
                Rating = 8.5
            };

            // СТЪПКА 2: Добавяме филма.
            //
            // Очакваме методът да върне true.

            bool result = manager.AddMovie(movie);

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
            // съдържа точно един филм.
            //
            // Is.EqualTo(1) означава:
            // "Очаквам стойността да е равна на 1."

            Assert.That(MovieData.Movies.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 2: Добавяне на null
        // ====================================

        [Test]
        public void AddMovie_NullMovie_ShouldNotAddMovie()
        {
            // Опитваме се да добавим null.
            //
            // null означава, че няма
            // създаден обект Movie.
            //
            // Очакваме методът да върне false.
            //
            // ! тук потиска предупреждението
            // на компилатора за nullable стойност.
            // Не създава истински обект.

            bool result = manager.AddMovie(null!);

            // Is.False означава:
            // "Очаквам резултатът да е false."

            Assert.That(result, Is.False);

            // Проверяваме дали списъкът
            // все още е празен.

            Assert.That(MovieData.Movies.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 3: Невалиден рейтинг
        // ====================================

        [Test]
        public void AddMovie_InvalidRating_ShouldNotAddMovie()
        {
            // Създаваме филм с рейтинг 11.
            //
            // Максималният допустим рейтинг е 10.
            //
            // Следователно 11 е невалиден.
            //
            // Очакваме филмът да не бъде добавен.

            Movie movie = new Movie
            {
                Id = 2,
                Title = "Test Movie",
                Genre = "Action",
                DurationMinutes = 100,
                Rating = 11
            };

            bool result = manager.AddMovie(movie);

            // Проверяваме дали добавянето
            // е било неуспешно.

            Assert.That(result, Is.False);

            // Проверяваме дали нямаме
            // добавени филми.

            Assert.That(MovieData.Movies.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 4: Невалидна продължителност
        // ====================================

        [Test]
        public void AddMovie_InvalidDuration_ShouldNotAddMovie()
        {
            // Създаваме филм с 0 минути.
            //
            // Това е невалидно, защото
            // продължителността трябва
            // да бъде положително число.

            Movie movie = new Movie
            {
                Id = 3,
                Title = "Test Movie",
                Genre = "Comedy",
                DurationMinutes = 0,
                Rating = 7.5
            };

            bool result = manager.AddMovie(movie);

            Assert.That(result, Is.False);

            Assert.That(MovieData.Movies.Count, Is.EqualTo(0));
        }

        // ====================================
        // ТЕСТ 5: Филм с най-висок рейтинг
        // ====================================

        [Test]
        public void GetTopRatedMovie_ShouldReturnHighestRatedMovie()
        {
            // Добавяме три филма.
            //
            // Avatar    -> 8.5
            // Titanic   -> 7.9
            // Inception -> 9.2
            //
            // Очакваме да намерим Inception,
            // защото има най-висок рейтинг.

            manager.AddMovie(new Movie
            {
                Id = 1,
                Title = "Avatar",
                Genre = "Sci-Fi",
                DurationMinutes = 162,
                Rating = 8.5
            });

            manager.AddMovie(new Movie
            {
                Id = 2,
                Title = "Titanic",
                Genre = "Drama",
                DurationMinutes = 195,
                Rating = 7.9
            });

            manager.AddMovie(new Movie
            {
                Id = 3,
                Title = "Inception",
                Genre = "Sci-Fi",
                DurationMinutes = 148,
                Rating = 9.2
            });

            // Извикваме метода, който тестваме.

            Movie? result = manager.GetTopRatedMovie();

            // Is.Not.Null означава:
            // "Очаквам да е намерен обект."

            Assert.That(result, Is.Not.Null);

            // ! означава, че тук очакваме
            // резултатът да не е null.
            //
            // Проверяваме рейтинга.

            Assert.That(result!.Rating, Is.EqualTo(9.2));

            // Проверяваме и заглавието.

            Assert.That(result.Title, Is.EqualTo("Inception"));
        }

        // ====================================
        // ТЕСТ 6: Празен списък с филми
        // ====================================

        [Test]
        public void GetTopRatedMovie_EmptyList_ShouldReturnNull()
        {
            // Не добавяме никакви филми.
            //
            // Очакваме методът да върне null,
            // защото няма филм за намиране.

            Movie? result = manager.GetTopRatedMovie();

            // Is.Null означава:
            // "Очаквам да няма намерен обект."

            Assert.That(result, Is.Null);
        }

        // ====================================
        // ТЕСТ 7: Търсене по жанр и минути
        // ====================================

        [Test]
        public void GetShortMoviesByGenre_ShouldReturnMatchingMovies()
        {
            // Добавяме четири филма.
            //
            // Филм A -> Comedy, 90 минути
            // Филм B -> Comedy, 120 минути
            // Филм C -> Action, 80 минути
            // Филм D -> Comedy, 75 минути
            //
            // Търсим Comedy под 100 минути.
            //
            // Очакваме да намерим:
            // Филм A и Филм D.

            manager.AddMovie(new Movie
            {
                Id = 1,
                Title = "Филм A",
                Genre = "Comedy",
                DurationMinutes = 90,
                Rating = 7.5
            });

            manager.AddMovie(new Movie
            {
                Id = 2,
                Title = "Филм B",
                Genre = "Comedy",
                DurationMinutes = 120,
                Rating = 8.0
            });

            manager.AddMovie(new Movie
            {
                Id = 3,
                Title = "Филм C",
                Genre = "Action",
                DurationMinutes = 80,
                Rating = 7.0
            });

            manager.AddMovie(new Movie
            {
                Id = 4,
                Title = "Филм D",
                Genre = "Comedy",
                DurationMinutes = 75,
                Rating = 8.5
            });

            // Търсим комедии под 100 минути.
            //
            // var означава, че C# сам определя
            // типа на променливата.
            //
            // Тук result е List<Movie>,
            // защото методът връща списък.

            var result =
                manager.GetShortMoviesByGenre("Comedy", 100);

            // Очакваме да намерим точно 2 филма.

            Assert.That(result.Count, Is.EqualTo(2));

            // Проверяваме всеки намерен филм.
            //
            // foreach обхожда филмите един по един.

            foreach (Movie movie in result)
            {
                // Жанрът трябва да е Comedy.

                Assert.That(movie.Genre, Is.EqualTo("Comedy"));

                // Продължителността трябва
                // да е по-малка от 100 минути.
                //
                // Is.LessThan(100) означава:
                // "Очаквам число по-малко от 100."

                Assert.That(
                    movie.DurationMinutes,
                    Is.LessThan(100));
            }
        }

        // ====================================
        // ТЕСТ 8: Няма намерени филми
        // ====================================

        [Test]
        public void GetShortMoviesByGenre_NoMatches_ShouldReturnEmptyList()
        {
            // Добавяме един филм от жанр Action.

            manager.AddMovie(new Movie
            {
                Id = 1,
                Title = "Action Movie",
                Genre = "Action",
                DurationMinutes = 120,
                Rating = 8.0
            });

            // Търсим Comedy под 100 минути.
            //
            // Но нямаме такива филми.
            //
            // Очакваме празен списък.

            var result =
                manager.GetShortMoviesByGenre("Comedy", 100);

            // Is.Empty означава:
            // "Очаквам списъкът да е празен."

            Assert.That(result, Is.Empty);
        }

        // ====================================
        // ТЕСТ 9: Продължителност точно 100
        // ====================================

        [Test]
        public void GetShortMoviesByGenre_ExactlyMaxMinutes_ShouldNotIncludeMovie()
        {
            // Условието на задачата казва:
            // "Под определени минути".
            //
            // Това означава:
            //
            // 99 минути  -> включва се
            // 100 минути -> НЕ се включва
            // 101 минути -> НЕ се включва
            //
            // Добавяме филм с продължителност
            // точно 100 минути.
            //
            // Очакваме да не бъде намерен.

            manager.AddMovie(new Movie
            {
                Id = 1,
                Title = "Comedy Movie",
                Genre = "Comedy",
                DurationMinutes = 100,
                Rating = 8.0
            });

            var result =
                manager.GetShortMoviesByGenre("Comedy", 100);

            // Очакваме празен списък,
            // защото 100 не е по-малко от 100.

            Assert.That(result, Is.Empty);
        }

        // ====================================
        // ТЕСТ 10: Минимален валиден рейтинг
        // ====================================

        [Test]
        public void AddMovie_RatingExactlyOne_ShouldAddMovie()
        {
            // Минималният рейтинг е 1.
            //
            // Следователно филм с рейтинг 1
            // трябва да бъде добавен.

            Movie movie = new Movie
            {
                Id = 1,
                Title = "Low Rated Movie",
                Genre = "Drama",
                DurationMinutes = 90,
                Rating = 1
            };

            bool result = manager.AddMovie(movie);

            // Очакваме успешно добавяне.

            Assert.That(result, Is.True);

            Assert.That(MovieData.Movies.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 11: Максимален валиден рейтинг
        // ====================================

        [Test]
        public void AddMovie_RatingExactlyTen_ShouldAddMovie()
        {
            // Максималният рейтинг е 10.
            //
            // Следователно филм с рейтинг 10
            // също трябва да бъде добавен.

            Movie movie = new Movie
            {
                Id = 1,
                Title = "Perfect Movie",
                Genre = "Drama",
                DurationMinutes = 120,
                Rating = 10
            };

            bool result = manager.AddMovie(movie);

            // Очакваме успешно добавяне.

            Assert.That(result, Is.True);

            Assert.That(MovieData.Movies.Count, Is.EqualTo(1));
        }

        // ====================================
        // ТЕСТ 12: Един филм в киносалона
        // ====================================

        [Test]
        public void GetTopRatedMovie_OneMovie_ShouldReturnMovie()
        {
            // Добавяме само един филм.
            //
            // Когато имаме един филм,
            // той автоматично е този
            // с най-висок рейтинг.

            manager.AddMovie(new Movie
            {
                Id = 1,
                Title = "Avatar",
                Genre = "Sci-Fi",
                DurationMinutes = 162,
                Rating = 8.5
            });

            Movie? result = manager.GetTopRatedMovie();

            // Проверяваме дали е намерен обект.

            Assert.That(result, Is.Not.Null);

            // Проверяваме заглавието.

            Assert.That(result!.Title, Is.EqualTo("Avatar"));

            // Проверяваме рейтинга.

            Assert.That(result.Rating, Is.EqualTo(8.5));
        }

        // ====================================
        // ТЕСТ 13: Рейтинг под минималния
        // ====================================

        [Test]
        public void AddMovie_RatingBelowOne_ShouldNotAddMovie()
        {
            // Създаваме филм с рейтинг 0.5.
            //
            // Това е невалидно, защото
            // минималният рейтинг е 1.
            //
            // Очакваме методът да върне false.

            Movie movie = new Movie
            {
                Id = 1,
                Title = "Test Movie",
                Genre = "Drama",
                DurationMinutes = 90,
                Rating = 0.5
            };

            bool result = manager.AddMovie(movie);

            Assert.That(result, Is.False);

            Assert.That(MovieData.Movies.Count, Is.EqualTo(0));
        }
    }
}
