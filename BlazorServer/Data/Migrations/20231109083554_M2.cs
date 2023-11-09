using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 11, 45, 230, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 11, 45, 230, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "TransId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 11, 9, 0, 11, 45, 230, DateTimeKind.Local).AddTicks(6070));
        }
    }
}
