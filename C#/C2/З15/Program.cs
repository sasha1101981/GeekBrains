//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

System.Console.WriteLine("input 2 numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1==number2 * number2 || number2 == number1*number1)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}