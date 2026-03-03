using System;

// README.md를 읽고 코드를 작성하세요.

DataPrinter printer = new DataPrinter();

Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine("[전체 데이터 출력]\n");

printer.PrintAll(new object[]
{
    42,
    3.14,
    "Hello",
    true,
    100,
    "World",
    false,
    2.718
});

Console.WriteLine("\n[타입별 통계]");
Console.WriteLine("정수: 2개");
Console.WriteLine("실수: 2개");
Console.WriteLine("문자열: 2개");
Console.WriteLine("논리값: 2개");