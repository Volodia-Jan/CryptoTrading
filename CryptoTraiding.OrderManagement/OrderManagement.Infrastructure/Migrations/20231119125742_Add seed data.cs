using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Wallets",
                type: "decimal(18,10)",
                precision: 18,
                scale: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "WalletAccounts",
                type: "decimal(18,10)",
                precision: 18,
                scale: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.AlterColumn<string>(
                name: "TradeType",
                table: "Trades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TradeStatus",
                table: "Trades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Trades",
                type: "decimal(18,10)",
                precision: 18,
                scale: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Trades",
                type: "decimal(18,10)",
                precision: 18,
                scale: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cryptocurrencies",
                type: "decimal(18,10)",
                precision: 18,
                scale: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.InsertData(
                table: "Cryptocurrencies",
                columns: new[] { "CryptoId", "CryptoName", "Price", "SymbolCode" },
                values: new object[,]
                {
                    { new Guid("1bfad1ab-8738-40d2-b6ba-91179a3a5d75"), "Ripple", 1.50m, "XRP" },
                    { new Guid("58eb38bc-b6da-44ea-9ae1-d8b5d286da8f"), "Litecoin", 150.00m, "LTC" },
                    { new Guid("714a914b-d65b-4fd1-93a2-a5d398e34412"), "Ethereum", 3000.00m, "ETH" },
                    { new Guid("c5489d67-b99b-4618-ad5d-5c5b44efdc68"), "Cardano", 2.20m, "ADA" },
                    { new Guid("fea7ae61-41c9-44f2-9670-be88907dd763"), "Bitcoin", 50000.00m, "BTC" }
                });

            migrationBuilder.InsertData(
                table: "WalletAccounts",
                columns: new[] { "AccountId", "Balance", "CreationDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"), 2500.75m, new DateTime(2023, 1, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196") },
                    { new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"), 750.25m, new DateTime(2023, 1, 4, 16, 45, 0, 0, DateTimeKind.Unspecified), new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c") },
                    { new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"), 1000.00m, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26") },
                    { new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"), 500.50m, new DateTime(2023, 1, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b") },
                    { new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"), 2000.00m, new DateTime(2023, 1, 5, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9") }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "WalletId", "AccountId", "Amount", "CreationDate", "CryptoId" },
                values: new object[,]
                {
                    { new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243"), new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"), 37.75m, new DateTime(2023, 2, 4, 8, 45, 0, 0, DateTimeKind.Unspecified), new Guid("58eb38bc-b6da-44ea-9ae1-d8b5d286da8f") },
                    { new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac"), new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"), 50.00m, new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fea7ae61-41c9-44f2-9670-be88907dd763") },
                    { new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda"), new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"), 75.00m, new DateTime(2023, 2, 5, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("c5489d67-b99b-4618-ad5d-5c5b44efdc68") },
                    { new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07"), new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"), 100.50m, new DateTime(2023, 2, 3, 14, 15, 0, 0, DateTimeKind.Unspecified), new Guid("1bfad1ab-8738-40d2-b6ba-91179a3a5d75") },
                    { new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37"), new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"), 25.25m, new DateTime(2023, 2, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("714a914b-d65b-4fd1-93a2-a5d398e34412") }
                });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "AccountId", "Amount", "Price", "TradeDateTime", "TradeStatus", "TradeType", "WalletId" },
                values: new object[,]
                {
                    { new Guid("0f22b30a-f618-40f3-ad07-1e8141d250bb"), new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"), 5.00m, 250000.00m, new DateTime(2023, 3, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), "Closed", "Sell", new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac") },
                    { new Guid("122feb9d-6f0f-4302-a91d-f376958f771c"), new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"), 8.25m, 1237.5m, new DateTime(2023, 3, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Sell", new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243") },
                    { new Guid("2b0634e8-2232-4028-a70a-51082b989073"), new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"), 18.00m, 39.6m, new DateTime(2023, 3, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), "Closed", "Sell", new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda") },
                    { new Guid("32526a6b-3068-4724-8484-14d4401b6c75"), new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"), 15.00m, 22.5m, new DateTime(2023, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Sell", new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07") },
                    { new Guid("340b8434-97ce-4ba8-97c5-59012004f8f9"), new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"), 20.50m, 22m, new DateTime(2023, 3, 3, 9, 15, 0, 0, DateTimeKind.Unspecified), "Open", "Buy", new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07") },
                    { new Guid("642434b1-077d-49cd-8437-df0ce5fee7ce"), new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"), 10.00m, 500000.00m, new DateTime(2023, 3, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), "Open", "Buy", new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac") },
                    { new Guid("75fd11c1-5e99-458d-8fea-60893ce0815c"), new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"), 12.50m, 27.5m, new DateTime(2023, 3, 5, 13, 45, 0, 0, DateTimeKind.Unspecified), "Open", "Buy", new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda") },
                    { new Guid("ab24b595-e3fb-4fe0-8636-5363bc082b08"), new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"), 7.75m, 23250.00m, new DateTime(2023, 3, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), "Closed", "Buy", new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37") },
                    { new Guid("e63a740b-6168-4754-b3cb-daa5b42bcd48"), new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"), 10.75m, 1612.5m, new DateTime(2023, 3, 9, 14, 15, 0, 0, DateTimeKind.Unspecified), "Closed", "Buy", new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243") },
                    { new Guid("f2a8fa26-7511-4aeb-b411-4dea829af415"), new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"), 15.75m, 47250.00m, new DateTime(2023, 3, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), "Open", "Sell", new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("0f22b30a-f618-40f3-ad07-1e8141d250bb"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("122feb9d-6f0f-4302-a91d-f376958f771c"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("2b0634e8-2232-4028-a70a-51082b989073"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("32526a6b-3068-4724-8484-14d4401b6c75"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("340b8434-97ce-4ba8-97c5-59012004f8f9"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("642434b1-077d-49cd-8437-df0ce5fee7ce"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("75fd11c1-5e99-458d-8fea-60893ce0815c"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("ab24b595-e3fb-4fe0-8636-5363bc082b08"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("e63a740b-6168-4754-b3cb-daa5b42bcd48"));

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: new Guid("f2a8fa26-7511-4aeb-b411-4dea829af415"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "WalletId",
                keyValue: new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "WalletId",
                keyValue: new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "WalletId",
                keyValue: new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "WalletId",
                keyValue: new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07"));

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "WalletId",
                keyValue: new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37"));

            migrationBuilder.DeleteData(
                table: "Cryptocurrencies",
                keyColumn: "CryptoId",
                keyValue: new Guid("1bfad1ab-8738-40d2-b6ba-91179a3a5d75"));

            migrationBuilder.DeleteData(
                table: "Cryptocurrencies",
                keyColumn: "CryptoId",
                keyValue: new Guid("58eb38bc-b6da-44ea-9ae1-d8b5d286da8f"));

            migrationBuilder.DeleteData(
                table: "Cryptocurrencies",
                keyColumn: "CryptoId",
                keyValue: new Guid("714a914b-d65b-4fd1-93a2-a5d398e34412"));

            migrationBuilder.DeleteData(
                table: "Cryptocurrencies",
                keyColumn: "CryptoId",
                keyValue: new Guid("c5489d67-b99b-4618-ad5d-5c5b44efdc68"));

            migrationBuilder.DeleteData(
                table: "Cryptocurrencies",
                keyColumn: "CryptoId",
                keyValue: new Guid("fea7ae61-41c9-44f2-9670-be88907dd763"));

            migrationBuilder.DeleteData(
                table: "WalletAccounts",
                keyColumn: "AccountId",
                keyValue: new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"));

            migrationBuilder.DeleteData(
                table: "WalletAccounts",
                keyColumn: "AccountId",
                keyValue: new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"));

            migrationBuilder.DeleteData(
                table: "WalletAccounts",
                keyColumn: "AccountId",
                keyValue: new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"));

            migrationBuilder.DeleteData(
                table: "WalletAccounts",
                keyColumn: "AccountId",
                keyValue: new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"));

            migrationBuilder.DeleteData(
                table: "WalletAccounts",
                keyColumn: "AccountId",
                keyValue: new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Wallets",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldPrecision: 18,
                oldScale: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "WalletAccounts",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldPrecision: 18,
                oldScale: 10);

            migrationBuilder.AlterColumn<int>(
                name: "TradeType",
                table: "Trades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TradeStatus",
                table: "Trades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Trades",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldPrecision: 18,
                oldScale: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Trades",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldPrecision: 18,
                oldScale: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cryptocurrencies",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldPrecision: 18,
                oldScale: 10);
        }
    }
}
