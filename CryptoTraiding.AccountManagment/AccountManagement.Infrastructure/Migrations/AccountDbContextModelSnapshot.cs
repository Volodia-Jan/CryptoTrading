﻿// <auto-generated />
using System;
using AccountManagement.Infrastructure.DatabaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccountManagement.Infrastructure.Migrations
{
    [DbContext(typeof(AccountDbContext))]
    partial class AccountDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountManagement.Infrastructure.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("AccountManagement.Infrastructure.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27b5ac2e-0c89-443c-a762-2921618a6a64",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jsmith@example.com",
                            EmailConfirmed = false,
                            FullName = "John Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "JSMITH@EXAMPLE.COM",
                            NormalizedUserName = "JSMITH@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJTURLWlbZEr0xH9sEFolrN65+lY1e2orxlsEuNWkKQBug83ikCDfI2G9Ss6E7qQ3Q==",
                            PhoneNumber = "+1-555-123-4567",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "39e17423-ddcb-417a-9020-a1107c098653",
                            TwoFactorEnabled = false,
                            UserName = "jsmith@example.com"
                        },
                        new
                        {
                            Id = new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e7c04633-7694-4618-bfba-5c9795e3a405",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jdoe@example.com",
                            EmailConfirmed = false,
                            FullName = "Jane Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "JDOE@EXAMPLE.COM",
                            NormalizedUserName = "JDOE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOBDC/Oymfs87Zg4stNC48rXgByojwpWHq9K/CJefFeiGRNeRryOuLAxEaIrSxydoQ==",
                            PhoneNumber = "+1-555-987-6543",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b519c870-77b2-4e99-a998-671c7b0a7527",
                            TwoFactorEnabled = false,
                            UserName = "jdoe@example.com"
                        },
                        new
                        {
                            Id = new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91ef6899-5c19-4c62-90d2-d1a99c9a290b",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bjohnson@example.com",
                            EmailConfirmed = false,
                            FullName = "Bob Johnson",
                            LockoutEnabled = false,
                            NormalizedEmail = "BJOHNSON@EXAMPLE.COM",
                            NormalizedUserName = "BJOHNSON@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKgFOqzPcvXoxod/vi5KDLeuQ79dVHIZcf8fGWNPFTajKTthJ12j1h2zS8ICS8oRDA==",
                            PhoneNumber = "+1-555-555-1212",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5a58cdc9-5216-4b96-9dfd-59e23c00f452",
                            TwoFactorEnabled = false,
                            UserName = "bjohnson@example.com"
                        },
                        new
                        {
                            Id = new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "30f331a3-73f9-42aa-a7b5-f1ba982f6382",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "asmith@example.com",
                            EmailConfirmed = false,
                            FullName = "Alice Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "ASMITH@EXAMPLE.COM",
                            NormalizedUserName = "ASMITH@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPkzl5Vtfu06roqI3PmAoZm/MNX/HDgQuj9nETJqvP5W+U8pLVejJlkAP48LvflXSw==",
                            PhoneNumber = "+1-555-999-1212",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "80d42081-958b-462f-9308-f744f975172b",
                            TwoFactorEnabled = false,
                            UserName = "asmith@example.com"
                        },
                        new
                        {
                            Id = new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "42181ec2-2102-46ce-9ff5-c2fc65f14608",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tlee@example.com",
                            EmailConfirmed = false,
                            FullName = "Tom Lee",
                            LockoutEnabled = false,
                            NormalizedEmail = "TLEE@EXAMPLE.COM",
                            NormalizedUserName = "TLEE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED8G35Q/LAobFE3KQ6Vm2VhLzu7b0zh8utx9s5O3sKOU9w1A6tDc2rlBakcExVHi8g==",
                            PhoneNumber = "+1-555-444-1212",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d4aa35c4-ab0b-4f0b-b1a5-1532c6768bd1",
                            TwoFactorEnabled = false,
                            UserName = "tlee@example.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("AccountManagement.Infrastructure.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}