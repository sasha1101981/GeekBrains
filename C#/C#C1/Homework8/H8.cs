// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите число");
string? number = Console.ReadLine();
int a = number.Length;
if (a == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
         System.Console.WriteLine($"{number} - Палиндром");
    }
else
{
    System.Console.WriteLine($"{number} - НЕ палиндром");
}
}
else 
{
    System.Console.WriteLine("НЕ пятизначное число");
}

