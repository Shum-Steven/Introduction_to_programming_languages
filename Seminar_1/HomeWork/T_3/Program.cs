// Внутри класса Answer напишите метод CheckIfEven, который на вход 
// принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

// int number = 6;

// int number = 3;

if (number % 2 == 0)
{
    Console.WriteLine("Число чётное ");
}
if (number % 2 == 1)
{
    Console.WriteLine("Число нечётное ");
}