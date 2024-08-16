// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3]   => 2

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeOfArray, 0, 100);
    PrintArray(array);
    System.Console.WriteLine(CountElements(array, 1, 7));

    // int[] array2 = GenerateArray(10, -10, 10);
    // PrintArray(array2);
}

int CountElements(int[] array, int end, int div)
{
    int count = 0;

    foreach (int num in array)
    {
        if (num % 10 == end && num % div == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange, maxRange + 1);
    }

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();