int[] array = { 4, 8, 15, 16, 23 };
var query = array.Filter(i => i > 5).Filter(i => i % 2 == 0);
foreach (int value in query) { WriteLine(value); }

static class MyExtensions
{
    public static IEnumerable<T> Filter<T>(
        this IEnumerable<T> src, Func<T, bool> p)
    {
        foreach (T value in src) { if (p(value)) yield return value; }
    }
}