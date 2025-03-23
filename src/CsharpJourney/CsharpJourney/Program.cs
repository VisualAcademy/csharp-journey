int[] array = { 4, 8, 15, 16, 23 };
var query = from i in array.AsQueryable()
            where i > 5
            where i % 2 == 0
            select i;
foreach (int value in query) { WriteLine(value); }