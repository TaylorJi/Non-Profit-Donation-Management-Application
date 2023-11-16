﻿// <auto-generated />
using System;
using BlazorServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.Data.Mirgrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231115052843_M3")]
    partial class M3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DonationLibrary.Models.ContactList", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("ContactLists");

                    b.HasData(
                        new
                        {
                            AccountNo = 12,
                            City = "Richmond",
                            Country = "Canada",
                            Email = "sam@fox.com",
                            FirstName = "Sam",
                            LastName = "Fox",
                            PostalCode = "V4F 1M7",
                            Street = "457 Fox Avenue"
                        },
                        new
                        {
                            AccountNo = 17,
                            City = "Delta",
                            Country = "Canada",
                            Email = "ann@day.com",
                            FirstName = "Ann",
                            LastName = "Day",
                            PostalCode = "V6G 1M6",
                            Street = "231 River Road"
                        },
                        new
                        {
                            AccountNo = 24,
                            City = "Burnaby",
                            Country = "Canada",
                            Email = "ellie@smith.com",
                            FirstName = "Ellie",
                            LastName = "Smith",
                            PostalCode = "V7L 3J2",
                            Street = "314 12th Avenue"
                        });
                });

            modelBuilder.Entity("DonationLibrary.Models.Donation", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Amount")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TransactionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransId");

                    b.HasIndex("AccountNo");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 24,
                            Amount = 500f,
                            Date = new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4670),
                            Notes = "Donated monthly",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 17,
                            Amount = 1000f,
                            Date = new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4720),
                            Notes = "Donated for homeless people",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 12,
                            Amount = 750f,
                            Date = new DateTime(2023, 11, 14, 21, 28, 43, 740, DateTimeKind.Local).AddTicks(4720),
                            Notes = "Donators want a new gym",
                            PaymentMethodId = 2,
                            TransactionTypeId = 3
                        });
                });

            modelBuilder.Entity("DonationLibrary.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Name = "Direct Deposit"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Name = "Pay Pal"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Name = "Cheque"
                        },
                        new
                        {
                            PaymentMethodId = 6,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("DonationLibrary.Models.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Description = "Donations made without any special purpose",
                            Name = "General Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Description = "Donations made for homeless people",
                            Name = "Food for homeless"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Description = "Donations for the purpose of upgrading the gym",
                            Name = "Repair of Gym"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "63a59351-ce82-45c1-bfaa-9e76ad5826a3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "61216578-3940-4f15-8e07-399cdb09a0c3",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = "b5e37756-0a93-49f8-81cf-b6bdec395fd1",
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8ddbfb33-8d89-43c3-91f1-045996865974",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e92982c-7eaf-4002-a8f4-048183e425b5",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEAhfyxQpmFpsdL8xX5Z4MVuhd7cX7ZzbXxpYrb4KEbDxqMpYhbSupOrpi+AbUXBOpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "775197f3-5f51-4200-8494-ac9a4aaba20f",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "332a9f6f-b64b-4030-81ef-748a79700a67",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eeaf874e-b95b-4e2a-857c-9d95ba9ce076",
                            Email = "m@m.m",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "M@M.M",
                            NormalizedUserName = "M@M.M",
                            PasswordHash = "AQAAAAIAAYagAAAAECSG4CBYl34uaqlVuvg1ptBFwPVMADTYj/7dJK1NRlIfbmhrDtbhU4FkhY1m6rwvHw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5f7a320b-fe35-4375-a0b4-1f17a396611b",
                            TwoFactorEnabled = false,
                            UserName = "m@m.m"
                        },
                        new
                        {
                            Id = "dc9fc81c-0a0a-42ef-a29a-aba268c3fe42",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "15175e6e-ffb5-4e27-9933-41971fba229e",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEGnxasksFgAz8GjjXkk//AITcKqZJf1et2OnUFRy5xYQp8klM80gnPvi53OXw4VDdw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06e08d7a-696f-40a0-aad3-a64c0da4c40e",
                            TwoFactorEnabled = false,
                            UserName = "f@f.f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DonationLibrary.Models.Donation", b =>
                {
                    b.HasOne("DonationLibrary.Models.ContactList", "ContactList")
                        .WithMany()
                        .HasForeignKey("AccountNo");

                    b.HasOne("DonationLibrary.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("DonationLibrary.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId");

                    b.Navigation("ContactList");

                    b.Navigation("PaymentMethod");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}