// Напишите программу, которая принимает на вход целое число из отрезка [10,99]
// и показывает наибольшую цифру числа.

System.Console.WriteLine(" введите Целое число от 10 до 99 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    
    if(leftDigit >= rightDigit)
    {
        System.Console.WriteLine($" {leftDigit} наибольшая цифра");
    }
    else
    {
        System.Console.WriteLine($" {rightDigit} наибольшая цифра");
    }
}
else
{
    System.Console.WriteLine(" число не соответствует условиям ");
}