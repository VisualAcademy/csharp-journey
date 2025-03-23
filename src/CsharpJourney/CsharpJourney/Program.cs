int[] array = { 4, 8, 15, 16, 23 };
var query = Filter(Filter(array, i => i > 5), i => i % 2 == 0);
foreach (int value in query) { WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Func<T, bool> p)
{
    foreach (T value in src) { if (p(value)) yield return value; }
}