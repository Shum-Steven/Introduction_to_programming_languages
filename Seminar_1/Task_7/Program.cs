// Напишите программу, которая выводит третью с конца цифру заданного
// числа или сообщает, что третей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третей цифры нет

System.Console.WriteLine("введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    System.Console.WriteLine(number / 100 % 10);
    // System.Console.WriteLine(number % 1000 / 100);
}
else
{
    System.Console.WriteLine("Нет Третьей Цифры!");
}