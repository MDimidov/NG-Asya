
using System;
using System.Collections.Generic;
using TLArchNUnit_Task2_ElectronicsStore.Data;

namespace TLArchNUnit_Task2_ElectronicsStore.Business
{
    // BUSINESS LAYER (Слой за логика)
    //
    // Тук пишем правилата на нашия магазин.
    //
    // Този клас отговаря за:
    //
    // 1. Добавяне на устройства.
    // 2. Намиране на най-мощното устройство.
    // 3. Изчисляване на средната цена
    //    на устройствата от определена марка.

    public class DeviceManager
    {
        // МЕТОД 1: AddDevice()
        //
        // Получава устройство и го добавя
        // към списъка на магазина.
        //
        // bool означава, че методът връща:
        //
        // true  -> устройството е добавено
        // false -> устройството не е добавено
        //
        // Ще проверяваме дали устройството
        // съществува, преди да го добавим.

        public bool AddDevice(Device device)
        {
            // null означава, че няма обект.
            //
            // Ако получим null,
            // няма какво да добавим.

            if (device == null)
            {
                return false;
            }

            // Add() добавя устройството
            // в списъка на магазина.

            StoreData.Devices.Add(device);

            return true;
        }

        // МЕТОД 2: GetMostPowerfulDevice()
        //
        // Търсим устройството с най-висока мощност.
        //
        // Например:
        //
        // Телевизор -> 150 W
        // Сешоар    -> 2000 W
        // Лаптоп    -> 90 W
        //
        // Резултат: Сешоар
        //
        // Защото 2000 е най-голямото число.

        public Device? GetMostPowerfulDevice()
        {
            // Ако списъкът е празен,
            // няма устройство за намиране.
            //
            // Count показва колко елемента
            // има в списъка.

            if (StoreData.Devices.Count <= 0)
            {
                return null;
            }

            // Приемаме първото устройство
            // за най-мощно.
            //
            // [0] означава първия елемент.

            Device mostPowerful = StoreData.Devices[0];

            // foreach преминава през всяко
            // устройство в списъка.

            foreach (Device device in StoreData.Devices)
            {
                // Сравняваме мощностите.
                //
                // Ако текущото устройство
                // има по-висока мощност,
                // го запомняме като най-мощно.

                if (device.PowerWatts > mostPowerful.PowerWatts)
                {
                    mostPowerful = device;
                }
            }

            // След като проверим всички,
            // връщаме най-мощното устройство.

            return mostPowerful;
        }

        // МЕТОД 3: GetAveragePriceByBrand()
        //
        // Изчисляваме средната цена
        // на устройствата от определена марка.
        //
        // Например:
        //
        // Samsung телевизор -> 1000 лв.
        // Samsung телефон   -> 500 лв.
        // Samsung таблет    -> 300 лв.
        //
        // Общо: 1800 лв.
        // Брой устройства: 3
        //
        // Средна цена = 1800 / 3 = 600 лв.
        //
        // Ако няма устройства от тази марка,
        // връщаме 0.

        public decimal GetAveragePriceByBrand(string brand)
        {
            // Променлива за общата цена.
            //
            // decimal използваме,
            // защото работим с пари.

            decimal totalPrice = 0;

            // Променлива за броя устройства
            // от търсената марка.

            int count = 0;

            // Проверяваме всяко устройство.

            foreach (Device device in StoreData.Devices)
            {
                // Проверяваме дали марката съвпада.
                //
                // == означава сравнение.
                //
                // Например:
                // "Samsung" == "Samsung" -> true

                if (device.Brand == brand)
                {
                    // Прибавяме цената на устройството.

                    totalPrice += device.Price;

                    // Увеличаваме броя с 1.
                    //
                    // count++ е същото като:
                    // count = count + 1;

                    count++;
                }
            }

            // Ако не сме намерили устройства,
            // връщаме 0.
            //
            // Така избягваме деление на нула.

            if (count == 0)
            {
                return 0;
            }

            // Изчисляваме средната цена.
            //
            // Средна цена = Сбор / Брой

            decimal averagePrice = totalPrice / count;

            return averagePrice;
        }
    }
}
