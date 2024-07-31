// System.Console.Writline();

// Метод - инструмент
// Класс - коробка, которая объединяет однотипные инструменты
// System - гараж (мастерская)

// Напишите программу которая будет принимать на входв два числа и 
// выводить являеться ли первое число кратно второму. Если первое
// число не кратно второму, то программа выводит остаток от деления.
// Пример:
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

System.Console.WriteLine("введите Первое число ");
int firstValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите Второе число ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if(firstValue % secondValue == 0)
{
    System.Console.WriteLine($"{firstValue}, {secondValue} => Да");
}
else
{
    System.Console.WriteLine($"{firstValue}, {secondValue} => Нет {firstValue % secondValue}");
}