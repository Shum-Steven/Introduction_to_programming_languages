// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.
// Пример:
// [1 3 4 19 3] => 2
// [4 3 1 9 5 21 13] => 3

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");

    if (sizeOfArray < 1)
    {
        System.Console.WriteLine("Некорректные значенияя!");
        return;
    }

    int[] array = GenerateArray(sizeOfArray, 0, 99);
    PrintArray(array);

    System.Console.WriteLine(CountPrimal(array));
}

int CountPrimal(int[] array)
{
    int count = 0;

    foreach (int number in array)
        if (isPrimal(number))
            count++;

    return count;
}

bool isPrimal(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;

    return true;
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