using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccountManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"), 0, "30f331a3-73f9-42aa-a7b5-f1ba982f6382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "asmith@example.com", false, "Alice Smith", false, null, "ASMITH@EXAMPLE.COM", "ASMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPkzl5Vtfu06roqI3PmAoZm/MNX/HDgQuj9nETJqvP5W+U8pLVejJlkAP48LvflXSw==", "+1-555-999-1212", false, "80d42081-958b-462f-9308-f744f975172b", false, "asmith@example.com" },
                    { new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"), 0, "91ef6899-5c19-4c62-90d2-d1a99c9a290b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bjohnson@example.com", false, "Bob Johnson", false, null, "BJOHNSON@EXAMPLE.COM", "BJOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgFOqzPcvXoxod/vi5KDLeuQ79dVHIZcf8fGWNPFTajKTthJ12j1h2zS8ICS8oRDA==", "+1-555-555-1212", false, "5a58cdc9-5216-4b96-9dfd-59e23c00f452", false, "bjohnson@example.com" },
                    { new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"), 0, "42181ec2-2102-46ce-9ff5-c2fc65f14608", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tlee@example.com", false, "Tom Lee", false, null, "TLEE@EXAMPLE.COM", "TLEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAED8G35Q/LAobFE3KQ6Vm2VhLzu7b0zh8utx9s5O3sKOU9w1A6tDc2rlBakcExVHi8g==", "+1-555-444-1212", false, "d4aa35c4-ab0b-4f0b-b1a5-1532c6768bd1", false, "tlee@example.com" },
                    { new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"), 0, "e7c04633-7694-4618-bfba-5c9795e3a405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdoe@example.com", false, "Jane Doe", false, null, "JDOE@EXAMPLE.COM", "JDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOBDC/Oymfs87Zg4stNC48rXgByojwpWHq9K/CJefFeiGRNeRryOuLAxEaIrSxydoQ==", "+1-555-987-6543", false, "b519c870-77b2-4e99-a998-671c7b0a7527", false, "jdoe@example.com" },
                    { new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"), 0, "27b5ac2e-0c89-443c-a762-2921618a6a64", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsmith@example.com", false, "John Smith", false, null, "JSMITH@EXAMPLE.COM", "JSMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJTURLWlbZEr0xH9sEFolrN65+lY1e2orxlsEuNWkKQBug83ikCDfI2G9Ss6E7qQ3Q==", "+1-555-123-4567", false, "39e17423-ddcb-417a-9020-a1107c098653", false, "jsmith@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"));
        }
    }
}
