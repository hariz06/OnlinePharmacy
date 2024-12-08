using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlinePharmacy.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "DateCreated", "DateUpdated", "Prod_Type", "Quantity" },
                values: new object[] { "15.00", new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7632), "Medicine", 15 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "DateCreated", "DateUpdated", "Prod_Name", "Prod_Type", "Quantity" },
                values: new object[] { "10.00", new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7639), "Face Mask", "Cosmetic", 20 });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7977), new DateTime(2024, 12, 8, 16, 56, 23, 515, DateTimeKind.Local).AddTicks(7979) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "DateCreated", "DateUpdated", "Prod_Type", "Quantity" },
                values: new object[] { null, new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(3893), null, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "DateCreated", "DateUpdated", "Prod_Name", "Prod_Type", "Quantity" },
                values: new object[] { null, new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(3900), "Ibuprofen", null, null });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 12, 8, 16, 48, 41, 992, DateTimeKind.Local).AddTicks(4276) });
        }
    }
}
