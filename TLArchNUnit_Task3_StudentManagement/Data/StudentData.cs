
using System.Collections.Generic;

namespace TLArchNUnit_Task3_StudentManagement.Data
{
    // Този клас съхранява всички студенти.
    //
    // List<Student> означава списък,
    // който може да съдържа много студенти.
    //
    // Представи си училищен дневник.
    //
    // В него записваме:
    //
    // 1. Иван Иванов
    // 2. Мария Петрова
    // 3. Георги Георгиев
    //
    // По същия начин List<Student>
    // съхранява нашите студенти.
    //
    // static означава, че списъкът е общ
    // за цялата програма.
    //
    // Можем да го използваме чрез:
    //
    // StudentData.Students
    //
    // без да създаваме обект от StudentData.

    public class StudentData
    {
        public static List<Student> Students = new List<Student>();
    }
}
