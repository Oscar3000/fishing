using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fishingApi.Migrations
{
    public partial class foreignKeyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrewMembers_Boats_BoatId",
                table: "CrewMembers");

            migrationBuilder.AlterColumn<int>(
                name: "BoatId",
                table: "CrewMembers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 1,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 9, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 2,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 16, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 3,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 16, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 4,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 16, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 5,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 16, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 6,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 57, 28, 16, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.AddForeignKey(
                name: "FK_CrewMembers_Boats_BoatId",
                table: "CrewMembers",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "BoatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrewMembers_Boats_BoatId",
                table: "CrewMembers");

            migrationBuilder.AlterColumn<int>(
                name: "BoatId",
                table: "CrewMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 1,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 559, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 2,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 3,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 4,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 5,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 6,
                column: "CertifiedUntil",
                value: new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.AddForeignKey(
                name: "FK_CrewMembers_Boats_BoatId",
                table: "CrewMembers",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "BoatId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
