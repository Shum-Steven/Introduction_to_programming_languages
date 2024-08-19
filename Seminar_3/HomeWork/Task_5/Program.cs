// Напишите программу которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа 'q' или при вводе числа,
// сумма цифр которого четная.
// Пример:
//  5 12 16 q [STOP]
//  3 4 342 15 [STOP]

System.Console.WriteLine(" Программа готова бесконечно (*дай Бог ей оперативной памяти*) принимать вводимые Вами числа. Но есть одно НО: в случае чётной суммы цифр числа, программа остановится - ‘STOP’. Для выхода из программы нажмите ‘q’ ");
System.Console.WriteLine(" введите целое число: ");
while (true)
{
    string input = Console.ReadLine();
    // каким сопособом Принимать на ввод буквенные значения?
    if (input == "q")
    {
        System.Console.Write(" [STOP]");
        return;
    }
    else
    {
        int Value = Convert.ToInt32(input);
        int sum = 0;
        while (Value > 0)
        {
            int del = Value % 10;
            sum += del;
            Value /= 10;
        }
        if (sum % 2 == 0)
        {
            System.Console.Write(" [STOP]");
            return;
        }
    }
}