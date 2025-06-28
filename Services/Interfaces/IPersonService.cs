using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPersonService
{
    Task<List<Person>> GetAllAsync();
    Task<Person> GetByIdAsync(int personId);
    Task<int> AddAsync(Person person);
    Task<bool> UpdateAsync(Person person);
    Task<bool> DeleteAsync(int personId);
}

