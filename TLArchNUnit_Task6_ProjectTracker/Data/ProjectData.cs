
using System.Collections.Generic;

namespace TLArchNUnit_Task6_ProjectTracker.Data
{
    // DATA LAYER - Съхранение на данни
    //
    // Този клас съхранява всички проекти.
    //
    // List<Project> означава списък
    // от обекти от тип Project.
    //
    // Представи си тетрадка,
    // в която една фирма записва
    // всичките си проекти.
    //
    // Например:
    //
    // 1. Website
    // 2. Mobile App
    // 3. Online Store
    //
    // По същия начин List<Project>
    // съхранява нашите проекти.
    //
    // static означава, че списъкът е общ.
    //
    // Можем да го използваме директно:
    //
    // ProjectData.Projects
    //
    // Не е необходимо да създаваме
    // обект от класа ProjectData.

    public class ProjectData
    {
        public static List<Project> Projects = new List<Project>();
    }
}
