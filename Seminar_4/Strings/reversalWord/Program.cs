// Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировтаь строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
//     Пример:
// "Hello my world" => "world my Hello"

System.Console.WriteLine(" напишите предложение ");
string? str = Console.ReadLine();
string[] stringArray = str!.Split();
int i = 0;
while(i < stringArray.Length / 2)
{
    string temp = stringArray[i];
    stringArray[i] = stringArray[stringArray.Length - 1 - i];
    stringArray[stringArray.Length - 1 - i] = temp;
    i++;
}
System.Console.WriteLine(string.Join(" ", stringArray));

// System.Console.WriteLine(" напишите предложение ");
// string? str = Console.ReadLine();
// string[] stringArray = str!.Split();
// for(int i = stringArray.Length - 1; i >= 0; i--)
// {
//     System.Console.Write("{0} ", stringArray[i]);
// }


// void Main()
// {
//     string? str = text(" напишите предложение: ");
//     string[] stringArray = str!.Split();
//     Array.Reverse(stringArray);
//     string[] reversedStr = new string(stringArray);
//     System.Console.WriteLine(reversedStr);
// }

// string? text(string msg)
// {
//     System.Console.Write(msg);
//     return Console.ReadLine();
// }
// Main();