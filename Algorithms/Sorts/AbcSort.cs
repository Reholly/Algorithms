namespace Algorithms.Sorts;

public class AbcSort
{
    private List<string> Sort(List<string> collection, int rank)
    {
        if (collection.Count < 2) return collection;

        var table = new Dictionary<char, List<string>>(); // key - символ в позиции rank, список слов с символом key в позиции rank
        var listResult = new List<string>();
        var shortWordsCounter = 0;

        foreach (var str in collection)
        {
            if (rank < str.Length)
            {
                if (table.ContainsKey(str[rank]))
                {
                    table[str[rank]].Add(str);
                }
                else
                {
                    table.Add(str[rank], new List<string> { str });
                }
            }
            else
            {
                listResult.Add(str);
                shortWordsCounter++;
            }
        }

        if (shortWordsCounter == collection.Count) return collection;

        for (var i = 'а'; i <= 'я'; i++)
        {
            if (table.ContainsKey(i))
            {
                foreach (var str in Sort(table[i], rank + 1))
                {
                    listResult.Add(str);
                }
            }
        }

        return listResult;
    }
}