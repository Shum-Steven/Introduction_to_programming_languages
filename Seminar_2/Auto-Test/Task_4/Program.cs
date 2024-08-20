// Задайте массив целлых чисел. Напишите программу,
// которая удаляет все отрицательные числа из массива
// и возвращает новый массив, содержащий только неотрицательные числа.

int[] array = { 5, -3, 9, -1, 2, -7, 0 };
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > -1)
    {
        count++;
    }
}

int[] newArray = new int[count];

for (int j = 0, s = 0; j < array.Length; j++)
{
    if (array[j] > -1)
    {
        newArray[s] = array[j];
        s++;
    }
}

System.Console.WriteLine("[" + string.Join(", ", newArray) + "]");

// void Main()
// {
//     int[] array = {5, -3, 9, -1, 2, -7, 0};
//     int[] newArray = positive(array);
//     System.Console.WriteLine("[" + string.Join(", ", newArray) + "]");
// }

// int[] positive(int[] array)
// {
//     return array.Where(n => n >= 0).ToArray();
// }
// Main();