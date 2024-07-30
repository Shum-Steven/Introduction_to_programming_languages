// Внутри класса Answer напишите метод PrintEvenNumbers,
// которая на вход принимает число (number), а на выходе 
// выводит все чётные числа от 1 до number (включительно),
// после каждого числа должен быть знак пробела.

Console.WriteLine("введите положительно число ");
long number = Convert.ToInt64(Console.ReadLine());

// uint number = 5;
// uint number = 8;

// int i = 1;
// while(i <= number)
// {
//     if(i % 2 == 0)
//     System.Console.Write(i + " ");
//     i = i + 1;
// }

for ( int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    System.Console.Write($"{i} ");
}