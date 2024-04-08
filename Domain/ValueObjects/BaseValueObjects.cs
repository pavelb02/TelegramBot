namespace Domain.ValueObjects;

public class BaseValueObjects
{
    //todo * разобратся как сравнить (DeepCompare ==>DeepClone)
    // Использование бинарной сериализации BinaryFormatter
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
// конструктор, свойства property get set, зачем переопределять equals и  gethashcode, что такое переопределить (сигнратуру) метод, что такое сигнатура метода, overrate это