int[] array = { 4, 8, 15, 16, 23 };

var input = new QueryInput { Data = array };

// 기존 데이터를 변경하여 새로운 record 생성
var modifiedInput = input with { Data = [.. array.Where(i => i % 2 == 0)] };

await ExecuteQueryAsync(modifiedInput);

async Task ExecuteQueryAsync(object input, bool printMessage = true) =>
    await (input switch
    {
        QueryInput { Data: int[] array } when printMessage
            => Task.WhenAll(array.AsQueryable()
                .Where(i => i > 5 && i % 2 == 0)
                .Select(i => Task.Run(() => WriteLine(i)))),
        QueryInput => Task.CompletedTask,
        _ => throw new ArgumentException("Invalid input type")
    });

// C# 9.0: record 타입 사용
record QueryInput
{
    public int[] Data { get; init; } = [];
}