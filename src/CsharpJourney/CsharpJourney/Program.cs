int[] array = { 4, 8, 15, 16, 23 };
IEnumerable<int> query = Filter(array, i => i > 5);
foreach (int value in query) { WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Func<T, bool> p)
{
    foreach (T value in src) { if (p(value)) yield return value; }
}