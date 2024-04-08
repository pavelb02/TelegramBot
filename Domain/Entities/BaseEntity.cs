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
        if (obj == null)
        {
            return false;
        }
            
        if(obj is not BaseEntity entity)
        {
            return false;
        }

        if (entity.Id != Id)
        {
            return false;
        }

        return true;
    }

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
}