// Напишите программу которая на вход принимает трёхзначное число
// и удаляет вторую цифру этогоч сила.
// Примеры:
// a = 256 => 26
// a = 891 => 81

 System.Console.WriteLine("введите Трёхзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());

// string str1 = "key";
// string str2 = "word";
// // && - логическое И
// // || - логическое Или
// if (str1 == "key" && str2 == "word")
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

if(number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("число НеТрёхзначное!!!");
}

// if(number > 99 && number < 1000)
// {
//     int leftDigit = number / 100;
//     int rightDigit = number % 10;
//     string result = leftDigit + "" + rightDigit;
//     int integerResult = Convert.ToInt32(result);
//     System.Console.WriteLine(integerResult);
// }
// else
// {
//     System.Console.WriteLine("число НеТрёхзначное!!!");
// }

// if(number > 99 && number < 1000)
// {
//     System.Console.WriteLine(number /100 + "" + number % 10);
// }
// else
// {
//     System.Console.WriteLine("число НеТрёхзначное!!!");
// }