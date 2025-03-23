int[] array = { 4, 8, 15, 16, 23 };

await ExecuteQueryAsync(array);

async Task ExecuteQueryAsync(object input, bool printMessage = true)
{
    if (input is int[] array) // input이 int[] 형식인지 확인
        await (printMessage
            ? Task.WhenAll(array.AsQueryable()
                .Where(i => i > 5 && i % 2 == 0)
                .Select(i => Task.Run(() => WriteLine(i))))
            : Task.CompletedTask);
}