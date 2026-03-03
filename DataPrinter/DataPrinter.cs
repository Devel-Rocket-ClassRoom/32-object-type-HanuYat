using System;

class DataPrinter
{
    public void PrintData(object data)
    {
        switch (data.GetType().Name)
        {
            case "Int32":
                Console.WriteLine($"정수: {(int)data}");
                break;

            case "Double":
                Console.WriteLine($"실수: {(double)data:F2}");
                break;

            case "String":
                Console.WriteLine($"문자열: \"{(string)data}\" (길이: {data.ToString().Length})");
                break;

            case "Boolean":
                Console.WriteLine($"논리값: {(bool)data} → {(((bool)data) ? "참" : "거짓")}");
                break;

            default:
                Console.WriteLine($"알 수 없는 타입: {data.GetType().Name} - {data}");
                break;
        }
    }

    public void PrintAll(object[] data)
    {
        foreach (var item in data)
        {
            PrintData(item);
        }
    }
}