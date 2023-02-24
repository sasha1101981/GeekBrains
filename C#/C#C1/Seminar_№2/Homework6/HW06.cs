// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введимте число");
string? number = Console.ReadLine();
if (number!.Length < 4 )
{
    System.Console.WriteLine("третьей цифры нет");
}
     else
{
    System.Console.WriteLine(number[3]);
}