// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}


int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] array = GenArray(9, -9, 9);
PrintArray(array);

int[] newArray = CopyArray(array);
PrintArray(newArray);
//int[] newArray = array[..];конструкция для копирования
