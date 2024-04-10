namespace Domain.Entities;

/// <summary>
/// Базовый класс для всех сущностей
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Идентификатоор сущностей
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Переопределение метода
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if(obj is not BaseEntity entity)
        {
            return false;
        }

        return Id == entity.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(BaseEntity? entity1, BaseEntity? entity2)
    {
        if (ReferenceEquals(entity1, entity2))
        {
            return true;
        }

        if (entity1 is null || entity2 is null)
        {
            return false;
        }

        return entity1.Id == entity2.Id;
    }

    public static bool operator !=(BaseEntity? entity1, BaseEntity? entity2)
    {
        return !(entity1 == entity2);
    }
    
    /*
    // как я сделал
    public override int GetHashCode()
    {
        // TODO: поресёрчить и переопределить
        // вместо исключения будет некорректное число
        unchecked // Используется для избежания переполнения при вычислении хеш-кода
        {
            int hash = 17; // Начальное значение хеш-кода

            // Добавление поля Id в хеш-код
            hash = hash * 23 + Id.GetHashCode();

            // Добавление других неизменяемых полей в хеш-код
            // hash = hash * 23 + SomeOtherField1.GetHashCode();
            // hash = hash * 23 + SomeOtherField2.GetHashCode();

            return hash;
        }
    }
    */
}