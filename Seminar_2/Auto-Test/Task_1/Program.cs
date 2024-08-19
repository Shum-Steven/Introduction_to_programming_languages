// Задайте массив целых чисел. Напишите программу, кторая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует / Не присутствует

int[] numbers = { 1, 3, 4, 8, 19, 3 };
//System.Console.Write(" введите число для поиска в массиве: ");
int numberToFind = 8; //Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

foreach (int n in numbers)
{
    if (n == numberToFind)
    {
        numberIsFinded = true;
    } 
}
if(numberIsFinded)
    {
        System.Console.WriteLine("Присутствует");

    }
    else
    {  
        System.Console.WriteLine("Не присутствует");
    }