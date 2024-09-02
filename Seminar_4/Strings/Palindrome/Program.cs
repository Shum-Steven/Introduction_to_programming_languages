// Задайте произвольную строку.
// Выясните, является ли она палиндромом
//     Пример:
// "aBcD1ef!-" => Нет
// "шалаш" => Да
// "55655" => Да

System.Console.Write("введите Палиндром : ");
string? str = Console.ReadLine();
char[] palindrom = new char[str!.Length];

for(int i = 0; i < str.Length; i++)
{
    palindrom[i] = str[i];
}

int j = 0;
while(j < palindrom.Length)
{
    if (palindrom[j] == palindrom[palindrom.Length - 1 - j])
    {
        j++;
    }
    else
    {
        System.Console.Write(" => Нет ");
        return;
    }
}
System.Console.Write(" => Да ");
