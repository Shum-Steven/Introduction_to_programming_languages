// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Программа должна выдать ответ: да/нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] numbers = { 1, 3, 4, 19, 3 };

// for(int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

// int sum = 0;

foreach(int number in numbers)
{
    Console.Write(numbers + " ");
}

System.Console.WriteLine();
Console.Write("Введите число: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false; // мы еще не нашли переменную

foreach(int number in numbers)
{
    if(number == numberToFind);
    {
        numberIsFinded = true; // мы нашли переменную
    }
}
// System.Console.WriteLine(numberIsFinded);
if(numberIsFinded)
{
    System.Console.WriteLine("Значение найдено!");
}
else
{
    System.Console.WriteLine("Значение НЕТ");
}