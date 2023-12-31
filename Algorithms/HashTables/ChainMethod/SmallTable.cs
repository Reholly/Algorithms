using KeyValuePair = Algorithms.HashTables.ChainMethod.Models.KeyValuePair;

namespace Algorithms.HashTables.ChainMethod;

public class SmallTable
{
    public ISimpleHashFunction HashFunction => _simpleHashFunction;
    
    private readonly ISimpleHashFunction _simpleHashFunction;
    private readonly Models.LinkedList<KeyValuePair>[] _buckets;

    public SmallTable(ISimpleHashFunction simpleHashFunction)
    {
        _simpleHashFunction = simpleHashFunction;
        _buckets = new Models.LinkedList<KeyValuePair>[1000];
    }

    public void Add(int key, int value)
    {
        int index = _simpleHashFunction.Hash(key);

        if (Get(key) != null)
        {
            return;
        }

        if (_buckets[index] is null)
            _buckets[index] = new Models.LinkedList<KeyValuePair>();
        /*if(Get(key) is null)
          _buckets[index].AppendToEnd(new KeyValuePair(key, value));
          */ //если нужно чтоб только уникальные были
        _buckets[index].AppendToEnd(new KeyValuePair(key, value));
    }

    public int? Get(int key)
    {
        int index = _simpleHashFunction.Hash(key);

        if (_buckets[index] is not null)
            foreach (var pair in _buckets[index])
                if (pair.Data.Key == key)
                    return pair.Data.Value;
        
        return null;
    }

    public void Remove(int key)
    {
        int index = _simpleHashFunction.Hash(key);

        if (_buckets[index] is not null)
            foreach (var pair in _buckets[index])
                if(pair.Data.Key == key)
                    _buckets[index].RemoveFirstByValue(pair.Data);
    }

    public double GetFillingCoefficient()
    {
        double count = 0;
        
        foreach (var i in _buckets)
            if (i is not null)
                foreach (var j in i)
                    count += 1;

        return count / 1000d;
    }

    public int GetBiggestChainCount()
    {
        int max = 0;
        
        foreach (var i in _buckets)
            if(i is not null)
                max = Math.Max(max, (int) i.Length);
        
        return max;
    }
    
    public int GetSmallestChainCount()
    {
        int min = int.MaxValue;
        
        foreach (var i in _buckets)
            if(i is not null)
                min = Math.Min(min, (int) i.Length);
        
        return min;
    }

    public void AddRange(KeyValuePair[] keyValuePairs)
    {
        for(int i = 0; i < keyValuePairs.Length; i++)
            Add(keyValuePairs[i].Key, keyValuePairs[i].Value);
    }
}