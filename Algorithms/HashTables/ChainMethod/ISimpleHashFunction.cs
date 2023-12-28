namespace Algorithms.HashTables.ChainMethod;

public interface ISimpleHashFunction
{
    string Title { get; }
    int Hash(int key);
}