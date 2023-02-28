using System;
using PracticeDDD.Domain.Entities;
using PracticeDDD.Domain.ValueObjects;

namespace PracticeDDD.Domain.Repositories
{

	public interface IPersonRepository
	{
		Task<Person> GetPersonById(PersonId Id);

		Task AddPerson(Person person);
	}
}
