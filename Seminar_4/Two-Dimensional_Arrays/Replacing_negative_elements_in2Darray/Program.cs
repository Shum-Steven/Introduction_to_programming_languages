// Задайте двумерный массив. Замените все отрицательные числа
// на их абсолютные значения.
//     Пример:
//     1   -2  3       1   2   3
//     -4  5   -6  =>  4   5   6
//     7   -8  9       7   8   9

void Main()
{
    int row = dataEntry(" введите число строк: ");
    int col = dataEntry(" введите число столбцов: ");
    int[,] matrix = GenerateArray(row, col, -9, 10);
    PrintFirst(matrix);
    PrintSecond(absoluteValues(matrix));
}

void PrintSecond(int[,] absoluteValues)
{
    System.Console.WriteLine();
    for (int i = 0; i < absoluteValues.GetLength(0); i++)
    {
        for (int j = 0; j < absoluteValues.GetLength(1); j++)
        {
            System.Console.Write(absoluteValues[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] absoluteValues(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                matrix[i, j] *= -1;
            }
        }
    }
    return matrix;
}

void PrintFirst(int[,] matrix)
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

int[,] GenerateArray(int rowSize, int colSize, int minValue, int maxValue)
{
    int[,] tempArray = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return tempArray;
}

int dataEntry(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
