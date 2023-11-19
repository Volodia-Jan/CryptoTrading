﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Infrastructure.DatabaseContexts;

#nullable disable

namespace OrderManagement.Infrastructure.Migrations
{
    [DbContext(typeof(OrderManagementContext))]
    [Migration("20231119125742_Add seed data")]
    partial class Addseeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Cryptocurrency", b =>
                {
                    b.Property<Guid>("CryptoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CryptoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("decimal(18,10)");

                    b.Property<string>("SymbolCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CryptoId");

                    b.ToTable("Cryptocurrencies");

                    b.HasData(
                        new
                        {
                            CryptoId = new Guid("fea7ae61-41c9-44f2-9670-be88907dd763"),
                            CryptoName = "Bitcoin",
                            Price = 50000.00m,
                            SymbolCode = "BTC"
                        },
                        new
                        {
                            CryptoId = new Guid("714a914b-d65b-4fd1-93a2-a5d398e34412"),
                            CryptoName = "Ethereum",
                            Price = 3000.00m,
                            SymbolCode = "ETH"
                        },
                        new
                        {
                            CryptoId = new Guid("1bfad1ab-8738-40d2-b6ba-91179a3a5d75"),
                            CryptoName = "Ripple",
                            Price = 1.50m,
                            SymbolCode = "XRP"
                        },
                        new
                        {
                            CryptoId = new Guid("58eb38bc-b6da-44ea-9ae1-d8b5d286da8f"),
                            CryptoName = "Litecoin",
                            Price = 150.00m,
                            SymbolCode = "LTC"
                        },
                        new
                        {
                            CryptoId = new Guid("c5489d67-b99b-4618-ad5d-5c5b44efdc68"),
                            CryptoName = "Cardano",
                            Price = 2.20m,
                            SymbolCode = "ADA"
                        });
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Trade", b =>
                {
                    b.Property<Guid>("TradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 10)
                        .HasColumnType("decimal(18,10)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("decimal(18,10)");

                    b.Property<DateTime>("TradeDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TradeStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TradeId");

                    b.HasIndex("AccountId");

                    b.HasIndex("WalletId");

                    b.ToTable("Trades");

                    b.HasData(
                        new
                        {
                            TradeId = new Guid("642434b1-077d-49cd-8437-df0ce5fee7ce"),
                            AccountId = new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"),
                            Amount = 10.00m,
                            Price = 500000.00m,
                            TradeDateTime = new DateTime(2023, 3, 1, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Open",
                            TradeType = "Buy",
                            WalletId = new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac")
                        },
                        new
                        {
                            TradeId = new Guid("f2a8fa26-7511-4aeb-b411-4dea829af415"),
                            AccountId = new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"),
                            Amount = 15.75m,
                            Price = 47250.00m,
                            TradeDateTime = new DateTime(2023, 3, 2, 14, 45, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Open",
                            TradeType = "Sell",
                            WalletId = new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37")
                        },
                        new
                        {
                            TradeId = new Guid("340b8434-97ce-4ba8-97c5-59012004f8f9"),
                            AccountId = new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"),
                            Amount = 20.50m,
                            Price = 22m,
                            TradeDateTime = new DateTime(2023, 3, 3, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Open",
                            TradeType = "Buy",
                            WalletId = new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07")
                        },
                        new
                        {
                            TradeId = new Guid("122feb9d-6f0f-4302-a91d-f376958f771c"),
                            AccountId = new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"),
                            Amount = 8.25m,
                            Price = 1237.5m,
                            TradeDateTime = new DateTime(2023, 3, 4, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Open",
                            TradeType = "Sell",
                            WalletId = new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243")
                        },
                        new
                        {
                            TradeId = new Guid("75fd11c1-5e99-458d-8fea-60893ce0815c"),
                            AccountId = new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"),
                            Amount = 12.50m,
                            Price = 27.5m,
                            TradeDateTime = new DateTime(2023, 3, 5, 13, 45, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Open",
                            TradeType = "Buy",
                            WalletId = new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda")
                        },
                        new
                        {
                            TradeId = new Guid("0f22b30a-f618-40f3-ad07-1e8141d250bb"),
                            AccountId = new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"),
                            Amount = 5.00m,
                            Price = 250000.00m,
                            TradeDateTime = new DateTime(2023, 3, 6, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Closed",
                            TradeType = "Sell",
                            WalletId = new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac")
                        },
                        new
                        {
                            TradeId = new Guid("ab24b595-e3fb-4fe0-8636-5363bc082b08"),
                            AccountId = new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"),
                            Amount = 7.75m,
                            Price = 23250.00m,
                            TradeDateTime = new DateTime(2023, 3, 7, 9, 45, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Closed",
                            TradeType = "Buy",
                            WalletId = new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37")
                        },
                        new
                        {
                            TradeId = new Guid("32526a6b-3068-4724-8484-14d4401b6c75"),
                            AccountId = new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"),
                            Amount = 15.00m,
                            Price = 22.5m,
                            TradeDateTime = new DateTime(2023, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Closed",
                            TradeType = "Sell",
                            WalletId = new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07")
                        },
                        new
                        {
                            TradeId = new Guid("e63a740b-6168-4754-b3cb-daa5b42bcd48"),
                            AccountId = new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"),
                            Amount = 10.75m,
                            Price = 1612.5m,
                            TradeDateTime = new DateTime(2023, 3, 9, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Closed",
                            TradeType = "Buy",
                            WalletId = new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243")
                        },
                        new
                        {
                            TradeId = new Guid("2b0634e8-2232-4028-a70a-51082b989073"),
                            AccountId = new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"),
                            Amount = 18.00m,
                            Price = 39.6m,
                            TradeDateTime = new DateTime(2023, 3, 10, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            TradeStatus = "Closed",
                            TradeType = "Sell",
                            WalletId = new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda")
                        });
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Wallet", b =>
                {
                    b.Property<Guid>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 10)
                        .HasColumnType("decimal(18,10)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CryptoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WalletId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CryptoId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            WalletId = new Guid("3b16021a-88d5-449d-a74a-4bd2ca211fac"),
                            AccountId = new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"),
                            Amount = 50.00m,
                            CreationDate = new DateTime(2023, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            CryptoId = new Guid("fea7ae61-41c9-44f2-9670-be88907dd763")
                        },
                        new
                        {
                            WalletId = new Guid("e946a7a5-d2cc-45fa-b4c4-6288a3b90f37"),
                            AccountId = new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"),
                            Amount = 25.25m,
                            CreationDate = new DateTime(2023, 2, 2, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            CryptoId = new Guid("714a914b-d65b-4fd1-93a2-a5d398e34412")
                        },
                        new
                        {
                            WalletId = new Guid("76fe9741-5ee1-4230-83bb-7e97fd708a07"),
                            AccountId = new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"),
                            Amount = 100.50m,
                            CreationDate = new DateTime(2023, 2, 3, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            CryptoId = new Guid("1bfad1ab-8738-40d2-b6ba-91179a3a5d75")
                        },
                        new
                        {
                            WalletId = new Guid("1d9cb663-784d-4e33-a5ae-87cc91346243"),
                            AccountId = new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"),
                            Amount = 37.75m,
                            CreationDate = new DateTime(2023, 2, 4, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            CryptoId = new Guid("58eb38bc-b6da-44ea-9ae1-d8b5d286da8f")
                        },
                        new
                        {
                            WalletId = new Guid("71b375fe-4c15-44ee-abe2-7b73589e1dda"),
                            AccountId = new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"),
                            Amount = 75.00m,
                            CreationDate = new DateTime(2023, 2, 5, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            CryptoId = new Guid("c5489d67-b99b-4618-ad5d-5c5b44efdc68")
                        });
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.WalletAccount", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasPrecision(18, 10)
                        .HasColumnType("decimal(18,10)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AccountId");

                    b.ToTable("WalletAccounts");

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("c3e4b62b-3fd3-4d3f-a8e5-5e5c5d4c3b2a"),
                            Balance = 1000.00m,
                            CreationDate = new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26")
                        },
                        new
                        {
                            AccountId = new Guid("d5e6f7a8-9b0c-4d5e-6f7a-8b9c0d1e2f3a"),
                            Balance = 500.50m,
                            CreationDate = new DateTime(2023, 1, 2, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b")
                        },
                        new
                        {
                            AccountId = new Guid("a1b2c3d4-e5f6-4a5b-9c8d-7e6f5a4b3c2d"),
                            Balance = 2500.75m,
                            CreationDate = new DateTime(2023, 1, 3, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196")
                        },
                        new
                        {
                            AccountId = new Guid("b2c3d4e5-f6a7-5b6c-8d9e-0f1a2b3c4d5e"),
                            Balance = 750.25m,
                            CreationDate = new DateTime(2023, 1, 4, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c")
                        },
                        new
                        {
                            AccountId = new Guid("e5f6a7b8-c9d0-4e5f-6a7b-8c9d0e1f2a3b"),
                            Balance = 2000.00m,
                            CreationDate = new DateTime(2023, 1, 5, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9")
                        });
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Trade", b =>
                {
                    b.HasOne("OrderManagement.Infrastructure.Entities.WalletAccount", "WalletAccount")
                        .WithMany("Trades")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OrderManagement.Infrastructure.Entities.Wallet", "Wallet")
                        .WithMany("Trades")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Wallet");

                    b.Navigation("WalletAccount");
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Wallet", b =>
                {
                    b.HasOne("OrderManagement.Infrastructure.Entities.WalletAccount", "WalletAccount")
                        .WithMany("Wallets")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderManagement.Infrastructure.Entities.Cryptocurrency", "Cryptocurrency")
                        .WithMany("Wallets")
                        .HasForeignKey("CryptoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cryptocurrency");

                    b.Navigation("WalletAccount");
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Cryptocurrency", b =>
                {
                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.Wallet", b =>
                {
                    b.Navigation("Trades");
                });

            modelBuilder.Entity("OrderManagement.Infrastructure.Entities.WalletAccount", b =>
                {
                    b.Navigation("Trades");

                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
