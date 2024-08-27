// Задайте двумерный массив целых чисел. напишите программу,
// которая транспортирует массив (меняет строки и столбцы местами)
//     Пример:
// 1 2
// 3 4   =>  1 3 5
// 5 6       2 4 6

void Main()
{
    int row = dataEntry(" введите число строк: ");
    int col = dataEntry(" введите число столбцов: ");
    int[,] matrix = GenerateArray(row, col, 0, 13);
    PrintFirst(matrix);
    int[,] newMatrix = tempMatrix(matrix);
    PrintSecond(newMatrix);
}

void PrintSecond(int[,] newMatrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            System.Console.Write(newMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] tempMatrix(int[,] matrix)
{
    int contRow = matrix.GetLength(0);
    int contCol = matrix.GetLength(1);
    int[,] transMatrix = new int[contCol, contRow];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            transMatrix[j, i] = matrix[i, j];
        }
    }
    return transMatrix;
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
