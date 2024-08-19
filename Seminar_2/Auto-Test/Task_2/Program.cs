// Задайте массив из 10 элементов, заполненых числами от -10 до 10.
// Замените отрицательные числа на их абсолютные значения,
// а положительные числа на их отрицательные эквиваленты.

int[] array = { 1, -5, 6, -7, 3, -4, 8, 2, -9, 10 };

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// foreach (int n in array)
// {
//     System.Console.Write(n + "\t");
// }
