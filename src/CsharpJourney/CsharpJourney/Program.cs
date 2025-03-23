int[] array = { 4, 8, 15, 16, 23 };

await ExecuteQueryAsync(array);

// C# 8.0: switch 식 적용
async Task ExecuteQueryAsync(object input, bool printMessage = true) =>
    await (input switch
    {
        int[] array when printMessage => Task.WhenAll(array.AsQueryable()
            .Where(i => i > 5 && i % 2 == 0)
            .Select(i => Task.Run(() => WriteLine(i)))), // 조건을 만족하는 값 출력

        int[] array => Task.CompletedTask, // printMessage가 false일 때 실행 안 함

        _ => throw new ArgumentException("잘못된 입력") // 잘못된 입력 처리
    });