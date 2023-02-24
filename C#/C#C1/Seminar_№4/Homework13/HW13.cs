// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,7);
    }
}
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);

