// Внутри класса Answer напишите метод FindMax, который 
// принимает на вход три числа и выдаёт маскимальное из этих чисел.

Console.WriteLine("введите Перовое число: ");
int a = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("введите Третье число: ");
int c = Convert.ToInt16(Console.ReadLine());

// int a = 7;
// int b = 137;
// int c = 13;

// int MAX = a;

// if (b > MAX)
// {
//     MAX = b;
// }
// if (c > MAX)
// {
//     MAX = c;
// }
// Console.WriteLine(MAX);

//     if (a > b && a > c)
//     {
//       System.Console.WriteLine(a);
//     }
//     else
//     {
//       if (b > c)
//       {
//         System.Console.WriteLine(b);
//       }
//       else
//       {
//         System.Console.WriteLine(c);
//       }
//     }

 if (a >= b && a >= c)
      {
          return a;
      }

      if (b >= a && b >= c)
      {
          return b;
      }

      else
      {
          return c;
      }