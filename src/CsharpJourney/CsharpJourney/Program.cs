int[] array = { 4, 8, 15, 16, 23 };
var query = array.AsQueryable().Where(i => i > 5).Where(i => i % 2 == 0);
foreach (int value in query) { WriteLine(value); }