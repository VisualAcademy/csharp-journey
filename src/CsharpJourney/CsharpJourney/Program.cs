int[] array = { 4, 8, 15, 16, 23 };
IEnumerable<int> query = Filter<int>(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    List<T> dst = [];
    foreach (T value in src) { if (p(value)) dst.Add(value); }
    return [.. dst];
}

delegate bool Predicate<T>(T i);