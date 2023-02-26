// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void TriCheck(int[] arr)
{
    if (arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1] && arr[1] + arr[0] > arr[2])
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}

int[] ImputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[] triangle = ImputArray("Input 3 numbers");
PrintArray(triangle);
TriCheck(triangle);