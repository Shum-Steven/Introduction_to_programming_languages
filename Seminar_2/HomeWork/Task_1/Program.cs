// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых
//  лежит в отрезке [20, 90].
// Пример:
//  массив [10 21 14 93 23] => 2

int[] array = { 10, 21, 14, 93, 23 };

// int i = 0;
// int counter = 0;

// while (i < array.Length)
// {
//     if (array[i] >= 20 && array[i] <= 90)
//     {
//         counter = counter + 1;
//     }
//     i++;
// }
// System.Console.WriteLine(" => " + counter);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i] <= 90)
//         counter = counter + 1;
// }
// Console.WriteLine($" => {counter}");

foreach (int number in array)
{
    if (number >= 20 && number <= 90)
        Console.Write(number + "\t");
}