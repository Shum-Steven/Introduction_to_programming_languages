// Задайте массив из 10 элементов, заполненый числами из промежутка [-10, 10].
// Заменительные отрицательные элементы на положительные,
// а положительные на отрицательные.
// Пример:
//  [1 -5 6]
//  => [-1 5 -6]

int[] numbers = { 1, -5, 6, 6, 3, 9, -7 };

foreach (int number in numbers)
{
    System.Console.Write(number + "\t");
}
System.Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}

foreach(int number in numbers)
{
    System.Console.Write(number + "\t");
}