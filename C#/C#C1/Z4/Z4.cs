// Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.Write("Введите число ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number <= 99 && number < 1000)
{
    int x = number % 10;
    System.Console.Write(x);
}
else 
{
    System.Console.Write("Введено неправильное число");
}
