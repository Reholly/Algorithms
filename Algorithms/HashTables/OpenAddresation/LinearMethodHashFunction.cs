namespace Algorithms.HashTables.OpenAddresation;

public class LinearMethodHashFunction : IBiHashFunction
{
    public string Title => "Хэш-функция метод линейного исследования";

    public int Hash(int key, int attempt)
    {
        key = Math.Abs(key);
        return (key + attempt) % 10000;
    }
}