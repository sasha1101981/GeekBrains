// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

double[,] CreateMatrix()
{
    double[,] matrix = new double[5, 5];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
void ChangeMatrix (double[,] matrix)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        double number = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1,j] = number;
    }
}

double[,] matrix = CreateMatrix();
PrintMatrix(matrix);
System.Console.WriteLine("");
ChangeMatrix(matrix);
PrintMatrix(matrix);