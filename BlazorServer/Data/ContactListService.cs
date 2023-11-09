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
    public ContactListService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ContactList>> GetContactListsAsync()
    {
         return await  _context.ContactLists.ToListAsync();
    }

    public async Task<ContactList?> GetContactListByIdAsync(int id)
    {
        return await _context.ContactLists.FindAsync(id) ?? null;
    }

    public async Task<ContactList?> InsertStudentAsync(ContactList contactList)
    {
        _context.ContactLists.Add(contactList);
        await _context!.SaveChangesAsync();

        return contactList;
    }
   

    public async Task<ContactList> UpdateStudentAsync(int id, ContactList s)
    {
        var contactList = await _context.ContactLists!.FindAsync(id);

        if (contactList == null)
            return null!;

        contactList.FirstName = s.FirstName;
        contactList.LastName = s.LastName;
        contactList.Email = s.Email;
        contactList.Street = s.Street;
        contactList.City = s.City;
        contactList.PostalCode = s.PostalCode;
        contactList.Country = s.Country;

        _context.ContactLists.Update(contactList);
        await _context.SaveChangesAsync();

        return contactList!;
    }

    public async Task<ContactList> DeleteStudentAsync(int id)
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