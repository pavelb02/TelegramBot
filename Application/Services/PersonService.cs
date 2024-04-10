using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class PersonService
{
     private readonly IPersonRepository _personRepository;

     public PersonService(IPersonRepository personRepository)
     {
         _personRepository = _personRepository;
     }

     public Person GetById(Guid id)
     {
         var person = _personRepository.GetById(id);
         return person;
     }
     public Person Create(Person person)
     {
         var newPerson = _personRepository.Create(person);
         return newPerson;
     }
}