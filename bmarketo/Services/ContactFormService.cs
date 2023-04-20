using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.ViewModel;

namespace bmarketo.Services;

public class ContactFormService
{
    private readonly DataContext _context;
    public ContactFormService(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateContactFormAsync(ContactFormViewModel contactFormViewModel)
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