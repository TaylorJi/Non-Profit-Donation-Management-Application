using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServer.Data.Mirgrations
{
    /// <inheritdoc />
    public partial class M4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61216578-3940-4f15-8e07-399cdb09a0c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63a59351-ce82-45c1-bfaa-9e76ad5826a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5e37756-0a93-49f8-81cf-b6bdec395fd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "332a9f6f-b64b-4030-81ef-748a79700a67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ddbfb33-8d89-43c3-91f1-045996865974");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc9fc81c-0a0a-42ef-a29a-aba268c3fe42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "558edccf-fcaa-41e2-b597-f768102108b9", null, "Finance", "FINANCE" },
                    { "5daef0ea-77e5-4d74-bb80-d8a5bb8febe2", null, "Member", "MEMBER" },
                    { "f625cafe-668c-4212-ab0d-40becf5747ae", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6a5f2907-9d05-4f17-b16b-2cefbdda5b11", 0, "4ac39231-8639-4937-b0b0-7bcd05a03a07", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEKgrHtbcbzxlIfeRyevNU0nytmjGqYXtdIRqS9SWCcRJW2IGY8q47k5i6vApw9u4KA==", null, false, "6fdeeba8-4ae6-41e4-97de-909d647412ec", false, "f@f.f" },
                    { "9c1aec01-01f1-4d47-88cc-cad262d2736c", 0, "5101b452-26c6-4645-864d-0050f7c1949a", "m@m.m", true, false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAEE2jQeGBKfbOdfUi3IikUC/4fyPUPc7hIpixGHYZdoYppGx8EzihdwUyKr2Ie/s7lw==", null, false, "7ff91ca1-2e42-4be7-8a46-8b9d921eddda", false, "m@m.m" },
                    { "ba86e740-9ba9-4d73-8a60-b7ad49581a82", 0, "4936f7c0-af36-4c02-90d9-9da066f6c0f7", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEMTyAF1wYY0+N2ed0O9fHW9K3BLDRBo8BZJgZImvf7chHwb+8lubxoZzULVFijua2Q==", null, false, "2ef8e241-5d3b-4155-906a-42c8fa2f57a6", false, "a@a.a" }
                });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 46, 57, 278, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 46, 57, 278, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 46, 57, 278, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "558edccf-fcaa-41e2-b597-f768102108b9", "6a5f2907-9d05-4f17-b16b-2cefbdda5b11" },
                    { "5daef0ea-77e5-4d74-bb80-d8a5bb8febe2", "9c1aec01-01f1-4d47-88cc-cad262d2736c" },
                    { "f625cafe-668c-4212-ab0d-40becf5747ae", "ba86e740-9ba9-4d73-8a60-b7ad49581a82" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "558edccf-fcaa-41e2-b597-f768102108b9", "6a5f2907-9d05-4f17-b16b-2cefbdda5b11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5daef0ea-77e5-4d74-bb80-d8a5bb8febe2", "9c1aec01-01f1-4d47-88cc-cad262d2736c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f625cafe-668c-4212-ab0d-40becf5747ae", "ba86e740-9ba9-4d73-8a60-b7ad49581a82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "558edccf-fcaa-41e2-b597-f768102108b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5daef0ea-77e5-4d74-bb80-d8a5bb8febe2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f625cafe-668c-4212-ab0d-40becf5747ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5f2907-9d05-4f17-b16b-2cefbdda5b11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c1aec01-01f1-4d47-88cc-cad262d2736c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba86e740-9ba9-4d73-8a60-b7ad49581a82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61216578-3940-4f15-8e07-399cdb09a0c3", null, "Member", "MEMBER" },
                    { "63a59351-ce82-45c1-bfaa-9e76ad5826a3", null, "Admin", "ADMIN" },
                    { "b5e37756-0a93-49f8-81cf-b6bdec395fd1", null, "Finance", "FINANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "332a9f6f-b64b-4030-81ef-748a79700a67", 0, "eeaf874e-b95b-4e2a-857c-9d95ba9ce076", "m@m.m", true, false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAECSG4CBYl34uaqlVuvg1ptBFwPVMADTYj/7dJK1NRlIfbmhrDtbhU4FkhY1m6rwvHw==", null, false, "5f7a320b-fe35-4375-a0b4-1f17a396611b", false, "m@m.m" },
                    { "8ddbfb33-8d89-43c3-91f1-045996865974", 0, "8e92982c-7eaf-4002-a8f4-048183e425b5", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEAhfyxQpmFpsdL8xX5Z4MVuhd7cX7ZzbXxpYrb4KEbDxqMpYhbSupOrpi+AbUXBOpw==", null, false, "775197f3-5f51-4200-8494-ac9a4aaba20f", false, "a@a.a" },
                    { "dc9fc81c-0a0a-42ef-a29a-aba268c3fe42", 0, "15175e6e-ffb5-4e27-9933-41971fba229e", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEGnxasksFgAz8GjjXkk//AITcKqZJf1et2OnUFRy5xYQp8klM80gnPvi53OXw4VDdw==", null, false, "06e08d7a-696f-40a0-aad3-a64c0da4c40e", false, "f@f.f" }
                });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4720));
        }
    }
}
