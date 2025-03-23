int[] array = { 4, 8, 15, 16, 23 };
IEnumerable<int> query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<int> Filter(IEnumerable<int> src, Predicate p)
{
    List<int> dst = [];
    foreach (int value in src) { if (p(value)) dst.Add(value); }
    return [.. dst];
}

delegate bool Predicate(int i);