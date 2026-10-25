
using System;

namespace TLArchNUnit_Task5_MovieTheater.Data
{
    // DATA LAYER (Слой за данни)
    //
    // Задача 5: Киносалон (Movie Theater)
    //
    // Създаваме клас Movie, който описва
    // един филм в нашия киносалон.
    //
    // Всеки филм има:
    //
    // - Id              -> уникален номер
    // - Title           -> заглавие
    // - Genre           -> жанр
    // - DurationMinutes -> продължителност в минути
    // - Rating          -> рейтинг от 1 до 10
    //
    // Например:
    //
    // Id: 1
    // Title: Avatar
    // Genre: Sci-Fi
    // DurationMinutes: 162
    // Rating: 8.5
    //
    // Тези характеристики се наричат
    // свойства (Properties).
    //
    // get -> позволява да прочетем стойността.
    // set -> позволява да променим стойността.

    public class Movie
    {
        // int означава цяло число.
        //
        // Например: 1, 2, 100.

        public int Id { get; set; }

        // string означава текст.
        //
        // Например: "Avatar".
        //
        // = "" задава празен текст
        // като начална стойност.

        public string Title { get; set; } = "";

        // Жанр на филма.
        //
        // Например:
        // "Action"
        // "Comedy"
        // "Drama"
        // "Sci-Fi"

        public string Genre { get; set; } = "";

        // Продължителност на филма в минути.
        //
        // Например:
        // 90  -> 1 час и 30 минути
        // 120 -> 2 часа
        // 180 -> 3 часа

        public int DurationMinutes { get; set; }

        // double позволява да съхраняваме
        // числа с дробна част.
        //
        // Например:
        // 7.5
        // 8.8
        // 9.2
        //
        // Използваме го за рейтинг от 1 до 10.

        public double Rating { get; set; }
    }
}
