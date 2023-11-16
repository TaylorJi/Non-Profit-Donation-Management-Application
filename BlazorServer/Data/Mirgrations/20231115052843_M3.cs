using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServer.Data.Mirgrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011c83ab-0c91-4b67-b764-7ed6f65aedb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37f2a09b-6a6f-4435-aca7-c72646a2e065");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d218782-7617-4e0a-8c52-a96ac8d97a2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "042e4385-7f45-4472-8a05-922a929d1e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c315ded-f41b-490c-ad2f-747a26a0137a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c435892-94e6-4ce4-aea1-91ee33574a2e");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "011c83ab-0c91-4b67-b764-7ed6f65aedb3", null, "Member", "MEMBER" },
                    { "37f2a09b-6a6f-4435-aca7-c72646a2e065", null, "Finance", "FINANCE" },
                    { "4d218782-7617-4e0a-8c52-a96ac8d97a2f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "042e4385-7f45-4472-8a05-922a929d1e41", 0, "909010c3-ce43-4374-aff0-c4db9be33877", "m@m.m", true, false, null, "M@M.M", "M@M.M", "AQAAAAIAAYagAAAAEMV3Dab6vHymR4B3db01IEiNoDCnHUtk47gByfodEA0KnPCKF7LMJ9zPCimchSnsuA==", null, false, "53986f1d-7b43-460f-b4ac-286c1074a1af", false, "m@m.m" },
                    { "8c315ded-f41b-490c-ad2f-747a26a0137a", 0, "aee4e104-ae75-46b1-8a69-8db401779daa", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEDuhmt/5WwHMjXrW0ITDpFoT8vcbe2kK00qgGv2+ytf7omthCcuUfX+eff0/BbOodg==", null, false, "096602a7-2915-4cab-997a-1856d0ec75ec", false, "f@f.f" },
                    { "8c435892-94e6-4ce4-aea1-91ee33574a2e", 0, "4375e12c-9c3d-428c-9348-d1fcb4da08bf", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEMuXo7IWzbCtSuJNMqNoKlJ9ypANbRqDNhSyyvfPVkQdlC+qvqydyYpy6HJiYNo96Q==", null, false, "939273ef-9e20-4833-8a56-e43821142453", false, "a@a.a" }
                });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(100));
        }
    }
}
