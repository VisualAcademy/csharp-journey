int[] array = { 4, 8, 15, 16, 23 };

ExecuteQuery(array); // printMessage 기본값(true) 사용

void ExecuteQuery(int[] array, bool printMessage = true)
{
    var query = array.AsQueryable().Where(i => i > 5 && i % 2 == 0);

    if (printMessage)
        foreach (int value in query)
            WriteLine(value); // 기본적으로 값 출력
}