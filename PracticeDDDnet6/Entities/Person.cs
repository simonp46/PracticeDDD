﻿using System;

namespace PracticeDDD.Domain.Entities
{
	public class Person
	{
		public Guid Id { get; init; }

		public PersonName Name { get; private set; }
		public Person (Guid id)
        {
			this.Id = id;
        }

		public void SetName(PersonName name)
        {
			Name = name;
        }
	}
}
