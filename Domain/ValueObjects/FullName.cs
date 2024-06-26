﻿using Domain.Validators;

namespace Domain.ValueObjects;

public class FullName : BaseValueObjects
{
    /*// TODO: определить конструктор +
    FullName(string name, string surname, string? patronymic)
    {
        FirstName = name;
        LastName = surname;
        MiddleName = patronymic;
    }
    */
    public FullName()
    {
        var validator = new FullNameValidator();
            
        validator.Validate(this);
    }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
}