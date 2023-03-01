using PracticeDDD.Domain.Entities;
using PracticeDDD.Domain.Repositories;
using PracticeDDD.Domain.ValueObjects;

namespace PracticeDDD.API.Queries
{
    public class PersonQueries
    {
        public PersonQueries(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> GetPersonIdAsync(Guid id)
        {
            var response = await personRepository.GetPersonById(
                PersonId.create(id));
            return response;
        }
    }
}
