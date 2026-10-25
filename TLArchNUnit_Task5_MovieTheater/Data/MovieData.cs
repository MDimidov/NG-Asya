
using System.Collections.Generic;

namespace TLArchNUnit_Task5_MovieTheater.Data
{
    // DATA LAYER - Съхранение на данни
    //
    // Този клас съхранява всички филми
    // в нашия киносалон.
    //
    // List<Movie> означава списък от филми.
    //
    // Представи си каталог с филми.
    //
    // Например:
    //
    // 1. Avatar
    // 2. Titanic
    // 3. Inception
    //
    // По същия начин List<Movie>
    // съхранява нашите филми.
    //
    // static означава, че списъкът е общ.
    //
    // Можем да го използваме директно:
    //
    // MovieData.Movies
    //
    // Не е необходимо да създаваме
    // обект от класа MovieData.

    public class MovieData
    {
        public static List<Movie> Movies = new List<Movie>();
    }
}
