// Напишите программу, которая принимает на вход трёхзначное число
// и возводит 2ую цифру этого числа в степень, равную третьей цифры.
// Пример:
// 487 => 8^7 == 2'097'152
// 254 => 5^4 == 625
// 617 => 1^7 == 1

System.Console.WriteLine("введите Трёхзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if(99 < number && number < 1000)
 {
    int middleDigit = number / 10 % 10;
    int rightDigit = number % 10;
    int power = 1;

    for( ; rightDigit > 0; rightDigit --)
    {
        power *= middleDigit; // middleDigit = middleDigit * 2
    }
    System.Console.WriteLine(power);
 }
 else
{
    System.Console.WriteLine("число НеТрёхзначное!!!");
}

// int number = 10;
// number *= 10; // number = number * 10;
// System.Console.WriteLine(number);