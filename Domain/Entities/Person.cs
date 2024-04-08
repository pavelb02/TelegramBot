using Domain.ValueObjects;

namespace Domain.Entities;

public class Person: BaseEntity
{
    // Person person1 = new Person(fullName1, 10.05.2001, 23)
    public Person(FullName fullName, DateTime birthday, int age)
    {
        FullName = fullName;
        Birthday = birthday;
        Age = age;
        CustomFields = new List<CustomField>(); // ?
    }
    
    public FullName FullName { get; set; }
    public DateTime Birthday { get; private set; }
    public int Age {
        get
        {
            return DateTime.Now.Year - Birthday.Year;
        }
        set
        {
            // TODO: Реализовать сеттер. Реализовать проверку. +
            if (value != DateTime.Now.Year - Birthday.Year)
                Console.WriteLine("Ошибка! Неверный возраст");
            else
                Age = value;
            //Age = Checkup(Birthday, value);
        }
    }
    /*
     private int Checkup(DateTime birthday, int value)
     {
         if (DateTime.Now.Year - Birthday.Year == value)
             return value;
         else
         {
             Console.WriteLine("Ошибка! Неверный возраст");
         }
 
         // без него ошибка
         throw new InvalidOperationException();
     }
     */
   
    // TODO: Лист с сущностями. Класс кастомфил, найм и значение, стригни +
    /// <summary>
    ///     Для чего нужен этот лист?
    ///     Чтобы хранить еще какие-то данные каждого из объектов класса или
    ///     определенные данные создаваемых объектов помещать в этот лист?
    /// </summary>
    public List<CustomField> CustomFields { get; set; }
    // нужно ли?
    public void AddCustomField(string name, string value)
    {
        CustomFields.Add(new CustomField(name, value));
    }
}
public class CustomField
{
    public string Name { get; set; }
    public string Value { get; set; }

    // Конструктор
    public CustomField(string name, string value)
    {
        Name = name;
        Value = value;
    }
}