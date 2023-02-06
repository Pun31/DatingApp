using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Migrations
{
    public partial class AddedDefaultDataAndUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 2, 6, 17, 56, 11, 124, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 122, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 2, 6, 17, 56, 11, 123, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 56, 11, 123, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 2, 6, 17, 56, 11, 123, DateTimeKind.Local).AddTicks(1229) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 2, 6, 17, 54, 9, 418, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 415, DateTimeKind.Local).AddTicks(528), new DateTime(2023, 2, 6, 17, 54, 9, 417, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 17, 54, 9, 417, DateTimeKind.Local).AddTicks(1083), new DateTime(2023, 2, 6, 17, 54, 9, 417, DateTimeKind.Local).AddTicks(1086) });
        }
    }
}
