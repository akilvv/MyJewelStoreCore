using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyJewelStoreCore.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConfigMaster",
                columns: new[] { "Id", "ActiveFlag", "CreatedDate", "Key", "Value" },
                values: new object[] { 1, 1, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "JewelStore.Discount", "10" });

            migrationBuilder.InsertData(
                table: "ConfigMaster",
                columns: new[] { "Id", "ActiveFlag", "CreatedDate", "Key", "Value" },
                values: new object[] { 2, 1, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "JewelStore.EncryptKey", "abcde" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigMaster",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConfigMaster",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
