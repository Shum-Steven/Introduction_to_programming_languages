// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдает номер координатной четверти плоскости,
// в котрой находится эта точка

System.Console.WriteLine("введите значение X :");
int X = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите значение Y :");
int Y = Convert.ToInt32(Console.ReadLine());

if(X == 0 || Y == 0)
{
    Console.WriteLine(" точка находится на оси координат ");
}
if(X > 0 && Y > 0)
{
    Console.WriteLine(" I номер координатной четверти ");
}
if(X < 0 && Y > 0)
{
    Console.WriteLine(" II номер координатной четверти ");
}
if(X < 0 && Y < 0)
{
    Console.WriteLine(" III номер координатной четверти ");
}
if(X > 0 && Y < 0)
{
    Console.WriteLine("IV номер координатной четверти ");
}