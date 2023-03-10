using PracticeDDD.API.Commands;
using PracticeDDD.API.Queries;
using PracticeDDD.Domain.Entities;
using PracticeDDD.Domain.Repositories;
using PracticeDDD.Domain.ValueObjects;

namespace PracticeDDD.API.ApplicationServices
{
    public class LiveServices
    {
        private readonly IPersonRepository repository;

        public LiveServices(IPersonRepository repository, PersonQueries personQueries)
        {
            this.repository = repository;
        }
        public async Task HandleCommand(CreatePersonCommand createPerson)
        {
            var person = new Person(
                PersonId.create(createPerson.personId));
            person.SetName(PersonName.Create(createPerson.Name));
            await repository.AddPerson(person);
        }
        public async Task<Person> GetPerson(Guid id)
        {
            return await personQueries.GetPersonIdAsync(id);
        }
    }
}
