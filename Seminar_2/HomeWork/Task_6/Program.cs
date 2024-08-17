// Задайте массив заполненный случайным трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [344 452 341 125] => 2

void Main()
{
    int sizeOfArray = ReadInt(" введите Размер массива: ");
    int[] array = GenerateArray(sizeOfArray, 100, 1000);
    PrintArray(array);
    System.Console.Write(" => " + CountElements(array, 2));
}

int CountElements(int[] array, int even)
{
    int count = 0;

    foreach (int number in array)
    {
        if (number % even == 0)
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
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange, maxRange);
    }
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
