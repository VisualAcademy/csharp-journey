int[] array = { 4, 8, 15, 16, 23 };

var query = Filter(array, i => i > 5);
foreach (int value in query) { Console.WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src)
    {
        if (p(value))
            yield return value;
    }
}

bool ContainsPattern(int[] numbers)
{
    // 첫 번째가 3, 세 번째가 5, 마지막이 30이면 true
    return numbers is [3, _, 5, .., 30]; 
}

Console.WriteLine(ContainsPattern(array));