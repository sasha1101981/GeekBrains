﻿// Напишите программу, которая на вход принимает число и выдает его квадрат
//  (число умноженное на само себя).
// Например: 4 -> 16,-3 -> 9,-7 -> 49
Console.WriteLine("Введите число"); //Вывод в терминал приглашения пользователя во вводу числа
int number = Convert.ToInt32(Console.ReadLine());// получение числа терминала
int square = number * number;
System.Console.WriteLine($"Квадрат числа равен {square} ");