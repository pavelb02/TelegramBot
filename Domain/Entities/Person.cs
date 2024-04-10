using Domain.ValueObjects;
using Domain.Primitives;
using Domain.Validators;

namespace Domain.Entities;

public class Person : BaseEntity
{
    public Person(FullName fullName)
    {
        var personValidator = new PersonValidator();
        personValidator.Validate(this);
    }

    public FullName FullName { get; set; }

    public DateTime BirthDay { get; set; }

    public int Age => DateTime.Now.Year - BirthDay.Year;

    public Gender Gender { get; set; }

    public string PhoneNumber { get; set; }

    public string Telegram { get; set; }

    public List<CustomField<string>> CustomFields { get; set; }
}