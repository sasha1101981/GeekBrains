// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Первый способ 
// System.Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
//     if (a == 7)
//     {
//         System.Console.WriteLine("Выходной Воскресенье");
//     }
//     else if (a == 6)
//     {
//         System.Console.WriteLine("Выходной субота");
//     }
//     else
//     {
//         System.Console.WriteLine("Рабочий день");

//Второй способ
System.Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 6:
        {
            System.Console.WriteLine("Выходной Суббота");
            break;
        }
    case 7:
        {
            System.Console.WriteLine("Выходной Воскресенье");
            break;
        }
    default:
        {
            System.Console.WriteLine("Рабочий день");
            break;
        }
}