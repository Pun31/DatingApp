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
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 924, DateTimeKind.Local).AddTicks(1262), new DateTime(2023, 2, 10, 1, 29, 35, 924, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 924, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 2, 10, 1, 29, 35, 924, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 2, 10, 1, 29, 35, 923, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 921, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 2, 10, 1, 29, 35, 922, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 29, 35, 922, DateTimeKind.Local).AddTicks(7852), new DateTime(2023, 2, 10, 1, 29, 35, 922, DateTimeKind.Local).AddTicks(7855) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(4072), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(8442), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(9368), new DateTime(2023, 2, 10, 1, 25, 31, 804, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 803, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 2, 10, 1, 25, 31, 803, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 803, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 2, 10, 1, 25, 31, 803, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 799, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 2, 10, 1, 25, 31, 801, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 25, 31, 801, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 2, 10, 1, 25, 31, 801, DateTimeKind.Local).AddTicks(4165) });
        }
    }
}
