// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

System.Console.WriteLine(" введите Натуральное Число ");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 0)
{
    while(N > 0)
    {
    int result = N % 10;
    System.Console.Write($"{result}, ");
    N /= 10;
    }
}
else
{
    System.Console.WriteLine("значение не соотвествует условию");
}