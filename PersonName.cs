using System;

namespace PracticeDDD.Domain.ValueObjects
{
    public class PersonName
    {
	    public string Value { get; set; }

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
            if (value == null)
            {
                throw new ArgumentNUllException("el valor no puede ser nulo");
            }
        }
    }
}