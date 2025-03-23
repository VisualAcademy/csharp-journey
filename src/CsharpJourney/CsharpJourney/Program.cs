int[] array = { 4, 8, 15, 16, 23 };

await ExecuteQueryAsync(array);

async Task ExecuteQueryAsync(int[] array, bool printMessage = true) =>
    await (printMessage ? Task.WhenAll(array.AsQueryable()
        .Where(i => i > 5 && i % 2 == 0)
        .Select(i => Task.Run(() => WriteLine(i)))) : Task.CompletedTask);