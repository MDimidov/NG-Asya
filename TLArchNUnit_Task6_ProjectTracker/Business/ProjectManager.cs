
using System;
using System.Collections.Generic;
using TLArchNUnit_Task6_ProjectTracker.Data;

namespace TLArchNUnit_Task6_ProjectTracker.Business
{
    // BUSINESS LAYER (Слой за логика)
    //
    // Тук пишем правилата за управление
    // на проектите.
    //
    // Този клас отговаря за:
    //
    // 1. Добавяне на нов проект.
    // 2. Намиране на активния проект
    //    с най-голям бюджет.
    // 3. Изчисляване на средния брой
    //    хора в екип за определен статус.

    public class ProjectManager
    {
        // МЕТОД 1: AddProject()
        //
        // Получава проект и го добавя
        // към списъка с проекти.
        //
        // bool означава, че методът връща:
        //
        // true  -> успешно добавяне
        // false -> неуспешно добавяне
        //
        // Преди добавянето проверяваме:
        //
        // 1. Съществува ли проектът?
        // 2. Има ли въведено име?
        // 3. Бюджетът отрицателен ли е?
        // 4. Броят на хората отрицателен ли е?
        // 5. Статусът валиден ли е?
        //
        // Така избягваме записването
        // на неправилни данни.

        public bool AddProject(Project project)
        {
            // null означава, че няма обект.
            //
            // Ако проектът не съществува,
            // няма какво да добавим.

            if (project == null)
            {
                return false;
            }

            // Проверяваме дали името е празно.
            //
            // string.IsNullOrWhiteSpace()
            // проверява дали текстът е празен
            // или съдържа само интервали.

            if (string.IsNullOrWhiteSpace(project.Name))
            {
                return false;
            }

            // Бюджетът не може да бъде
            // отрицателно число.
            //
            // 0 е допустимо, защото проектът
            // може още да няма определен бюджет.

            if (project.Budget < 0)
            {
                return false;
            }

            // Броят на хората не може
            // да бъде отрицателен.
            //
            // 0 е допустимо, защото проектът
            // може да е планиран, но все още
            // да няма назначен екип.

            if (project.TeamSize < 0)
            {
                return false;
            }

            // Проверяваме статуса.
            //
            // Разрешените стойности са:
            //
            // Planned
            // Active
            // Completed
            //
            // != означава "различно от".
            //
            // && означава И.
            //
            // Ако статусът е различен
            // и от трите възможности,
            // връщаме false.

            if (project.Status != "Planned" &&
                project.Status != "Active" &&
                project.Status != "Completed")
            {
                return false;
            }

            // Ако всички проверки са успешни,
            // добавяме проекта в списъка.
            //
            // Add() добавя нов елемент.

            ProjectData.Projects.Add(project);

            return true;
        }

        // МЕТОД 2: GetHighestBudgetActiveProject()
        //
        // Търсим АКТИВНИЯ проект
        // с най-голям бюджет.
        //
        // Например:
        //
        // Website      -> Active, 15000 лв.
        // Mobile App   -> Active, 30000 лв.
        // Online Store -> Completed, 50000 лв.
        // Game         -> Active, 20000 лв.
        //
        // Резултат: Mobile App
        //
        // Защо?
        //
        // Online Store има най-голям бюджет,
        // но е завършен проект.
        //
        // Ние търсим само Active проекти.
        //
        // От тях Mobile App има
        // най-голям бюджет: 30000 лв.

        public Project? GetHighestBudgetActiveProject()
        {
            // Създаваме променлива,
            // в която ще пазим намерения проект.
            //
            // В началото тя е null,
            // защото все още не сме намерили
            // активен проект.
            //
            // Project? означава, че променливата
            // може да съдържа Project или null.

            Project? highestBudgetProject = null;

            // foreach обхожда всички проекти
            // един по един.

            foreach (Project project in ProjectData.Projects)
            {
                // Първо проверяваме дали
                // проектът е активен.
                //
                // == сравнява две стойности.
                //
                // Ако статусът не е Active,
                // пропускаме този проект.

                if (project.Status == "Active")
                {
                    // Проверяваме две възможности:
                    //
                    // 1. Все още не сме намерили
                    //    активен проект.
                    //
                    // 2. Текущият проект има
                    //    по-голям бюджет.
                    //
                    // || означава ИЛИ.
                    //
                    // Достатъчно е едно от
                    // условията да е вярно.

                    if (highestBudgetProject == null || project.Budget > highestBudgetProject.Budget)
                    {
                        // Запомняме текущия проект.

                        highestBudgetProject = project;
                    }
                }
            }

            // Връщаме намерения проект.
            //
            // Ако няма активни проекти,
            // резултатът ще бъде null.

            return highestBudgetProject;
        }

        // МЕТОД 3: GetAverageTeamSizeByStatus()
        //
        // Изчисляваме средния брой хора
        // в екипите на проектите
        // с определен статус.
        //
        // Например:
        //
        // Website      -> Active, 5 души
        // Mobile App   -> Active, 8 души
        // Online Store -> Completed, 12 души
        // Game         -> Active, 2 души
        //
        // Търсим статус: Active
        //
        // Събираме хората:
        //
        // 5 + 8 + 2 = 15
        //
        // Брой активни проекти: 3
        //
        // Среден брой хора:
        //
        // 15 / 3 = 5
        //
        // Резултат: 5
        //
        // Използваме double, защото
        // средният брой може да е
        // дробно число.
        //
        // Например:
        // 5 / 2 = 2.5

        public double GetAverageTeamSizeByStatus(string status)
        {
            // Променлива за общия брой хора.

            int totalTeamSize = 0;

            // Променлива за броя проекти
            // с търсения статус.

            int count = 0;

            // Проверяваме всеки проект.

            foreach (Project project in ProjectData.Projects)
            {
                // Ако статусът на проекта
                // съвпада с търсения статус,
                // добавяме хората от екипа.

                if (project.Status == status)
                {
                    // += добавя стойност
                    // към текущия сбор.
                    //
                    // Например:
                    // totalTeamSize = 5
                    // добавяме 8
                    // totalTeamSize става 13.

                    totalTeamSize += project.TeamSize;

                    // Увеличаваме броя проекти с 1.
                    //
                    // count++ е същото като:
                    // count = count + 1;

                    count++;
                }
            }

            // Ако няма проекти с този статус,
            // връщаме 0.
            //
            // Така избягваме деление на нула.

            if (count == 0)
            {
                return 0;
            }

            // Изчисляваме средната стойност.
            //
            // Средно = Общ брой хора / Брой проекти
            //
            // (double) превръща общия брой
            // в дробно число.
            //
            // Това е важно!
            //
            // Ако напишем:
            // 5 / 2
            // при две цели числа получаваме 2.
            //
            // Ако напишем:
            // (double)5 / 2
            // получаваме 2.5.

            double averageTeamSize = (double)totalTeamSize / count;

            return averageTeamSize;
        }
    }
}
