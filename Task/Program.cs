string[] ReadArrStr(string text)
{
    Console.Write(text);
    return Console.ReadLine().Split(", ");
}