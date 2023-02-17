// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите первое число ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 1;

while (number1 <= number)
{
    if (number1 % 2 == 0)
        Console.Write(number1 + " ");
    number1++;
}
