// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример:
// [1 5 11 21 81 4 0 91 2 3]   => 2

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeOfArray);
    PrintArray(array);
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size)
{
    int[] tempArray = new int[size];

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(0, 10);
    }

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();