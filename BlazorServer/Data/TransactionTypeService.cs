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
    public TransactionTypeService (ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<TransactionType>> GetTransactionAsync()
    {
         return await  _context.TransactionTypes.ToListAsync();
    }

    public async Task<TransactionType?> GetTransactionByIdAsync(int id)
    {
        return await _context.TransactionTypes.FindAsync(id) ?? null;
    }

    public async Task<TransactionType?> InsertTransactionAsync(TransactionType transactionType)
    {
        _context.TransactionTypes.Add(transactionType);
        await _context!.SaveChangesAsync();

        return transactionType;
    }
   

    public async Task<TransactionType> UpdateTransactionAsync(int id, TransactionType t)
    {
        var transactionType = await _context.TransactionTypes!.FindAsync(id);

        if (transactionType == null)
            return null!;

            transactionType.TransactionTypeId = t.TransactionTypeId;
            transactionType.Name = t.Name;

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