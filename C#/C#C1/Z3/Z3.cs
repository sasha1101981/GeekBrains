// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
// если число <0 т.ть  меньше  0 то пишем if (number < 0)
// {
//     number = -number;
// }
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number < 0)
{
    number = -number;
}
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + "  ");
}