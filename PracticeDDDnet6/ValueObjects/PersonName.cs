using System;

namespace PracticeDDD.Domain.ValueObjects
{
    public record PersonName
    {
	    public string Value { get; init; }

	    internal PersonName(string value)
        {
            this.Value = value;
        }
        public static PersonName Create(string value)
        {
            validate(value);
            return new PersonName(value);
        }
        private static void validate(string value)
        {
            if (value == "")
            {
                throw new ArgumentNullException("el valor no puede ser nulo");
            }
        }
    }
}