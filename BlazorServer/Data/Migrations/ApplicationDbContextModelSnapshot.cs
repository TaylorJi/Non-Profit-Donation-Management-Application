﻿// <auto-generated />
using System;
using BlazorServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Date = new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(40),
                            Notes = "Donated monthly",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 17,
                            Amount = 1000f,
                            Date = new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(100),
                            Notes = "Donated for homeless people",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 12,
                            Amount = 750f,
                            Date = new DateTime(2023, 11, 9, 0, 35, 54, 737, DateTimeKind.Local).AddTicks(100),
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
                            Id = "4d218782-7617-4e0a-8c52-a96ac8d97a2f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "011c83ab-0c91-4b67-b764-7ed6f65aedb3",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = "37f2a09b-6a6f-4435-aca7-c72646a2e065",
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
                            Id = "8c435892-94e6-4ce4-aea1-91ee33574a2e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4375e12c-9c3d-428c-9348-d1fcb4da08bf",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEMuXo7IWzbCtSuJNMqNoKlJ9ypANbRqDNhSyyvfPVkQdlC+qvqydyYpy6HJiYNo96Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "939273ef-9e20-4833-8a56-e43821142453",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "042e4385-7f45-4472-8a05-922a929d1e41",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "909010c3-ce43-4374-aff0-c4db9be33877",
                            Email = "m@m.m",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "M@M.M",
                            NormalizedUserName = "M@M.M",
                            PasswordHash = "AQAAAAIAAYagAAAAEMV3Dab6vHymR4B3db01IEiNoDCnHUtk47gByfodEA0KnPCKF7LMJ9zPCimchSnsuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "53986f1d-7b43-460f-b4ac-286c1074a1af",
                            TwoFactorEnabled = false,
                            UserName = "m@m.m"
                        },
                        new
                        {
                            Id = "8c315ded-f41b-490c-ad2f-747a26a0137a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aee4e104-ae75-46b1-8a69-8db401779daa",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAEDuhmt/5WwHMjXrW0ITDpFoT8vcbe2kK00qgGv2+ytf7omthCcuUfX+eff0/BbOodg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "096602a7-2915-4cab-997a-1856d0ec75ec",
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
