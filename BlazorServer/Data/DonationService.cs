using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class DonationService
    {
        private ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DonationService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<Donation>> GetDonationsAsync()
        {
            return await _context.Donations.ToListAsync();
        }

        public async Task<Donation?> GetDonationByIdAsync(int id)
        {
            return await _context.Donations.FindAsync(id) ?? null;
        }

        public async Task<Donation?> InsertDonationAsync(Donation donation)
        {
            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";
            donation.Created = DateTime.Now;
            donation.CreatedBy = userName;
            _context.Donations.Add(donation);
            await _context!.SaveChangesAsync();

            return donation;
        }

        public async Task<List<Donation>> GetDonationsByContactListIdAsync(int id)
        {
            return await _context.Donations.Where(d => d.AccountNo! == id).ToListAsync();
        }

        public async Task<Donation> UpdateDonationAsync(int id, Donation d)
        {
            var donation = await _context.Donations!.FindAsync(id);

            if (donation == null)
                return null!;

            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";


            donation.ContactList = d.ContactList;
            donation.PaymentMethod = d.PaymentMethod;
            donation.TransactionType = d.TransactionType;
            donation.Amount = d.Amount;
            donation.Date = d.Date;
            donation.Modified = DateTime.Now;
            donation.ModifiedBy = userName;

            _context.Donations.Update(donation);
            await _context.SaveChangesAsync();

            return donation!;
        }

        public async Task<Donation> DeleteDonationAsync(int id)
        {
            var donation = await _context.Donations!.FindAsync(id);

            if (donation == null)
                return null!;

            _context.Donations.Remove(donation);
            await _context.SaveChangesAsync();

            return donation!;
        }

        private bool DonationExists(int id)
        {
            return _context.Donations!.Any(e => e.TransactionTypeId == id);
        }

    }
}