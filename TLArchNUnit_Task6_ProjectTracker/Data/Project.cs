
using System;

namespace TLArchNUnit_Task6_ProjectTracker.Data
{
    // DATA LAYER (Слой за данни)
    //
    // Задача 6: Управление на проекти (Project Tracker)
    //
    // Създаваме клас Project, който описва
    // един проект в нашата система.
    //
    // Всеки проект има:
    //
    // - Id       -> уникален номер
    // - Name     -> име на проекта
    // - Budget   -> бюджет на проекта
    // - TeamSize -> брой хора в екипа
    // - Status   -> текущ статус
    //
    // Възможните статуси са:
    //
    // Planned   -> Планиран
    // Active    -> Активен
    // Completed -> Завършен
    //
    // Например:
    //
    // Id: 1
    // Name: Website
    // Budget: 15000
    // TeamSize: 5
    // Status: Active
    //
    // Тези характеристики се наричат
    // свойства (Properties).
    //
    // get -> позволява да прочетем стойността.
    // set -> позволява да променим стойността.

    public class Project
    {
        // int означава цяло число.
        //
        // Например: 1, 2, 100.

        public int Id { get; set; }

        // string означава текст.
        //
        // Например: "Website".
        //
        // = "" задава празен текст
        // като начална стойност.

        public string Name { get; set; } = "";

        // decimal използваме за парични стойности.
        //
        // Например:
        // 15000.00 лв.
        // 25000.50 лв.

        public decimal Budget { get; set; }

        // Брой хора, които работят
        // по проекта.
        //
        // Например:
        // 3 -> трима души
        // 8 -> осем души

        public int TeamSize { get; set; }

        // Статус на проекта.
        //
        // Използваме string, защото
        // статусът е текст.
        //
        // Например: "Active".

        public string Status { get; set; } = "";
    }
}
