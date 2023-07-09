using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TODO.Services.ToDoAPI.Migrations
{
    /// <inheritdoc />
    public partial class ToDoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoId);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ToDoId", "Done", "DueDate", "Task" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get Groceries" },
                    { 2, false, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pay rent" },
                    { 3, false, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Organize garage" },
                    { 4, false, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy furniture" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
