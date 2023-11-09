using DonationLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ContactList> ContactLists => Set<ContactList>();
        public DbSet<Donation> Donations => Set<Donation>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
        public DbSet<TransactionType> TransactionTypes => Set<TransactionType>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ContactList>().HasData(GetContactLists());
            modelBuilder.Entity<PaymentMethod>().HasData(GetPaymentMethods());
            modelBuilder.Entity<TransactionType>().HasData(GetTransactionTypes());
            modelBuilder.Entity<Donation>().HasData(GetDonations());
            modelBuilder.Seed();
        }

        private static IEnumerable<ContactList> GetContactLists()
        {
            List<ContactList> contactLists = new List<ContactList>() {
                new ContactList() {
                    AccountNo=12,
                    FirstName="Sam",
                    LastName="Fox",
                    Email="sam@fox.com",
                    Street="457 Fox Avenue",
                    City="Richmond",
                    PostalCode="V4F 1M7",
                    Country="Canada"
                },
                new ContactList() {
                    AccountNo=17,
                    FirstName="Ann",
                    LastName="Day",
                    Email="ann@day.com",
                    Street="231 River Road",
                    City="Delta",
                    PostalCode="V6G 1M6",
                    Country="Canada"
                },
                new ContactList() {
                    AccountNo=24,
                    FirstName="Ellie",
                    LastName="Smith",
                    Email="ellie@smith.com",
                    Street="314 12th Avenue",
                    City="Burnaby",
                    PostalCode="V7L 3J2",
                    Country="Canada"
                },
            };
            return contactLists;
        }

        private static IEnumerable<PaymentMethod> GetPaymentMethods()
        {
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>() {
                new PaymentMethod() {
                    PaymentMethodId=1,
                    Name="Direct Deposit"
                },
                new PaymentMethod() {
                    PaymentMethodId=2,
                    Name="Pay Pal"
                },
                new PaymentMethod() {
                    PaymentMethodId=3,
                    Name="Cheque"
                },
                new PaymentMethod() {
                    PaymentMethodId=6,
                    Name="Other"
                },
            };
            return paymentMethods;
        }

        private static IEnumerable<TransactionType> GetTransactionTypes()
        {
            List<TransactionType> transactionTypes = new List<TransactionType>() {
                new TransactionType() {
                    TransactionTypeId=1,
                    Name="General Donation",
                    Description="Donations made without any special purpose"
                },
                new TransactionType() {
                    TransactionTypeId=2,
                    Name="Food for homeless",
                    Description="Donations made for homeless people"
                },
                new TransactionType() {
                    TransactionTypeId=3,
                    Name="Repair of Gym",
                    Description="Donations for the purpose of upgrading the gym"
                },
            };
            return transactionTypes;
        }

        private static IEnumerable<Donation> GetDonations()
        {
            List<Donation> donations = new List<Donation>() {
                new Donation() {
                    TransId=1,
                    Date=DateTime.Now,
                    AccountNo=24,
                    TransactionTypeId=1,
                    Amount=500,
                    PaymentMethodId=1,
                    Notes="Donated monthly"
                },
                new Donation() {
                    TransId=2,
                    Date=DateTime.Now,
                    AccountNo=17,
                    TransactionTypeId=2,
                    Amount=1000,
                    PaymentMethodId=2,
                    Notes="Donated for homeless people"
                },
                new Donation() {
                    TransId=3,
                    Date=DateTime.Now,
                    AccountNo=12,
                    TransactionTypeId=3,
                    Amount=750,
                    PaymentMethodId=2,
                    Notes="Donators want a new gym"
                },
            };
            return donations;
        }
}
