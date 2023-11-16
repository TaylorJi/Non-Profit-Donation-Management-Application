using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class TransactionTypeService
    {
        private ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TransactionTypeService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<TransactionType>> GetTransactionAsync()
        {
            return await _context.TransactionTypes.ToListAsync();
        }

        public async Task<TransactionType?> GetTransactionByIdAsync(int id)
        {
            return await _context.TransactionTypes.FindAsync(id) ?? null;
        }

        public async Task<TransactionType?> InsertTransactionAsync(TransactionType transactionType)
        {
            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";

            transactionType.Created = DateTime.Now;
            transactionType.CreatedBy = userName;

            _context.TransactionTypes.Add(transactionType);
            await _context!.SaveChangesAsync();

            return transactionType;
        }


        public async Task<TransactionType> UpdateTransactionAsync(int id, TransactionType t)
        {
            var transactionType = await _context.TransactionTypes!.FindAsync(id);

            if (transactionType == null)
                return null!;

            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";

            transactionType.TransactionTypeId = t.TransactionTypeId;
            transactionType.Name = t.Name;
            transactionType.Modified = DateTime.Now;
            transactionType.ModifiedBy = userName;

            _context.TransactionTypes.Update(transactionType);
            await _context.SaveChangesAsync();

            return transactionType!;
        }

        public async Task<TransactionType> DeleteTransactionAsync(int id)
        {
            var transactionType = await _context.TransactionTypes!.FindAsync(id);

            if (transactionType == null)
                return null!;

            _context.TransactionTypes.Remove(transactionType);
            await _context.SaveChangesAsync();

            return transactionType!;
        }
    }
}