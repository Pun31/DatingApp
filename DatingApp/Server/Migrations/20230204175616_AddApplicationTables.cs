using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Migrations
{
    public partial class AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8399), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 235, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 2, 5, 1, 56, 16, 235, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 235, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 2, 5, 1, 56, 16, 235, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 2, 5, 1, 56, 16, 234, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 232, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 2, 5, 1, 56, 16, 233, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 56, 16, 233, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 2, 5, 1, 56, 16, 233, DateTimeKind.Local).AddTicks(7397) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3591), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(5316), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(1066), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 2, 5, 1, 50, 32, 931, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 927, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 2, 5, 1, 50, 32, 929, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 5, 1, 50, 32, 930, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 2, 5, 1, 50, 32, 930, DateTimeKind.Local).AddTicks(832) });
        }
    }
}
