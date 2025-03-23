int[] array = { 4, 8, 15, 16, 23 };

await ExecuteQueryAsync(array);

async Task ExecuteQueryAsync(int[] array, bool printMessage = true)
{
    var query = array.AsQueryable().Where(i => i > 5 && i % 2 == 0);

    if (printMessage)
        foreach (int value in query)
            await Task.Run(() => WriteLine(value)); // 비동기적으로 출력
}