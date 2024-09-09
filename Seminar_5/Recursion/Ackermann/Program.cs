// Напишите программу для вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//     Пример:
// * Вход: m = 2, n = 3
// * Выход: A(m, n) = 9
// * Вход: m = 1, n = 4
// * Выход: A(m, n) = 6

void Main()
{
    int m = ReadDigit(" введите первое положительное число ");
    int n = ReadDigit(" введите второе положительное число ");
    if (m < 0 || n < 0)
    {
        System.Console.WriteLine("число отрицательное");
        return;
    }
    int result = Ackermann(m, n);
    System.Console.WriteLine($"A({m}, {n}) = {result}");
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else return 0;
}

int ReadDigit(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();