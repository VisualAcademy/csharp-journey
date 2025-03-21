int[] array = { 4, 8, 15, 16, 23 };
int[] query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

int[] Filter(int[] src, Predicate p)
{
    ArrayList dst = new ArrayList();
    foreach (int value in src) { if (p(value)) dst.Add(value); }
    int[] result = new int[dst.Count];
    for (int i = 0; i < result.Length; i++) { result[i] = (int)dst[i]; }
    return result;
}

delegate bool Predicate(int i);
