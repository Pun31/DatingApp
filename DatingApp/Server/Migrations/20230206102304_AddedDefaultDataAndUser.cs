using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(850), new DateTime(2023, 2, 6, 18, 23, 4, 66, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 63, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 2, 6, 18, 23, 4, 64, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 23, 4, 64, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 2, 6, 18, 23, 4, 64, DateTimeKind.Local).AddTicks(6016) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsultDate", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(9885), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "MatchTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 425, DateTimeKind.Local).AddTicks(725), new DateTime(2023, 2, 6, 18, 2, 37, 425, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 2, 6, 18, 2, 37, 424, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 420, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 2, 6, 18, 2, 37, 421, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 18, 2, 37, 422, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 2, 6, 18, 2, 37, 422, DateTimeKind.Local).AddTicks(481) });
        }
    }
}
