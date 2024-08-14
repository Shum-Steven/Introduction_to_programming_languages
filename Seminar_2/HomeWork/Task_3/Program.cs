// Задайте массив из вещественных чисел с нулевой дробной часть.
// Найдите разницу между максимальным и минимальным элементом массива.
// Пример:
// 
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
// int i = 0;
double FindMax = array[0];
double FindMin = array[0];

// while (i < array.Length)
// {
//     if (array[i] > FindMax)
//     {
//         FindMax = array[i];
//     }
//     if (array[i] < FindMin)
//     {
//         FindMin = array[i];
//     }
//     i++;
// }
// Console.WriteLine(FindMax);
// Console.WriteLine(FindMin);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > FindMax)
//     {
//         FindMax = array[i];
//     }
//     if (array[i] < FindMin)
//     {
//         FindMin = array[i];
//     }
// }
// Console.WriteLine(FindMax);
// Console.WriteLine(FindMin);

foreach (double number in array)
{
    if (number > FindMax)
    {
        FindMax = number;
    }
    if (number < FindMin)
    {
        FindMin = number;
    }
}
Console.WriteLine(FindMax);
Console.WriteLine(FindMin);

double result = FindMax - FindMin;
System.Console.WriteLine($" =>  {result}");
