// Вычеслите значение формулы a * b / (c + d),
// где a, b, c, d - некоторые целые числа. Результат вывести на экран.

System.Console.WriteLine(" введите число для значения a : ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" введите число для значения b : ");
double b = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" введите число для значения c : ");
double c = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" введите число для значения d : ");
double d = Convert.ToDouble(Console.ReadLine());

double result = a * b / (c + d);
System.Console.Write(result );