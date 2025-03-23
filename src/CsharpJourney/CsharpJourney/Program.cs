int[] array = { 4, 8, 15, 16, 23 };
var query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Func<T, bool> p)
{
    foreach (T value in src) { if (p(value)) yield return value; }
}
