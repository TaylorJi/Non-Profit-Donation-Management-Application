using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class PaymentMethodService
    {
        private ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PaymentMethodService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<PaymentMethod>> GetPaymentMethodAsync()
        {
            return await _context.PaymentMethods.ToListAsync();
        }

        public async Task<PaymentMethod?> GetPaymentMethodByIdAsync(int id)
        {
            return await _context.PaymentMethods.FindAsync(id) ?? null;
        }

        public async Task<PaymentMethod?> InsertPaymentMethodAsync(PaymentMethod paymentMethod)
        {
            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";
            paymentMethod.Created = DateTime.Now;
            paymentMethod.CreatedBy = userName;

            _context.PaymentMethods.Add(paymentMethod);

            await _context!.SaveChangesAsync();

            return paymentMethod;
        }


        public async Task<PaymentMethod> UpdatePaymentMethodAsync(int id, PaymentMethod p)
        {
            var paymentMethod = await _context.PaymentMethods!.FindAsync(id);
            var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";


            if (paymentMethod == null)
                return null!;

            paymentMethod.PaymentMethodId = p.PaymentMethodId;
            paymentMethod.Name = p.Name;
            paymentMethod.Modified = DateTime.Now;
            paymentMethod.ModifiedBy = userName;


            _context.PaymentMethods.Update(paymentMethod);
            await _context.SaveChangesAsync();

            return paymentMethod!;
        }

        public async Task<PaymentMethod> DeletePaymentMethodAsync(int id)
        {
            var paymentMethod = await _context.PaymentMethods!.FindAsync(id);

            if (paymentMethod == null)
                return null!;

            _context.PaymentMethods.Remove(paymentMethod);
            await _context.SaveChangesAsync();

            return paymentMethod!;
        }

        // private bool PaymentMethodExists(int id)
        // {
        //     return _context.ContactLists!.Any(e => e.AccountNo == id);
        // }
    }
}