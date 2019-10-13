using IdealWay.Domain.Entities;
using IdealWay.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Persistence.Seed
{
    public static class SeedDataHelper
    {
        public static void SeedAllData(ModelBuilder builder)
        {
            SeedProgrammingLanguages(builder);
            var developers = SeedDevelopers(builder);
            SeedAnswers(developers, builder);
        }

        private static void SeedAnswers(List<Developer> developers, ModelBuilder builder)
        {
            var answers = new List<Answer>();
            var i = 1;
            foreach (var developer in developers)
            {
                var satisfied = new Random().Next(1, 2) == 2;
                var yearSalary = 40000 + (int)developer.Level * (satisfied ? 5000 : 3000); 
                answers.Add(new Answer() { AnswerId = i++, DeveloperId = developer.DeveloperId, Satisfied = satisfied, YearSalary = yearSalary });
            }

            builder.Entity<Answer>().HasData(answers);
        }

        private static void SeedProgrammingLanguages(ModelBuilder builder)
        {
            builder.Entity<ProgrammingLanguage>().HasData(new List<ProgrammingLanguage>
            {
                new ProgrammingLanguage() { ProgrammingLanguageId = 1, Name = "C#", IsStronglyTyped = true },
                new ProgrammingLanguage() { ProgrammingLanguageId = 2, Name = "Java", IsStronglyTyped = true },
                new ProgrammingLanguage() { ProgrammingLanguageId = 3, Name = "C", IsStronglyTyped = false },
                new ProgrammingLanguage() { ProgrammingLanguageId = 4, Name = "Python", IsStronglyTyped = true },
                new ProgrammingLanguage() { ProgrammingLanguageId = 5, Name = "C++", IsStronglyTyped = false },
                new ProgrammingLanguage() { ProgrammingLanguageId = 6, Name = "JavaScript", IsStronglyTyped = false }
            });
        }

        private static List<Developer> SeedDevelopers(ModelBuilder builder)
        {
            var developers = new List<Developer>
            {
                new Developer() {DeveloperId = 1, FirstName = "John", LastName = "Smith", Gender = Gender.Male, Level = AbilitonLevel.Junior, PrimaryLanguageId = 1, YearsOfExperience = 1},
                new Developer() {DeveloperId = 2, FirstName = "Joe", LastName = "Dou", Gender = Gender.Male, Level = AbilitonLevel.JuniorPro, PrimaryLanguageId = 2, YearsOfExperience = 2},
                new Developer() {DeveloperId = 3, FirstName = "Tom", LastName = "Stack", Gender = Gender.Male, Level = AbilitonLevel.Indermediate, PrimaryLanguageId = 3, YearsOfExperience = 3},
                new Developer() {DeveloperId = 4, FirstName = "Stepan", LastName = "Zayats", Gender = Gender.Male, Level = AbilitonLevel.IntermediatePro, PrimaryLanguageId = 4, YearsOfExperience = 4},
                new Developer() {DeveloperId = 5, FirstName = "Petro", LastName = "Vovk", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 5, YearsOfExperience = 5},
                new Developer() {DeveloperId = 6, FirstName = "Vasyl", LastName = "Door", Gender = Gender.Male, Level = AbilitonLevel.SeniorPro, PrimaryLanguageId = 6, YearsOfExperience = 6},
                new Developer() {DeveloperId = 7, FirstName = "Brian", LastName = "Laptop", Gender = Gender.Male, Level = AbilitonLevel.TechLead, PrimaryLanguageId = 1, YearsOfExperience = 8},
                new Developer() {DeveloperId = 8, FirstName = "Ivan", LastName = "Table", Gender = Gender.Male, Level = AbilitonLevel.Architect, PrimaryLanguageId = 1, YearsOfExperience = 10},
                new Developer() {DeveloperId = 9, FirstName = "Dmytro", LastName = "Glass", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 1, YearsOfExperience = 3},
                new Developer() {DeveloperId = 10, FirstName = "Hrytsko", LastName = "Wall", Gender = Gender.Male, Level = AbilitonLevel.SeniorPro, PrimaryLanguageId = 1, YearsOfExperience = 4},
                new Developer() {DeveloperId = 11, FirstName = "Viktor", LastName = "Window", Gender = Gender.Male, Level = AbilitonLevel.Indermediate, PrimaryLanguageId = 1, YearsOfExperience = 2},
                new Developer() {DeveloperId = 12, FirstName = "Hnat", LastName = "Refrig", Gender = Gender.Male, Level = AbilitonLevel.IntermediatePro, PrimaryLanguageId = 1, YearsOfExperience = 6},
                new Developer() {DeveloperId = 13, FirstName = "Zahar", LastName = "Vedmid", Gender = Gender.Male, Level = AbilitonLevel.TechLead, PrimaryLanguageId = 1, YearsOfExperience = 19},
                new Developer() {DeveloperId = 14, FirstName = "Kyrylo", LastName = "Lys", Gender = Gender.Male, Level = AbilitonLevel.TechLeadPro, PrimaryLanguageId = 1, YearsOfExperience = 8},
                new Developer() {DeveloperId = 15, FirstName = "Mykola", LastName = "Oven", Gender = Gender.Male, Level = AbilitonLevel.JuniorPro, PrimaryLanguageId = 1, YearsOfExperience = 13},
                new Developer() {DeveloperId = 16, FirstName = "Orest", LastName = "Camer", Gender = Gender.Male, Level = AbilitonLevel.Junior, PrimaryLanguageId = 1, YearsOfExperience = 1},
                new Developer() {DeveloperId = 17, FirstName = "Ostap", LastName = "Monit", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 2, YearsOfExperience = 14},
                new Developer() {DeveloperId = 18, FirstName = "Roman", LastName = "Noran", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 3, YearsOfExperience = 4},
                new Developer() {DeveloperId = 19, FirstName = "Svyatohor", LastName = "Velykyy", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 4, YearsOfExperience = 8},
                new Developer() {DeveloperId = 20, FirstName = "Taras", LastName = "Bulba", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 5, YearsOfExperience = 6},
                new Developer() {DeveloperId = 21, FirstName = "Yuliy", LastName = "Cesar", Gender = Gender.Male, Level = AbilitonLevel.Senior, PrimaryLanguageId = 6, YearsOfExperience = 9},
                new Developer() {DeveloperId = 22, FirstName = "Yakiv", LastName = "Spurt", Gender = Gender.Male, Level = AbilitonLevel.Indermediate, PrimaryLanguageId = 2, YearsOfExperience = 1},
                new Developer() {DeveloperId = 23, FirstName = "Yarema", LastName = "Tras", Gender = Gender.Male, Level = AbilitonLevel.TechLead, PrimaryLanguageId = 6, YearsOfExperience = 1},
                new Developer() {DeveloperId = 24, FirstName = "Barbara", LastName = "Chair", Gender = Gender.Female, Level = AbilitonLevel.Junior, PrimaryLanguageId = 1, YearsOfExperience = 2},
                new Developer() {DeveloperId = 25, FirstName = "Sarah", LastName = "Wash", Gender = Gender.Female, Level = AbilitonLevel.Indermediate, PrimaryLanguageId = 6, YearsOfExperience = 4},
                new Developer() {DeveloperId = 26, FirstName = "Viktoria", LastName = "Mach", Gender = Gender.Female, Level = AbilitonLevel.IntermediatePro, PrimaryLanguageId = 6, YearsOfExperience = 6},
                new Developer() {DeveloperId = 27, FirstName = "Hanna", LastName = "Pone", Gender = Gender.Female, Level = AbilitonLevel.Senior, PrimaryLanguageId = 6, YearsOfExperience = 8},
                new Developer() {DeveloperId = 28, FirstName = "Daryna", LastName = "Cell", Gender = Gender.Female, Level = AbilitonLevel.JuniorPro, PrimaryLanguageId = 2, YearsOfExperience = 2},
                new Developer() {DeveloperId = 29, FirstName = "Erika", LastName = "Shoe", Gender = Gender.Female, Level = AbilitonLevel.Junior, PrimaryLanguageId = 2, YearsOfExperience = 4},
                new Developer() {DeveloperId = 30, FirstName = "Yevdokiya", LastName = "Switch", Gender = Gender.Female, Level = AbilitonLevel.JuniorPro, PrimaryLanguageId = 1, YearsOfExperience = 3}
            };

            builder.Entity<Developer>().HasData(developers);

            return developers;
        }
    }
}
