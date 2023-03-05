// Задача 49: Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Артём Макеев 18:24Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
    return matrix;
}
void NewMatrix(int[,] matrix)
{

    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {


            matrix[i, j] *= matrix[i, j];

        }
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();
    }

}


System.Console.WriteLine("Введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
NewMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);