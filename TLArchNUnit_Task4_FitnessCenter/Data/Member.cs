
using System;

namespace TLArchNUnit_Task4_FitnessCenter.Data
{
    // DATA LAYER (Слой за данни)
    //
    // Задача 4: Фитнес зала - Абонаменти
    //
    // Създаваме клас Member, който описва
    // един клиент на фитнес залата.
    //
    // Всеки клиент има:
    //
    // - Id            -> уникален номер
    // - Name          -> име на клиента
    // - Type          -> вид абонамент
    // - DaysRemaining -> оставащи дни
    // - MonthlyFee    -> месечна такса
    //
    // Например:
    //
    // Id: 1
    // Name: Иван Иванов
    // Type: Месечен
    // DaysRemaining: 25
    // MonthlyFee: 60
    //
    // В програмирането тези характеристики
    // се наричат свойства (Properties).

    public class Member
    {
        // int означава цяло число.
        //
        // Например: 1, 2, 3.

        public int Id { get; set; }

        // string означава текст.
        //
        // Например: "Иван Иванов".
        //
        // = "" задава празен текст
        // като начална стойност.

        public string Name { get; set; } = "";

        // Вид на абонамента.
        //
        // Например:
        // "Месечен"
        // "Годишен"

        public string Type { get; set; } = "";

        // Колко дни остават до края
        // на абонамента.
        //
        // Например:
        // 10 -> остават 10 дни
        // 365 -> остават 365 дни

        public int DaysRemaining { get; set; }

        // decimal използваме за пари.
        //
        // Например:
        // 50.00 лв.
        // 79.99 лв.

        public decimal MonthlyFee { get; set; }
    }
}
