// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив,
// состоящий из средних арифмитических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1   =>   [3 3 5]
// 2 9 5 4

void Main()
{
    int row = ReadInt(" введите количество Строк: ");
    int col = ReadInt(" введите количество Столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, -13, 13);
    PrintMatrix(matrix);
    PrintArray(FindAvarages(matrix));
}

void PrintArray(double[] array)
{
    System.Console.Write(string.Join(", ",array));
}

double[] FindAvarages(int[,] matrix)
{
    double[] avarages = new double[matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            avarages[i] += matrix[i,j]; 
        }
        avarages[i] = Math.Round(avarages[i] / matrix.GetLength(1), 2);
    }
    return avarages;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] GenerateMatrix(int rowSize, int colSize, int minValue, int maxValiu)
{
    int[,] tempMatrix = new int[rowSize, colSize];
    Random rnd = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = rnd.Next(minValue, maxValiu);
        }
    }
    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();