int[] array = { 4, 8, 15, 16, 23 };

var processor = new QueryProcessor(array);
var query = processor.Filter(i => i > 5);

foreach (int value in query) { WriteLine(value); }

// C# 12.0: Primary Constructor 적용
public class QueryProcessor(int[] data)
{
    public IEnumerable<int> Filter(Func<int, bool> predicate)
    {
        foreach (var value in data)
            if (predicate(value))
                yield return value;
    }
}