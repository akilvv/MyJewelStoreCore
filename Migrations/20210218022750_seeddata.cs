using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyJewelStoreCore.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserMaster",
                columns: new[] { "Id", "ActiveFlag", "CreatedDate", "FirstName", "LastName", "Password", "UserName", "UserType" },
                values: new object[] { 1, 1, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test1", "User1", "167d99fdbdd3b221908cc963a306a762", "Test1.User1", 1 });

            migrationBuilder.InsertData(
                table: "UserMaster",
                columns: new[] { "Id", "ActiveFlag", "CreatedDate", "FirstName", "LastName", "Password", "UserName", "UserType" },
                values: new object[] { 2, 1, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2", "User2", "167d99fdbdd3b221908cc963a306a762", "Test2.User2", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserMaster",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserMaster",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
