using System;
using System.Collections.Generic;
using System.Text;

namespace TLArchNUnit_Task1_LibraryManagement.Data
{
    // Този клас съхранява всички книги.
    //
    // List<Book> означава списък от книги.
    //
    // Представи си празна библиотечна лавица.
    // Когато добавяме книги, ги поставяме
    // върху тази лавица.
    //
    // static означава, че списъкът е общ
    // и можем да го използваме без да
    // създаваме обект от класа BookData.

    public class BookData
    {
        public static List<Book> Books = new List<Book>();
    }
}
