// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibo(int N)
{
    Console.Write("0 1 ");
    int a = 0, b = 1;
    for (int i = 2;  i < N; i++)
    {
        int result = a + b;
        a = b; 
        b = result;
        Console.Write(result + " ");
    }
}

int N = ReadInt("Input number: ");
Fibo(N);