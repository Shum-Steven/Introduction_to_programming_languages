// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"Да, {number} выполняет оба условия.");
}
else
{
    System.Console.WriteLine($"Нет, {number} не выполняет условия задачи");
}