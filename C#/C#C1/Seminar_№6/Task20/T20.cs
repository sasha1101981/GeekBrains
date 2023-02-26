// // Задача 42: Напишите программу, которая будет преобразовывать 
// // десятичное число в двоичное.
// // 44 -> 101100
// // 3  -> 11
// // 2  -> 10

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
    if (num == 0) return;
    GetBinaryView(num / 2);
    System.Console.Write(num % 2);
}

int N = ReadInt("Введите число");
GetBinaryView(N);