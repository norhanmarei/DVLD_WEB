using DVLD_WEB.Data;
using Microsoft.EntityFrameworkCore;
public class PersonService : IPersonService
{
    private readonly AppDbContext _context;

    public PersonService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Person>> GetAllAsync()
    {
        return await _context.People.ToListAsync();
    }

    public async Task<Person> GetByIdAsync(int personId)
    {
        return await _context.People.FindAsync(personId);
    }

    public async Task<int> AddAsync(Person person)
    {
        _context.People.Add(person);
        await _context.SaveChangesAsync();
        return person.PersonID;
    }

    public async Task<bool> UpdateAsync(Person person)
    {
        _context.People.Update(person);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int personId)
    {
        var person = await _context.People.FindAsync(personId);
        if (person == null) return false;
        _context.People.Remove(person);
        await _context.SaveChangesAsync();
        return true;
    }
}
