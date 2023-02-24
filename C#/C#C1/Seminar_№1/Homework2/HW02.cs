// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("Максимальное число: " + number1);
    }
    else
    {
        Console.Write("Максимальное число: " + number3);
    }
}

else if (number2 > number3)
{
    Console.Write("Максимальное число: " + number2);
}
else
{
    Console.Write("Максимальное число: " + number3);
}