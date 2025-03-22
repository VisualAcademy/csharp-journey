int[] array = { 4, 8, 15, 16, 23 };
int[] query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

int[] Filter(int[] src, Predicate p)
{
    List<int> dst = new List<int>();
    foreach (int value in src) { if (p(value)) dst.Add(value); }
    return dst.ToArray();
}

delegate bool Predicate(int i);