// Задайте массив из 10 целых чисел.
// Найдите среднее значение элементов массива. 

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    sum += array[i]; // sum = sum + array[i];
}

double avr = sum / array.Length;
System.Console.WriteLine(avr);