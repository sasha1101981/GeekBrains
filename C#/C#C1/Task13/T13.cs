// // // Задача 28: Напишите программу, которая принимает на вход число N
// //  и выдаёт произведение чисел от 1 до N.
// // 4 -> 24 
// // 5 -> 120
// int ReadInt(string promp)
// { 
//     System.Console.WriteLine(promp);
//     return Convert.ToInt32(Console.ReadInt());
// }
// int Factorial(int number)
// {
//     int result = 1;

//     {
//         for (i = 2; i <= number; i++);
//     }
// return result;
// }
//  void Main(string[] args)
//         {
//             Console.WriteLine(Factorial(ReadInt("Enter a number: ")));
//         }
using System;

namespace seminar4
{
    class Program
    {
        static int ReadInt(string prompt){
            Console.WriteLine(prompt);
            return Math.Abs(Convert.ToInt32(Console.ReadLine()));
        }

        static int Factorial(int number){
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result = result * i; // result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(ReadInt("Enter a number: ")));
        }
    }
}