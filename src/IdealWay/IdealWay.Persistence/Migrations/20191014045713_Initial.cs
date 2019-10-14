using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdealWay.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    ProgrammingLanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsStronglyTyped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.ProgrammingLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    DeveloperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    PrimaryLanguageId = table.Column<int>(nullable: false),
                    YearsOfExperience = table.Column<int>(nullable: false),
                    Level = table.Column<string>(maxLength: 20, nullable: false),
                    Gender = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.DeveloperId);
                    table.ForeignKey(
                        name: "FK_Developer_ProgrammingLanguage_PrimaryLanguageId",
                        column: x => x.PrimaryLanguageId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "ProgrammingLanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyAnswer",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeveloperId = table.Column<int>(nullable: false),
                    YearSalary = table.Column<int>(nullable: false),
                    Satisfied = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyAnswer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_SurveyAnswer_Developer_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developer",
                        principalColumn: "DeveloperId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguage",
                columns: new[] { "ProgrammingLanguageId", "IsStronglyTyped", "Name" },
                values: new object[,]
                {
                    { 1, true, "C#" },
                    { 2, true, "Java" },
                    { 3, false, "C" },
                    { 4, true, "Python" },
                    { 5, false, "C++" },
                    { 6, false, "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "DeveloperId", "FirstName", "Gender", "LastName", "Level", "PrimaryLanguageId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "John", "Male", "Smith", "Junior", 1, 1 },
                    { 25, "Sarah", "Female", "Wash", "Indermediate", 6, 4 },
                    { 23, "Yarema", "Male", "Tras", "TechLead", 6, 1 },
                    { 21, "Yuliy", "Male", "Cesar", "Senior", 6, 9 },
                    { 6, "Vasyl", "Male", "Door", "SeniorPro", 6, 6 },
                    { 20, "Taras", "Male", "Bulba", "Senior", 5, 6 },
                    { 5, "Petro", "Male", "Vovk", "Senior", 5, 5 },
                    { 19, "Svyatohor", "Male", "Velykyy", "Senior", 4, 8 },
                    { 4, "Stepan", "Male", "Zayats", "IntermediatePro", 4, 4 },
                    { 18, "Roman", "Male", "Noran", "Senior", 3, 4 },
                    { 3, "Tom", "Male", "Stack", "Indermediate", 3, 3 },
                    { 29, "Erika", "Female", "Shoe", "Junior", 2, 4 },
                    { 28, "Daryna", "Female", "Cell", "JuniorPro", 2, 2 },
                    { 22, "Yakiv", "Male", "Spurt", "Indermediate", 2, 1 },
                    { 17, "Ostap", "Male", "Monit", "Senior", 2, 14 },
                    { 2, "Joe", "Male", "Dou", "JuniorPro", 2, 2 },
                    { 30, "Yevdokiya", "Female", "Switch", "JuniorPro", 1, 3 },
                    { 24, "Barbara", "Female", "Chair", "Junior", 1, 2 },
                    { 16, "Orest", "Male", "Camer", "Junior", 1, 1 },
                    { 15, "Mykola", "Male", "Oven", "JuniorPro", 1, 13 },
                    { 14, "Kyrylo", "Male", "Lys", "TechLeadPro", 1, 8 },
                    { 13, "Zahar", "Male", "Vedmid", "TechLead", 1, 19 },
                    { 12, "Hnat", "Male", "Refrig", "IntermediatePro", 1, 6 },
                    { 11, "Viktor", "Male", "Window", "Indermediate", 1, 2 },
                    { 10, "Hrytsko", "Male", "Wall", "SeniorPro", 1, 4 },
                    { 9, "Dmytro", "Male", "Glass", "Senior", 1, 3 },
                    { 8, "Ivan", "Male", "Table", "Architect", 1, 10 },
                    { 7, "Brian", "Male", "Laptop", "TechLead", 1, 8 },
                    { 26, "Viktoria", "Female", "Mach", "IntermediatePro", 6, 6 },
                    { 27, "Hanna", "Female", "Pone", "Senior", 6, 8 }
                });

            migrationBuilder.InsertData(
                table: "SurveyAnswer",
                columns: new[] { "AnswerId", "DeveloperId", "YearSalary" },
                values: new object[] { 1, 1, 43000 });

            migrationBuilder.InsertData(
                table: "SurveyAnswer",
                columns: new[] { "AnswerId", "DeveloperId", "Satisfied", "YearSalary" },
                values: new object[,]
                {
                    { 25, 25, true, 55000 },
                    { 23, 23, false, 61000 },
                    { 21, 21, false, 55000 },
                    { 6, 6, false, 58000 },
                    { 20, 20, true, 65000 },
                    { 5, 5, false, 55000 },
                    { 19, 19, false, 55000 },
                    { 4, 4, false, 52000 },
                    { 18, 18, true, 65000 },
                    { 3, 3, false, 49000 },
                    { 29, 29, true, 45000 },
                    { 28, 28, true, 50000 },
                    { 22, 22, true, 55000 },
                    { 17, 17, false, 55000 },
                    { 2, 2, true, 50000 },
                    { 30, 30, false, 46000 },
                    { 24, 24, false, 43000 },
                    { 16, 16, false, 43000 },
                    { 15, 15, false, 46000 },
                    { 14, 14, false, 64000 },
                    { 13, 13, false, 61000 },
                    { 12, 12, false, 52000 },
                    { 11, 11, true, 55000 },
                    { 10, 10, false, 58000 },
                    { 9, 9, false, 55000 },
                    { 8, 8, true, 85000 },
                    { 7, 7, true, 75000 },
                    { 26, 26, false, 52000 },
                    { 27, 27, false, 55000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Developer_PrimaryLanguageId",
                table: "Developer",
                column: "PrimaryLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyAnswer_DeveloperId",
                table: "SurveyAnswer",
                column: "DeveloperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyAnswer");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");
        }
    }
}
