using System;
using System.Collections.Generic;
using System.Text;

namespace TLArchNUnit_Task1_LibraryManagement.Data
{
    // DATA LAYER (Слой за данни)
    //
    // Този клас описва как изглежда една книга.
    //
    // Представи си, че всяка книга има етикет,
    // върху който пише:
    // - Номер
    // - Заглавие
    // - Автор
    // - Брой страници
    // - Цена
    //
    // В програмирането тези характеристики
    // се наричат свойства (Properties).

    public class Book
    {
        // int означава цяло число.
        // Например: 1, 2, 100.

        public int Id { get; set; }

        // string означава текст.
        // Например: "Под игото".

        public string Title { get; set; }

        public string Author { get; set; }

        // Брой страници на книгата.

        public int Pages { get; set; }

        // decimal използваме за парични стойности.
        // Например: 15.50 лв.

        public decimal Price { get; set; }
    }

}
