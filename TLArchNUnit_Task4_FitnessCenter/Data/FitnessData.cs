
using System.Collections.Generic;

namespace TLArchNUnit_Task4_FitnessCenter.Data
{
    // DATA LAYER - Съхранение на данни
    //
    // Този клас съхранява всички клиенти
    // на фитнес залата.
    //
    // List<Member> означава списък от клиенти.
    //
    // Представи си регистрационна тетрадка,
    // в която записваме всички клиенти.
    //
    // Например:
    //
    // 1. Иван Иванов
    // 2. Мария Петрова
    // 3. Георги Георгиев
    //
    // По същия начин List<Member>
    // съхранява нашите клиенти.
    //
    // static означава, че списъкът е общ
    // за цялата програма.
    //
    // Можем да го използваме чрез:
    //
    // FitnessData.Members

    public class FitnessData
    {
        public static List<Member> Members = new List<Member>();
    }
}
