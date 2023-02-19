// Задача №3. Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
// Решение через конструкцию "if и else где команда else if (если выполнится какоето 
//из условий тогда остальные не выполнятся


// System.Console.Write("Введитке число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1)
//     {
//         System.Console.Write("Понедельник");
//     }
//    else if (a == 2)
//     {
//         System.Console.Write("Вторник");
//     }
//     else if (a == 3)
//     {
//         System.Console.Write("Среда");
//     }
//     else if (a == 4)
//     {
//         System.Console.Write("Четверг");
//     }
//     else if (a == 5)
//     {
//         System.Console.Write("Пятница ");
//     }
//     else if (a == 6)
//     {
//         System.Console.Write("Суббота");
//     }
//     else if (a == 7)
//     {
//         System.Console.Write("Воскресенье");
//     }
//     else 
//         {
//             System.Console.WriteLine("Такого дня недели не сществует");
//         }
        //конструкция свич кейс
        System.Console.Write("Введитке номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());
 switch (day) {
        case 1:{
            System.Console.WriteLine("Понедельни");
            break;
        }
        case 2:{
            System.Console.WriteLine("Вторник");
            break;
        }
        case 3:{
            System.Console.WriteLine("Среда");
            break;
        }
        case 4:{
            System.Console.WriteLine("Четверг");
            break;
        }
        case 5:{
            System.Console.WriteLine("Пятница");
            break;
        }
        case 6:{
            System.Console.WriteLine("Суббота");
            break;
        }
        case 7:{
            System.Console.WriteLine("Воскресенье");
            break;
        }
        default:
        {
            System.Console.WriteLine("Такого дня недели не сществует");
            break;
        }
 }
