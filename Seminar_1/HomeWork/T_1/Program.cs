// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число большее, а какое меньшее:

Console.WriteLine("Введите перовое число: ");
int firstNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

// byte firstNumber = 5;
// byte secondNumber = 6;

// byte firstNumber = 6;
// byte secondNumber = 3;

// byte firstNumber = 3;
// byte secondNumber = 3;

// if (firstNumber >= secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }

if (firstNumber > secondNumber)
{
    Console.WriteLine("первое число больше " + firstNumber);
}
else
{
   if (firstNumber < secondNumber)
   {
        Console.WriteLine($"второе число больше {secondNumber}");
   }
   else
   {
        // int value = Convert.ToInt32(firstNumber == secondNumber) * firstNumber;
        // Console.WriteLine("Числа Равны " + value);
        Console.WriteLine("Числа Равны ");
   }
}