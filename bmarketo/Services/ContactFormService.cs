using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace bmarketo.Services;

public class ContactFormService
{
    private readonly DataContext _context;
    public ContactFormService(DataContext context)
    {
        _context = context;
    }

    public async Task<ContactFormEntity> GetContactFormAsync(Expression<Func<ContactFormEntity, bool>> predicate)
    {
        var contactFormEntity = await _context.Contacts.FirstOrDefaultAsync(predicate);
        return contactFormEntity!;


    }
    public async Task<bool> RegisterContactFormAsync(ContactFormViewModel contactFormViewModel)
    {
        try
        {
            ContactFormEntity contactFormEntity = contactFormViewModel;

            _context.Contacts.Add(contactFormEntity);
            await _context.SaveChangesAsync();
            return true;
        }
     

        catch
        {
            return false;
        }
    }
}