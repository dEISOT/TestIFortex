using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Status" },
                values: new object[,]
                {
                    { new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a"), "user7@gmail.com", 0 },
                    { new Guid("06fc7431-b349-40e5-a164-731cae812f66"), "user5@gmail.com", 1 },
                    { new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee"), "user4@gmail.com", 0 },
                    { new Guid("509292e2-aa85-4977-9c91-60a849acf23b"), "user2@gmail.com", 0 },
                    { new Guid("5178b392-f04e-43c6-978f-97504131bf3f"), "user6@gmail.com", 1 },
                    { new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2"), "user1@gmail.com", 0 },
                    { new Guid("dca86a0f-b7fb-4e02-92a5-95fdae5c655c"), "user3@gmail.com", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Price", "ProductName", "Quantity", "UserId" },
                values: new object[,]
                {
                    { new Guid("07b58f5d-bd6c-43f5-8041-a0aac4c2324b"), 8, "Garlic", 12, new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee") },
                    { new Guid("1d346b54-ba28-411d-ae93-a851e583f418"), 8, "Onion", 6, new Guid("509292e2-aa85-4977-9c91-60a849acf23b") },
                    { new Guid("355a4e55-de3e-4141-9755-ebab3d3dda81"), 9, "Carrot", 15, new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a") },
                    { new Guid("5950adf8-9e8c-4066-8550-7648608c3e90"), 45, "Orange", 5, new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee") },
                    { new Guid("73163c07-59af-490a-8733-9e8be6e8f4f6"), 3, "Potato", 100, new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a") },
                    { new Guid("7706c658-9fb7-4375-b3de-9c349e761437"), 5, "Cucumber", 10, new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2") },
                    { new Guid("97987e49-9b75-437c-9f74-a49568a6e5a2"), 30, "Lemon", 2, new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2") },
                    { new Guid("b5dffd13-6400-4fa5-aa89-b5d0274d7dd2"), 7, "Cabbage", 2, new Guid("509292e2-aa85-4977-9c91-60a849acf23b") },
                    { new Guid("be4bca81-26eb-4f73-80d8-050a0f00e462"), 10, "Apple", 5, new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2") },
                    { new Guid("db86c26d-4b8f-407c-9548-b4a165a7ef43"), 100, "Watermelon", 12, new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a") },
                    { new Guid("e40378ea-ee33-48c6-b41a-b1cc1c310a65"), 8, "Onion", 15, new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a") },
                    { new Guid("e4a8ebaa-6a9f-4410-a770-60bd5839415e"), 40, "Mango", 2, new Guid("dca86a0f-b7fb-4e02-92a5-95fdae5c655c") },
                    { new Guid("f473dea9-aefc-4a23-9ad3-a3d179b1151c"), 9, "Carrot", 5, new Guid("509292e2-aa85-4977-9c91-60a849acf23b") },
                    { new Guid("f5a6d42e-6770-4b60-8335-6c73fa89bf52"), 50, "Pumpkin", 1, new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a") },
                    { new Guid("f8643ac7-c557-4ea6-8862-380693910545"), 100, "Watermelon", 1, new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
