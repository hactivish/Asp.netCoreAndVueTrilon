using my_vue_starter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace my_vue_starter.Interfaces
{
    public interface IPersons
{
        //Task<IEnumerable<Persons>> GetSpeciality();
        Task<IEnumerable<Persons>> GetPersons(int Id);
    }
}
