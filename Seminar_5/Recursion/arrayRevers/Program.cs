// Задайте произвольный массив. Выведите его элементы, начиная с концв.
// Используйте рекурсию и не используйте циклы.
//     Пример:
// * Вход: {1, 2, 3, 4, 5}
// * Выход: 5, 4, 3, 2, 1
// * Вход: {10, 20, 30, 40}
// * Выход: 40, 30, 20, 10

void Main()
{
    int size = ReadInt(" обозначьте длину массива ");
    int[] array = generateArray(size, -999, 1000);
    System.Console.WriteLine("[" + string.Join(" ", array) + "]");
    printRevers(array, array.Length - 1);
}

void printRevers(int[] array, int i)
{
    if (i < 0) return;
    System.Console.Write(array[i] + " ");
    printRevers(array, i - 1);
}

int[] generateArray(int size, int min, int max)
{
    int[] tempArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rnd.Next(min, max);
    }
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();