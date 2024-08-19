// Напишите программу которая перевернет одномерный массив
// (первый элемент станет последним, второй - предпоследним и т.д.)
// Пример
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

void Main()
{
    int sizeOfArray = ReadInt(" введите Размер массива: ");
    int[] array = GenerateArray(sizeOfArray, -999, 1000);
    PrintArray(array);
    Console.Write(" => ");
    int[] turnArray = reflection(array);
    PrintReflection(turnArray);
}

void PrintReflection(int[] reflectionForPrint)
{
    foreach (int Value in reflectionForPrint)
    {
        Console.Write(Value + " ");
    }
}

int[] reflection(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
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
