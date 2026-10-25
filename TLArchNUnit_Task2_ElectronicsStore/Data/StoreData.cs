
using System.Collections.Generic;

namespace TLArchNUnit_Task2_ElectronicsStore.Data
{
    // Този клас съхранява всички устройства.
    //
    // List<Device> означава списък от устройства.
    //
    // Представи си магазин с празни рафтове.
    //
    // Когато добавяме ново устройство,
    // го поставяме в нашия списък.
    //
    // Например:
    // Devices:
    // 1. Телевизор
    // 2. Лаптоп
    // 3. Сешоар
    //
    // static означава, че списъкът е общ.
    //
    // Можем да го използваме директно чрез:
    //
    // StoreData.Devices
    //
    // без да създаваме обект от StoreData.

    public class StoreData
    {
        public static List<Device> Devices = new List<Device>();
    }
}
