// Заполните массив на N (вводится с консоли,не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива.
// Старший разряд числа находится на 0-м индексе, младший - на последнем.
// Пример:
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void Main()
{
    int sizeOFArray = ReadInt("Введите размера массива: ");
    if (sizeOFArray < 1 || sizeOFArray > 9)
    {
        System.Console.WriteLine("ОШИБКА! =Р");
        return;
    }
    int[] array = GenerateArray(sizeOFArray, 0, 9); // "1, 4, 2, 7, 2".Split(" , ");
    PrintArray(array);
    // Console.WriteLine("[" + string.Join(", ", array) + "]");

    // System.Console.WriteLine(string.Concat(array)); // Convert.ToInt32(string.Concat(array));
    System.Console.WriteLine(FromArrayToNumber(array));
}

int FromArrayToNumber(int[] array)
{
    int resultNumber = 0;

    foreach( int element in array)
    {
        resultNumber *= 10;
        resultNumber += element; 
    }
    return resultNumber;
}

void PrintArray(int[] ArrayForPrint)
{
    for (int i = 0; i < ArrayForPrint.Length; i++)
    {
        System.Console.Write(ArrayForPrint[i] + " ");
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