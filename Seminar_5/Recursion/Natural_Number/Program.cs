// Напишите программу которая выведет все натуральные числа
// в промежутке от M до N. Используйте рекурсию и не используйте циклы.
//     Пример:
// * Вход: M = 1, N = 5.
// * Выход: 1, 2, 3, 4, 5.
// * Вход: M = 4, N = 8.
// * Выход: 4, 5, 6, 7, 8.

void Main()
{
    int M = ReadNaturals(" введите исходное натуральное число: ");
    int N = ReadNaturals(" введите конечное натуральное число: ");
    if (M < 1 || N < 1)
    {
        System.Console.WriteLine(" Вы ввели неврное значение ");
        return;
    }
    PrintNaturals(M, N);
}

void PrintNaturals(int M, int N)
{
    if (M > N)
    {
        System.Console.Write(M + " ");
        PrintNaturals(M - 1, N);
    }
    if (M < N)
    {
        System.Console.Write(M + " ");
        PrintNaturals(M + 1, N);
    }
    if(M == N)
    {
        System.Console.Write(N);
    }
}

int ReadNaturals(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
