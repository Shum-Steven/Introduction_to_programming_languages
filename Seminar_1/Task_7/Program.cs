// Напишите программу, которая выводит третью с конца цифру заданного
// числа или сообщает, что третей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третей цифры нет

System.Console.WriteLine("введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99)
// {
//     System.Console.WriteLine(number / 100 % 10);
//     // System.Console.WriteLine(number % 1000 / 100);
// }
// else
// {
//     System.Console.WriteLine("Нет Третьей Цифры!");
// }

// 123567 / 10 -> 12356 / 10 -> 1235 / 10 -> 123 % 10 -> 3
if(number > 99)
{
    while(number > 999)
        number /= 10; // number = number / 10

    System.Console.WriteLine(number % 10);
}
else
{     
    System.Console.WriteLine("Нет Третьей Цифры!");
}