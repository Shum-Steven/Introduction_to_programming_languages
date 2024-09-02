// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
//     Пример:
// "aBcD1tf!-" =>  "abcd1ef!-"

System.Console.WriteLine("Постучите по клавиауре, порой зажимая 'shift' : ");
string str = Console.ReadLine()!.ToLower();
System.Console.WriteLine(str);