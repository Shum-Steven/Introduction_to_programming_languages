// Задайте двумерный массив целых чисел. Напишите программу,
// кототрая находит сумму элементов в каждом столбце массива и выводит её.
//     Пример:
// 1  2  3             Сумма элементов в столбце 0 : 22
// 4  5  6     =>      Сумма элементов в столбце 1 : 26
// 7  8  9             Сумма элементов в столбце 2 : 30
// 10 11 12

void Main()
{
    int row = dataEntry(" введите число строк: ");
    int col = dataEntry(" введите число столбцов: ");
    int[,] twoDarray = GenerateArray(row, col, 0, 13);
    PrintFirst(twoDarray);
    PrintSecond(colArray(twoDarray));
}

void PrintSecond(int[] array)
{
    System.Console.WriteLine();
    
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Сумма элементов в столбце {i}: {array[i]}");
    }
}

int[] colArray(int[,] twoDarray)
{
    int[] array = new int[twoDarray.GetLength(1)];

    for (int j = 0; j < twoDarray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < twoDarray.GetLength(0); i++)
        {
            sum += twoDarray[i, j];
        }
        array[j] = sum;
    }
    return array;
}

void PrintFirst(int[,] twoDarray)
{
    for (int i = 0; i < twoDarray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDarray.GetLength(1); j++)
        {
            System.Console.Write(twoDarray[i, j] + "\t");
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
