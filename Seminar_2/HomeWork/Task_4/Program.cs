// Дано натуральное число в диапозоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Страший разряд числа должен распологаться на 0-м индекск массива,
// младший - на последнем. Размер массива должен быть равен количеству цифр.
// Пример:
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

System.Console.Write(" введите Натуральное число: ");
int Value = Convert.ToInt32(Console.ReadLine());

if (Value < 1 || Value > 99999)
{
    Console.WriteLine("ОШИБКА! =Р");
}

int Number = Value;
int count = 0;

while (Number > 0)
{
    Number /= 10;
    count++;
}

int[] Array = new int[count];
 
for (int i = 0; i < Array.Length; i++)
{
    Array[Array.Length - 1 - i] = Value % 10;
    Value /= 10;
}
// System.Console.WriteLine("[" + Array + "]"); // !Ошибка преобразования [System.Int32[]]
Console.WriteLine("[" + string.Join(" ", Array) + "]");