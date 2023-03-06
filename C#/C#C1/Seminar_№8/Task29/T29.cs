// Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, 
//  сколько раз встречается элемент входных данных.

static int[] CountElems(int[,] array)
{
    int[] countDictionary = new int[9];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            countDictionary[array[i, j] - 1]++;
        }
    }
    return countDictionary;
}

static void WriteCountDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            Console.WriteLine(i + 1 + " встречается " + array[i] + " раз");
        }
    }
}

static void Main(string[] args)
{
    int[,] matrix = CreatingMatrix(4, 4);
    PrintMatrix(matrix);
    WriteCountDictionary(CountElems(matrix));
}