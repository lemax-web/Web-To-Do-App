using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_App.Migrations
{
    public partial class NewTodoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Lecture", false });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Meal time", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Play Chess", false });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Swimming", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Watch Movies", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Worship", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
