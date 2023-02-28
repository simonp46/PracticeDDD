using PracticeDDD.Domain.Entities;
using PracticeDDD.Domain.Repositories;
using PracticeDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDDD.Infraestructure
{
    public class PersonRepository : IPersonRepository
    {
        DatabaseContext db;
        public PersonRepository(DatabaseContext db_)
        {
            db = db_;
        }
        public async Task AddPerson(Person person)
        {
            await db.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public async Task<Person> GetPersonById(PersonId Id)
        {
            return await db.Persons.FindAsync((Guid)Id);
        }
    }
}
