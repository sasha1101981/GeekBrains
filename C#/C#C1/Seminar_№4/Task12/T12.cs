// Задача 26: Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Count(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}
int n = ReadInt("Введите число: ");
System.Console.WriteLine($"Количество цифр в числе  {n} = {Count(n)}");