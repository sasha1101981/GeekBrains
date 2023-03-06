// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] CreatingMatrix(int numberRows, int numberColumns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
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
int InputData(string text)
{
    System.Console.Write(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int[] InputMatrix(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
int[,] MatrixTurn(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[j,i] = matrix[i,j];
        }
    }
    return matrix2;
}

int numberRows = InputData("Введите необходимое количество строк матрицы: ");
int numberColumns = InputData("Введите необходимое количество столбцов матрицы: ");
int leftBorder = InputData("Введите левую границу для формирования матрицы: ");
int rightBorder = InputData("Введите правую границудля формирования матрицы: ");

int[,] myMatrix = CreatingMatrix(numberRows, numberColumns, leftBorder, rightBorder);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(MatrixTurn(myMatrix));