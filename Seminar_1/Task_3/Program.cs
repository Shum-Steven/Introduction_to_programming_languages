// Напишите программу, котороая принимает на вход трёхзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(1234 / 10 % 10);

// if(number > 99)
// {
//     if(number < 1000)
//     {
//         System.Console.WriteLine("Число трехзначное!!!");
//     }
// }
// else{
//     System.Console.WriteLine("Число не трехзначное");
// }

if (99 < number && number < 1000)
{
    int lefDigit = number / 100;
    int rightDigit = number % 10;
    int result = lefDigit + rightDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}