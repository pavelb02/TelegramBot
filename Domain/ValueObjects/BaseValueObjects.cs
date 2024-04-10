using System.Text.Json;

namespace Domain.ValueObjects;

public class BaseValueObjects
{
    /// <summary>
    /// Реализует сравнение DeepCompare
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        
        if (obj.GetType() != this.GetType())
        {
            return false;
        }
        
        var json = JsonSerializer.Serialize(this);
        var otherJson = JsonSerializer.Serialize(obj);

        return json.Equals(otherJson);
    }
    
    /// <summary>
    /// Получает HashCode из сериализаованной сущности
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        var json = JsonSerializer.Serialize(this);
        return json.GetHashCode();
    }
}
// конструктор, свойства property get set, зачем переопределять equals и  gethashcode, что такое переопределить (сигнратуру) метод, что такое сигнатура метода, overrate это