using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class ContactListService
    {
        private ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

    public ContactListService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<ContactList>> GetContactListsAsync()
    {
         return await  _context.ContactLists.ToListAsync();
    }

    public async Task<ContactList?> GetContactListByIdAsync(int id)
    {
        return await _context.ContactLists.FindAsync(id) ?? null;
    }

    public async Task<ContactList?> InsertContactAsync(ContactList contactList)
    {
        var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";
        contactList.Created = DateTime.Now;

        contactList.CreatedBy = userName;
        _context.ContactLists.Add(contactList);
  
        await _context!.SaveChangesAsync();

        return contactList;
    }
   

    public async Task<ContactList> UpdateContactAsync(int id, ContactList s)
    {
        var contactList = await _context.ContactLists!.FindAsync(id);
        var userName = _httpContextAccessor.HttpContext?.User.Identity.Name ?? "Unknown";

        if (contactList == null)
            return null!;

        contactList.FirstName = s.FirstName;
        contactList.LastName = s.LastName;
        contactList.Email = s.Email;
        contactList.Street = s.Street;
        contactList.City = s.City;
        contactList.PostalCode = s.PostalCode;
        contactList.Country = s.Country;
        contactList.Modified = DateTime.Now;
        contactList.ModifiedBy = userName;

        _context.ContactLists.Update(contactList);
        await _context.SaveChangesAsync();

        return contactList!;
    }

    public async Task<ContactList> DeleteContactAsync(int id)
    {
        var contactList = await _context.ContactLists!.FindAsync(id);

        if (contactList == null)
            return null!;

        _context.ContactLists.Remove(contactList);
        await _context.SaveChangesAsync();

        return contactList!;
    }

    private bool ContactListExists(int id)
    {
        return _context.ContactLists!.Any(e => e.AccountNo == id);
    }

    }
}