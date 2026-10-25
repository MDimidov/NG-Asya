
using System;

namespace TLArchNUnit_Task2_ElectronicsStore.Data
{
    // DATA LAYER (Слой за данни)
    //
    // Задача 2: Физически магазин за електроника
    //
    // Трябва да създадем клас Device,
    // който описва едно електронно устройство.
    //
    // Всяко устройство има:
    // - Id         -> уникален номер
    // - Name       -> име на устройството
    // - Brand      -> марка
    // - PowerWatts -> мощност във ватове
    // - Price      -> цена
    //
    // Например:
    // Id: 1
    // Name: Телевизор
    // Brand: Samsung
    // PowerWatts: 150
    // Price: 1200
    //
    // Свойствата (Properties) съхраняват
    // информацията за всяко устройство.

    public class Device
    {
        // int означава цяло число.
        // Например: 1, 2, 100.

        public int Id { get; set; }

        // string означава текст.
        // Например: "Телевизор".

        public string Name { get; set; } = "";

        // Марка на устройството.
        // Например: "Samsung".

        public string Brand { get; set; } = "";

        // Мощност на устройството във ватове.
        //
        // Например:
        // Телевизор -> 150 W
        // Сешоар    -> 2000 W

        public int PowerWatts { get; set; }

        // decimal използваме за парични стойности.
        // Може да ползваме и double за обучителни цели
        //
        // Например: 599.99 лв.

        public decimal Price { get; set; }
    }
}
