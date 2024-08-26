// Задайте двумерный массив целых чисел. Напишите программу,
// которая находит максимальный элемент в каждой строке массива и выводит его.
//     Пример:
// 1  3  5  7      Максимальный элемент в строке 0 : 7
// 2  4  6  8  =>  Максимальный элемент в строке 1 : 8
// 9 10 11 12      Максимальный элемент в строке 2 : 12

void Main()
{
    int row = dataEntry(" введите количество Строк: ");
    int col = dataEntry(" введите количество Столбцов: ");
    int[,] integersArray = GenerateArray(row, col, 1, 13);
    PrintArray(integersArray);
    System.Console.Write(" => ");
    // int[] array = FindMax(integersArray);
    // PrintMaxArray(array);
    PrintMaxArray(FindMax(integersArray));
}

void PrintMaxArray(int[] array)
{
    Console.Write("[" + string.Join(" ", array) + "]");
}

int[] FindMax(int[,] integersArray)
{
    int[] maxArray = new int[integersArray.GetLength(0)];

    for (int i = 0; i < integersArray.GetLength(0); i++)
    {
        int max = integersArray[i, 0];
        for (int j = 1; j < integersArray.GetLength(1); j++)
        {
            if (max < integersArray[i, j])
            {
                max = integersArray[i, j];
            }
        }
        maxArray[i] = max;
    }
    return maxArray;
}

void PrintArray(int[,] matrix)
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