using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fishingApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "BoatId", "B", "BuildNumber", "LOA", "Name", "Picture", "Producer" },
                values: new object[,]
                {
                    { 1, 30.32m, 10, 201.23m, "Destroyer", (byte)0, "Centos Company" },
                    { 2, 60.32m, 3, 221.23m, "Harbinger", (byte)0, "Centos Company" },
                    { 3, 50.82m, 5, 301.24m, "GameChanger", (byte)0, "Centos Company" },
                    { 4, 30.382m, 13, 301.27m, "LoverBoy", (byte)0, "Hey Company" },
                    { 5, 30.32m, 8, 203.23m, "Hope", (byte)0, "None Company" },
                    { 6, 30.32m, 2, 301.23m, "Startropper", (byte)0, "John Company" },
                    { 7, 30.32m, 140, 751.23m, "Johnson", (byte)0, "Centos Company" },
                    { 8, 350.32m, 120, 6071.23m, "Lost", (byte)0, "tom Company" },
                    { 9, 350.32m, 30, 2601.23m, "Titanic", (byte)0, "Centos Company" }
                });

            migrationBuilder.InsertData(
                table: "CrewMembers",
                columns: new[] { "CrewMemberId", "Age", "BoatId", "CertifiedUntil", "Email", "Name", "Picture", "Role" },
                values: new object[,]
                {
                    { 1, 34, 1, new DateTime(2020, 7, 3, 2, 13, 33, 559, DateTimeKind.Local).AddTicks(1090), null, "James", (byte)0, "Captain" },
                    { 5, 28, 2, new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2586), null, "Gordon", (byte)0, "Deck Cadet" },
                    { 2, 24, 3, new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2496), null, "Elena", (byte)0, "Deck Cadet" },
                    { 3, 44, 5, new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2569), null, "Prince", (byte)0, "Chief Engineer" },
                    { 4, 30, 6, new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2580), null, "Jeremiah", (byte)0, "Motorman" },
                    { 6, 29, 9, new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2591), null, "Kate", (byte)0, "Chief Engineer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "CrewMemberId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatId",
                keyValue: 9);
        }
    }
}
