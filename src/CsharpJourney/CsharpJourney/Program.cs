int[] array = { 4, 8, 15, 16, 23 };

var query = FilterAndProcess(array);

foreach (int value in query) { WriteLine(value); }

static IEnumerable<int> FilterAndProcess(params IEnumerable<int>[] numbers)
{
    return numbers.SelectMany(n => n).Where(i => i > 5).Where(i => i % 2 == 0);
}